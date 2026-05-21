using Bidirectional.DomainCore.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bidirectional.DomainCore.Persistence;

/// <summary>
/// Assigns SQL schemas from DomainCore module ownership (folder / namespace segment after <c>Bidirectional.DomainCore</c>).
/// Does not alter relationships, keys, or Fluent API configuration.
/// </summary>
public static class EntitySchemaConvention
{
    private static readonly IReadOnlyDictionary<string, string> ModuleSchemaMap =
        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            [PlatformModules.Shared] = PlatformSchemas.Shared,
            [PlatformModules.Common] = PlatformSchemas.Shared,
            [PlatformModules.BidOnboard] = PlatformSchemas.BidOnboard,
            [PlatformModules.Calculator] = PlatformSchemas.Calculator,
            [PlatformModules.Postcode] = PlatformSchemas.Postcode,
            [PlatformModules.ProductMatrix] = PlatformSchemas.ProductMatrix,
        };

    public static void Apply(ModelBuilder modelBuilder)
    {
        ExcludeDomainEventEntities(modelBuilder);

        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.GetTableName() is null)
            {
                continue;
            }

            if (IsDomainEventType(entityType.ClrType))
            {
                continue;
            }

            entityType.SetSchema(ResolveSchema(entityType.ClrType));
        }
    }

    /// <summary>
    /// Removes MediatR domain event types from the EF model (they are not persisted).
    /// </summary>
    public static void ExcludeDomainEventEntities(ModelBuilder modelBuilder)
    {
        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes().ToList())
        {
            if (IsDomainEventType(entityType.ClrType))
            {
                modelBuilder.Model.RemoveEntityType(entityType);
            }
        }
    }

    private static bool IsDomainEventType(Type clrType) =>
        typeof(BaseEvent).IsAssignableFrom(clrType);

    internal static string ResolveSchema(Type clrType)
    {
        if (EntitySchemaRegistry.SharedEntityTypes.Contains(clrType))
        {
            return PlatformSchemas.Shared;
        }

        string? module = GetDomainCoreModule(clrType.Namespace);
        if (module is not null && ModuleSchemaMap.TryGetValue(module, out string? schema))
        {
            return schema;
        }

        throw new InvalidOperationException(
            $"Cannot resolve SQL schema for entity '{clrType.FullName}'. " +
            $"Use namespace Bidirectional.DomainCore.{{Module}}.* or register the type in {nameof(EntitySchemaRegistry)}.");
    }

    private static string? GetDomainCoreModule(string? namespaceName)
    {
        if (string.IsNullOrWhiteSpace(namespaceName))
        {
            return null;
        }

        const string prefix = "Bidirectional.DomainCore.";
        if (!namespaceName.StartsWith(prefix, StringComparison.Ordinal))
        {
            return null;
        }

        string remainder = namespaceName[prefix.Length..];
        int dot = remainder.IndexOf('.');
        return dot >= 0 ? remainder[..dot] : remainder;
    }
}
