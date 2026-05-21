namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents an additional fee configuration applied to a specific product category.
/// </summary>
public class ProductCategoryAdditionFee : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional fee detail ID.</summary>
    public int? ProductCategoryAdditionFee_FeeDetailID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional formula ID.</summary>
    public int? ProductCategoryAdditionFee_FormulaID { get; set; }

    /// <summary>Gets or sets the additional fees custom calculations collection.</summary>
    public ICollection<FeeDetailsCustomCalculation> AdditionalFeesCustomCalculations { get; set; } = [];

    /// <summary>Gets or sets the optional formula.</summary>
    public Formula? ProductCategoryAdditionFee_Formula { get; set; }

    /// <summary>Gets or sets the optional fee detail.</summary>
    public FeeDetail? ProductCategoryAdditionFee_FeeDetail { get; set; }

    /// <summary>Gets or sets the custom slabs collection.</summary>
    public ICollection<CustomSlab> CustomSlabs { get; set; } = [];

    /// <summary>Gets or sets the increment or decrement value.</summary>
    public double IncrementDecrementValue { get; set; }
}
