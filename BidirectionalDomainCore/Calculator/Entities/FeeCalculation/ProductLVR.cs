namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a loan-to-value ratio (LVR) range configuration for a product.
/// </summary>
public class ProductLVR : BaseAuditableEntity
{
    /// <summary>Gets or sets the range identifier.</summary>
    public int RangeIdentifier { get; set; }

    /// <summary>Gets or sets the range start value.</summary>
    public required double RangeFrom { get; set; }

    /// <summary>Gets or sets the range end value.</summary>
    public required double RangeTo { get; set; }

    /// <summary>Gets or sets a value indicating whether this range is the baseline.</summary>
    public bool IsBaseline { get; set; }
}
