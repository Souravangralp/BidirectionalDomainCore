namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Interface that marks an entity as supporting soft deletion functionality.
/// </summary>
public interface ISoftDelete
{
    /// <summary>
    /// Gets or sets a value indicating whether the entity is considered deleted (soft deleted).
    /// </summary>
    bool ISDeleted { get; set; }
}
