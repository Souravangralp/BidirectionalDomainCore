namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a custom slab range used to calculate fees based on identifiers and base values.
/// </summary>
public class CustomSlab : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional fee detail ID.</summary>
    public int? CustomSlab_FeeDetailID { get; set; }

    /// <summary>Gets or sets the optional product category addition fee ID.</summary>
    public int? CustomSlab_ProductCategoryAdditionFeeID { get; set; }

    /// <summary>Gets or sets the range identifier (from).</summary>
    public int RangeIdentifierFrom { get; set; }

    /// <summary>Gets or sets the range identifier (to).</summary>
    public int RangeIdentifierTo { get; set; }

    /// <summary>Gets or sets the optional formula ID.</summary>
    public int? CustomSlab_FormulaID { get; set; }

    /// <summary>Gets or sets the optional base value ID.</summary>
    public int? CustomSlab_BaseValueID { get; set; }

    /// <summary>Gets or sets the optional base value.</summary>
    public BaseValue? CustomSlab_BaseValue { get; set; }

    /// <summary>Gets or sets the optional fee detail.</summary>
    public FeeDetail? CustomSlab_FeeDetail { get; set; }

    /// <summary>Gets or sets the optional formula.</summary>
    public Formula? CustomSlab_Formula { get; set; }

    /// <summary>Gets or sets the optional product category addition fee.</summary>
    public ProductCategoryAdditionFee? CustomSlab_ProductCategoryAdditionFee { get; set; }
}
