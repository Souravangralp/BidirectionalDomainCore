using Bidirectional.DomainCore.BidOnboard.Assessment.Assignments;
using Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;
using Bidirectional.DomainCore.BidOnboard.Assessment.Templates;
using Bidirectional.DomainCore.BidOnboard.Entities.Branches;
using Bidirectional.DomainCore.BidOnboard.Entities.Crms;
using Bidirectional.DomainCore.BidOnboard.Entities.Generals.Countries;
using Bidirectional.DomainCore.BidOnboard.Entities.Generals.Industries;
using Bidirectional.DomainCore.BidOnboard.Entities.Generals.Occupations;
using Bidirectional.DomainCore.BidOnboard.Entities.Generals;
using Bidirectional.DomainCore.BidOnboard.Entities.Leads;
using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;
using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities.Modules;
using Bidirectional.DomainCore.BidOnboard.Entities.Organizations;
using Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;
using Bidirectional.DomainCore.BidOnboard.Entities.UserActivity;
using Bidirectional.DomainCore.BidOnboard.Entities.Users;
using Bidirectional.DomainCore.BidOnboard.Entities.Valocity;
using Bidirectional.DomainCore.BidOnboard.Entities;
using Bidirectional.DomainCore.BidOnboard.Permission;
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
}
