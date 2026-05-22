using Bidirectional.DomainCore.BidOnboard.Entities;
using Bidirectional.DomainCore.Common;
using Bidirectional.DomainCore.ProductMatrix.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Bidirectional.DomainCore.Persistence;

public partial class PlatformDbContext
{
    private static readonly JsonSerializerSettings AuditJsonSettings = new()
    {
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        ContractResolver = new DefaultContractResolver
        {
            IgnoreSerializableAttribute = true
        }
    };

    /// <summary>
    /// Gathers audit entries before saving changes. Entries with database-generated keys are deferred until <see cref="OnAfterSaveChanges"/>.
    /// </summary>
    /// <returns>Audit entries that still have temporary (e.g. identity) properties.</returns>
    private List<AuditEntry> OnBeforeSaveChanges()
    {
        string user = _currentUserService?.UserID ?? "default";
        string? userIPAddress = _getLocalUserIPAddress?.GetLocalIPAddress();

        ChangeTracker.DetectChanges();

        List<AuditEntry> auditEntries = new();

        AddAuditLogEntry(user, userIPAddress, auditEntries);

        foreach (AuditEntry auditEntry in auditEntries.Where(a => !a.HasTemporaryProperties))
        {
            AuditLogs.Add(auditEntry.ToAudit());
        }

        return auditEntries.Where(a => a.HasTemporaryProperties).ToList();
    }

    /// <summary>
    /// Builds audit entries from the current change tracker state.
    /// </summary>
    private void AddAuditLogEntry(string user, string? userIPAddress, List<AuditEntry> auditEntries)
    {
        foreach (EntityEntry entry in ChangeTracker.Entries())
        {
            if (entry.Entity is AuditLog
                || entry.State == EntityState.Detached
                || entry.State == EntityState.Unchanged)
            {
                continue;
            }

            AuditEntry auditEntry = new(entry)
            {
                AffectedTableName = entry.Metadata.GetTableName(),
                User = user,
                UserIPAddress = userIPAddress
            };

            auditEntries.Add(auditEntry);

            foreach (PropertyEntry property in entry.Properties)
            {
                if (property.IsTemporary)
                {
                    auditEntry.TemporaryProperties.Add(property);
                }
            }

            switch (entry.State)
            {
                case EntityState.Added:
                    auditEntry.CurrentValues = JsonConvert.SerializeObject(entry.Entity, AuditJsonSettings);
                    auditEntry.Action = EntityState.Added.ToString();
                    break;

                case EntityState.Deleted:
                    auditEntry.PreviousValues = JsonConvert.SerializeObject(
                        entry.GetDatabaseValues()?.ToObject(),
                        AuditJsonSettings);
                    auditEntry.Action = EntityState.Deleted.ToString();
                    break;

                case EntityState.Modified:
                    var modifiedProperties = entry.Properties
                        .Where(p => p.IsModified
                            && !Equals(p.OriginalValue, p.CurrentValue)
                            && p.Metadata.Name != nameof(BaseAuditableEntity.LastModifiedAus)
                            && p.Metadata.Name != nameof(BaseAuditableEntity.CreatedAus))
                        .Select(p => new
                        {
                            PropertyName = p.Metadata.Name,
                            p.OriginalValue,
                            p.CurrentValue
                        })
                        .ToList();

                    if (modifiedProperties.Count == 0)
                    {
                        auditEntries.Remove(auditEntry);
                        break;
                    }

                    auditEntry.PreviousValues = JsonConvert.SerializeObject(
                        modifiedProperties.Select(p => new { p.PropertyName, p.OriginalValue }),
                        AuditJsonSettings);

                    auditEntry.CurrentValues = JsonConvert.SerializeObject(
                        modifiedProperties.Select(p => new { p.PropertyName, p.CurrentValue }),
                        AuditJsonSettings);

                    auditEntry.Action = EntityState.Modified.ToString();
                    break;
            }
        }
    }

    /// <summary>
    /// Persists deferred audit entries after keys and other temporary properties are materialized.
    /// </summary>
    private async Task OnAfterSaveChanges(List<AuditEntry> auditEntries, CancellationToken cancellationToken)
    {
        if (auditEntries is null || auditEntries.Count == 0)
        {
            return;
        }

        JsonSerializerSettings settings = new()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        foreach (AuditEntry auditEntry in auditEntries)
        {
            foreach (PropertyEntry prop in auditEntry.TemporaryProperties)
            {
                if (prop.Metadata.IsPrimaryKey())
                {
                    auditEntry.ChangedKeyValues[prop.Metadata.Name] = prop.CurrentValue ?? string.Empty;
                }
                else
                {
                    auditEntry.CurrentValues = SerializeEntity(prop.CurrentValue!, settings);
                }
            }

            AuditLogs.Add(auditEntry.ToAudit());
        }

        await base.SaveChangesAsync(cancellationToken);
    }

    private static string SerializeEntity(object entity, JsonSerializerSettings settings)
    {
        if (entity is null)
        {
            return string.Empty;
        }

        return JsonConvert.SerializeObject(entity, settings);
    }

    private sealed class AuditEntry(EntityEntry entry)
    {
        public EntityEntry Entry { get; } = entry;

        public string? AffectedTableName { get; set; }

        public string? User { get; set; }

        public string? UserIPAddress { get; set; }

        public string? Action { get; set; }

        public string? CurrentValues { get; set; }

        public string? PreviousValues { get; set; }

        public Dictionary<string, object> ChangedKeyValues { get; } = new(StringComparer.Ordinal);

        public List<PropertyEntry> TemporaryProperties { get; } = [];

        public bool HasTemporaryProperties => TemporaryProperties.Count > 0;

        public AuditLog ToAudit()
        {
            return new AuditLog
            {
                TableName = AffectedTableName,
                UserID = User,
                UserIPAddress = UserIPAddress,
                Action = Action,
                AuditLogDetails = new AuditLogDetail
                {
                    OldValue = PreviousValues,
                    NewValue = CurrentValues
                },
                ChangedKeyValues = ChangedKeyValues.Count > 0
                    ? JsonConvert.SerializeObject(ChangedKeyValues)
                    : null
            };
        }
    }
}
