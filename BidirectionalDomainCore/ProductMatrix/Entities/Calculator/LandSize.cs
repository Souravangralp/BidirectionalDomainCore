namespace Bidirectional.DomainCore.ProductMatrix.Entities.Calculator;

/// <summary>
/// Represents a range of land size measurements with specified minimum and maximum values.
/// </summary>
public class LandSize : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lower bound of the land size range.
    /// </summary>
    public required double From { get; set; }

    /// <summary>
    /// Gets or sets the upper bound of the land size range.
    /// </summary>
    public required double To { get; set; }
}
