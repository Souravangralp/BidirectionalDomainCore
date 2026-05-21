namespace Bidirectional.DomainCore.ProductMatrix.Entities;

/// <summary>
/// Represents a general lookup entity with a type, value, and optional description.
/// </summary>
public class GeneralLookUp : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the type of the lookup entry.
    /// </summary>
    public required string Type { get; set; }

    /// <summary>
    /// Gets or sets the value associated with the lookup type.
    /// </summary>
    public required string Value { get; set; }
}
