using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;
using Bidirectional.DomainCore.Common.Utilities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Interceptors;

/// <summary>
/// Intercepts save changes operations to automatically update audit fields for entities.
/// </summary>
public class AuditableEntityInterceptor : SaveChangesInterceptor
{
    #region Fields

    private readonly ICurrentUserService _currentUserService;

    #endregion

    #region Ctor
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditableEntityInterceptor"/> class.
    /// </summary>
    /// <param name="currentUserService">Service providing the current user information.</param>
    /// <param name="dateTimeService">Service providing the current date and time.</param>
    public AuditableEntityInterceptor(
        ICurrentUserService currentUserService)
    {
        _currentUserService = currentUserService;;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Called when SaveChanges is invoked to update audit fields on applicable entities.
    /// </summary>
    /// <param name="eventData">The event data associated with the operation.</param>
    /// <param name="result">The result of the interception.</param>
    /// <returns>An <see cref="InterceptionResult{TResult}"/> representing the result of the operation.</returns>
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateEntities(eventData.Context);

        return base.SavingChanges(eventData, result);
    }

    /// <summary>
    /// Asynchronously called when SaveChangesAsync is invoked to update audit fields on applicable entities.
    /// </summary>
    /// <param name="eventData">The event data associated with the operation.</param>
    /// <param name="result">The result of the interception.</param>
    /// <param name="cancellationToken">A cancellation token for the async operation.</param>
    /// <returns>
    /// A <see cref="ValueTask{InterceptionResult}"/> representing the result of the async operation.
    /// </returns>
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        UpdateEntities(eventData.Context);

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    /// <summary>
    /// Updates audit fields for all relevant entities in the change tracker.
    /// </summary>
    /// <param name="context">The current database context.</param>
    public void UpdateEntities(DbContext? context)
    {
        if (context is null) return;

        foreach (EntityEntry<BaseAuditableEntity> entry in context.ChangeTracker.Entries<BaseAuditableEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedBy = _currentUserService.UserID;
                entry.Entity.CreatedUtc = DateTime.UtcNow;
                entry.Entity.CreatedAus = CommonHelper.GetAustralianTime();
            }

            if (entry.State == EntityState.Added || entry.State == EntityState.Modified || entry.HasChangedOwnedEntities())
            {
                entry.Entity.LastModifiedBy = _currentUserService.UserID;
                entry.Entity.LastModifiedUtc = DateTime.UtcNow;
                entry.Entity.LastModifiedAus = CommonHelper.GetAustralianTime();
            }
        }
    }

    #endregion
}

/// <summary>
/// Provides extension methods for <see cref="EntityEntry"/>.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Determines whether any owned entities referenced by the entry have been added or modified.
    /// </summary>
    /// <param name="entry">The entity entry to inspect.</param>
    /// <returns>
    /// <c>true</c> if any owned referenced entities have been added or modified; otherwise, <c>false</c>.
    /// </returns>
    public static bool HasChangedOwnedEntities(this EntityEntry entry) =>
        entry.References.Any(r =>
            r.TargetEntry is not null &&
            r.TargetEntry.Metadata.IsOwned() &&
            (r.TargetEntry.State == EntityState.Added || r.TargetEntry.State == EntityState.Modified));
}
