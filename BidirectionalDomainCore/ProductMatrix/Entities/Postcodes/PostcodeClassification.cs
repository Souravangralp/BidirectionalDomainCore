namespace Bidirectional.DomainCore.ProductMatrix.Entities.Postcodes;

/// <summary>
/// Represents a classification category for a postcode within the system.
/// </summary>
public class PostcodeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the descriptive name of the postcode classification.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the integer value associated with the postcode classification.
    /// </summary>
    public required int Value { get; set; }
}
