namespace Bidirectional.DomainCore.BidOnboard.Entities.Generals;

/// <summary>
/// Represents a general-purpose lookup entity for storing key-value pairs and related metadata, such as type, archived and default status, display order, and a description.
/// </summary>
public class GeneralLookup : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the type category of the lookup entry.
    /// </summary>
    public required string Type { get; set; }

    /// <summary>
    /// Gets or sets the value associated with the lookup type.
    /// </summary>
    public required string Value { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this lookup entry is archived.
    /// </summary>
    public bool ISArchived { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this lookup entry is the default option for its type.
    /// </summary>
    public bool ISDefault { get; set; }

    /// <summary>
    /// Gets or sets the order in which this entry should be displayed relative to others of the same type.
    /// </summary>
    public int DisplayOrder { get; set; }
}
