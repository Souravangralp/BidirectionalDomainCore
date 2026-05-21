namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a custom calculation configuration for a specific fee detail, product category, and LVR.
/// </summary>
public class FeeDetailsCustomCalculation : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional fee detail ID.</summary>
    public int? FeeDetailsCustomCalculation_FeeDetailID { get; set; }

    /// <summary>Gets or sets the optional product category addition fee ID.</summary>
    public int? FeeDetailsCustomCalculation_ProductCategoryAdditionFeeID { get; set; }

    /// <summary>Gets or sets the optional product LVR ID.</summary>
    public int? FeeDetailsCustomCalculation_ProductLVRID { get; set; }

    /// <summary>Gets or sets the optional formula ID.</summary>
    public int? FeeDetailsCustomCalculation_FormulaID { get; set; }

    /// <summary>Gets or sets the optional fee detail.</summary>
    public FeeDetail? FeeDetailsCustomCalculation_FeeDetail { get; set; }

    /// <summary>Gets or sets the optional product category addition fee.</summary>
    public ProductCategoryAdditionFee? FeeDetailsCustomCalculation_ProductCategoryAdditionFee { get; set; }

    /// <summary>Gets or sets the optional product LVR.</summary>
    public ProductLVR? FeeDetailsCustomCalculation_ProductLVR { get; set; }
}
