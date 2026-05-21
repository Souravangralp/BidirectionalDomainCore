namespace Bidirectional.DomainCore.Persistence;

/// <summary>
/// Explicit registry for entities that are truly shared across modules (single table, <see cref="PlatformSchemas.Common"/>).
/// Homonym types listed in <see cref="EntityHomonymRegistry"/> stay in loan/onboarding schemas until replaced
/// by a single canonical type under <c>Bidirectional.DomainCore.Common.Entities</c>.
/// </summary>
public static class EntitySchemaRegistry
{
    /// <summary>
    /// CLR types mapped to the <c>common</c> schema. Register only after:
    /// <list type="bullet">
    /// <item>One canonical entity lives in <c>Common/Entities</c></item>
    /// <item>Module-specific duplicates are removed from Bid/Onboarding</item>
    /// <item>Navigation properties and migrations are updated</item>
    /// </list>
    /// </summary>
    public static IReadOnlyCollection<Type> SharedEntityTypes { get; } = Array.Empty<Type>();
}
