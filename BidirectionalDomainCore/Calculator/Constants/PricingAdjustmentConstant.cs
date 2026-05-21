namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Constants for pricing adjustment types: discount and data entry additional margin.
/// </summary>
public record PricingAdjustmentConstant
{
    /// <summary>Discount adjustment type.</summary>
    public const string Discount = "Discount";

    /// <summary>Data entry additional margin adjustment type.</summary>
    public const string DataEntryAdditionalMargin = "Data entry additional margin";
}
