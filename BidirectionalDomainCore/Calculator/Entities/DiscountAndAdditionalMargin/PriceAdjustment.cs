namespace Bidirectional.DomainCore.Calculator.Entities.DiscountAndAdditionalMargin;

/// <summary>
/// Represents a price adjustment (e.g. discount or additional margin) with optional type and value.
/// </summary>
public class PriceAdjustment : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional adjustment type.</summary>
    public string? Type { get; set; }

    /// <summary>Gets or sets the adjustment value.</summary>
    public double Value { get; set; }
}
