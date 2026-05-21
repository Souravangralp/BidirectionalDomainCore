namespace Bidirectional.DomainCore.ProductMatrix.Entities;

/// <summary>
/// Represents a classification for a filter, including its name, parent relationship, and immutable identifier.
/// </summary>
public class FilterClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the filter classification.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the optional ID of the parent filter classification, if applicable.
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Gets or sets the immutable identifier for the filter classification.
    /// </summary>
    public required string ImmutableFilterIdentifier { get; set; }
}
