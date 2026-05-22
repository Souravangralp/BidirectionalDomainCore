using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Provides soft deletion query filter utilities for entities implementing the <see cref="ISoftDelete"/> interface.
/// Ensures that entities marked as deleted are filtered out by default in queries.
/// </summary>
public static class SoftDelete
{
    /// <summary>
    /// Applies the soft delete query filter for the specified entity type at runtime.
    /// </summary>
    /// <param name="modelBuilder">The model builder being used to configure the entity.</param>
    /// <param name="entityType">The entity type which supports soft deletion.</param>
    public static void SetSoftDelete(this ModelBuilder modelBuilder, Type entityType)
    {
        SetSoftDeleteMethod.MakeGenericMethod(entityType)
            .Invoke(null, new object[] { modelBuilder });
    }

    static readonly MethodInfo SetSoftDeleteMethod = typeof(SoftDelete)
        .GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Single(t => t.IsGenericMethod && t.Name == "SetSoftDelete");

    /// <summary>
    /// Configures a global query filter to exclude entities marked as deleted (ISDeleted = true).
    /// </summary>
    /// <typeparam name="TEntity">The entity type implementing <see cref="ISoftDelete"/>.</typeparam>
    /// <param name="modelBuilder">The model builder used for entity type configuration.</param>
    public static void SetSoftDelete<TEntity>(this ModelBuilder modelBuilder)
        where TEntity : class, ISoftDelete
    {
        modelBuilder.Entity<TEntity>().HasQueryFilter(x => !x.ISDeleted);
    }

    /// <summary>
    /// Applies the standard soft-delete filter (<c>!ISDeleted</c>) to every mapped entity whose CLR type implements <see cref="ISoftDelete"/>.
    /// Owned types and shadow-only types are skipped.
    /// </summary>
    /// <param name="modelBuilder">The model builder for the context.</param>
    public static void ApplyGlobalSoftDeleteFilters(this ModelBuilder modelBuilder)
    {
        foreach (IEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.IsOwned())
                continue;

            Type? clrType = entityType.ClrType;
            if (clrType is null || clrType == typeof(object))
                continue;

            if (typeof(ISoftDelete).IsAssignableFrom(clrType))
                modelBuilder.SetSoftDelete(clrType);
        }
    }
}
