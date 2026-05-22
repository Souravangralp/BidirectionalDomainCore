using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Bidirectional.DomainCore.Persistence.Interceptors;

/// <summary>
/// Converts hard-delete operations (<see cref="EntityState.Deleted"/>) on <see cref="ISoftDelete"/> entities into soft deletes
/// and triggers SQL Server cascade updates for untracked dependents.
/// </summary>
public class SoftDeleteSaveChangesInterceptor : SaveChangesInterceptor
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SoftDeleteSaveChangesInterceptor"/> class.
    /// </summary>
    /// <param name="currentUserService">Current user (used for dependent audit columns during SQL cascade).</param>
    /// <param name="dateTimeService">Clock used for dependent audit columns during SQL cascade.</param>
    public SoftDeleteSaveChangesInterceptor()
    {
    }

    /// <inheritdoc />
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        if (eventData.Context is DbContext ctx)
        {
            List<EntityEntry> converted = ConvertHardDeletesToSoftDeletes(ctx);
            //if (converted.Count > 0)
            //{
            //    SoftDeleteSqlServerCascade.Apply(ctx, converted, _currentUserService.UserId, _dateTimeService.Now);
            //}
        }

        return base.SavingChanges(eventData, result);
    }

    /// <inheritdoc />
    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        if (eventData.Context is DbContext ctx)
        {
            List<EntityEntry> converted = ConvertHardDeletesToSoftDeletes(ctx);
            //if (converted.Count > 0)
            //{
            //    await SoftDeleteSqlServerCascade.ApplyAsync(ctx, converted, _currentUserService.UserId, _dateTimeService.Now, cancellationToken);
            //}
        }

        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private static List<EntityEntry> ConvertHardDeletesToSoftDeletes(DbContext context)
    {
        List<EntityEntry> converted = new();
        foreach (EntityEntry entry in context.ChangeTracker.Entries())
        {
            if (entry.Entity is not ISoftDelete entity)
                continue;

            if (entry.State != EntityState.Deleted)
                continue;

            entry.State = EntityState.Modified;
            entity.ISDeleted = true;
            converted.Add(entry);
        }

        return converted;
    }
}
