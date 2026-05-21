namespace Bidirectional.DomainCore.Common;

/// <summary>
/// Represents the base class for all entities, providing common properties and domain event handling functionality.
/// </summary>
public abstract class BaseEntity
{
    #region Fields

    /// <summary>
    /// Gets or sets the primary identifier for the entity.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Gets or sets the globally unique identifier for the entity.
    /// </summary>
    public string UniqueID { get; set; } = Guid.NewGuid().ToString();

    private readonly List<BaseEvent> _domainEvents = new();

    /// <summary>
    /// Gets the collection of domain events associated with the entity.
    /// </summary>
    [NotMapped]
    public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();

    #endregion

    #region Methods

    /// <summary>
    /// Adds a domain event to the entity's event collection.
    /// </summary>
    /// <param name="domainEvent">The domain event to add.</param>
    public void AddDomainEvent(BaseEvent domainEvent) { _domainEvents.Add(domainEvent); }

    /// <summary>
    /// Removes a domain event from the entity's event collection.
    /// </summary>
    /// <param name="domainEvent">The domain event to remove.</param>
    public void RemoveDomainEvent(BaseEvent domainEvent) { _domainEvents.Remove(domainEvent); }

    /// <summary>
    /// Clears all domain events from the entity's event collection.
    /// </summary>
    public void ClearDomainEvents() { _domainEvents.Clear(); }

    #endregion
}
