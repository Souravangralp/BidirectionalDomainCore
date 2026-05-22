using Bidirectional.DomainCore.BidOnboard.Entities;
using Bidirectional.DomainCore.Calculator.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Helpers;

/// <summary>
/// Provides extension methods for configuring model builder behaviors, including temporal table support.
/// </summary>
[ExcludeFromCodeCoverage]
public static class ModelBuilderExtensions
{
    /// <summary>
    /// Configures temporal tables for applicable entities in the model, enabling automatic history tracking
    /// for entities that are not derived from <c>BaseEvent</c> and are assignable from <c>ApprovalRequest</c>.
    /// </summary>
    /// <param name="modelBuilder">The <see cref="ModelBuilder"/> to which the temporal table configuration will be applied.</param>
    public static void ApplyTemporalTableConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationVersion>()
           .Property(p => p.ChangeVersionTime)
           .HasDefaultValueSql("GETUTCDATE()");

        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (!typeof(BaseEvent).IsAssignableFrom(entityType.ClrType) && typeof(ApprovalRequest).IsAssignableFrom(entityType.ClrType))
            {
                string? tableName = entityType.GetTableName();
                if (tableName != null)
                {
                    modelBuilder.Entity(entityType.ClrType).ToTable(tableName, b => b.IsTemporal(b =>
                    {
                        b.HasPeriodStart("ValidFrom");
                        b.HasPeriodEnd("ValidTo");
                        b.UseHistoryTable($"{entityType.GetTableName()}History");
                    }));
                }
            }
        }
    }
}
