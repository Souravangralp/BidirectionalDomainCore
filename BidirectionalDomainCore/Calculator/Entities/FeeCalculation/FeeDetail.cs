namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents detailed configuration for how a particular fee is calculated within a matrix.
/// </summary>
public class FeeDetail : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional matrix detail ID.</summary>
    public int? FeeDetail_MatrixDetailID { get; set; }

    /// <summary>Gets or sets the optional fee ID.</summary>
    public int? FeeDetail_FeeID { get; set; }

    /// <summary>Gets or sets the optional doc type look-up ID from the core database.</summary>
    public int? DocType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional base value ID.</summary>
    public int? FeeDetail_BaseValueID { get; set; }

    /// <summary>Gets or sets the optional parent ID.</summary>
    public int? ParentID { get; set; }

    /// <summary>Gets or sets the optional increment formula ID.</summary>
    public int? FeeDetail_IncrementFormulaID { get; set; }

    /// <summary>Gets or sets the optional decrement formula ID.</summary>
    public int? FeeDetail_DecrementFormulaID { get; set; }

    /// <summary>Gets or sets the optional base formula ID.</summary>
    public int? FeeDetail_BaseFormulaID { get; set; }

    /// <summary>Gets or sets the optional base line identifier.</summary>
    public int? BaseLineIdentifier { get; set; }

    /// <summary>Gets or sets the optional extra fee.</summary>
    public double? ExtraFee { get; set; }

    /// <summary>Gets or sets the optional fee.</summary>
    public Fee? FeeDetail_Fee { get; set; }

    /// <summary>Gets or sets the optional base value.</summary>
    public BaseValue? FeeDetail_BaseValue { get; set; }

    /// <summary>Gets or sets the custom slabs collection.</summary>
    public ICollection<CustomSlab> CustomSlabs { get; set; } = [];

    /// <summary>Gets or sets the fee details custom calculations collection.</summary>
    public ICollection<FeeDetailsCustomCalculation> FeeDetailsCustomCalculations { get; set; } = [];

    /// <summary>Gets or sets the product category addition fees collection.</summary>
    public ICollection<ProductCategoryAdditionFee> ProductCategoryAdditionFees { get; set; } = [];

    /// <summary>Gets or sets the optional additional calculation.</summary>
    public AdditionalCalculation? AdditionalCalculation { get; set; }

    /// <summary>Gets or sets the increment or decrement value.</summary>
    public double IncrementDecrementValue { get; set; }

    /// <summary>Gets or sets the optional matrix detail.</summary>
    public MatrixDetail? FeeDetail_MatrixDetail { get; set; }
}
