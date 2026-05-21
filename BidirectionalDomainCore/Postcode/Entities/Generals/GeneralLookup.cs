namespace Bidirectional.DomainCore.Postcode.Entities.Generals;

/// <summary>
/// Represents a general lookup entity with a type, value, and default indicator.
/// </summary>
public class GeneralLookup : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the type of the general lookup.
    /// </summary>
    public required string Type { get; set; }

    /// <summary>
    /// Gets or sets the value associated with the general lookup.
    /// </summary>
    public required string Value { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this lookup is the default.
    /// </summary>
    public bool ISDefault { get; set; }
}
