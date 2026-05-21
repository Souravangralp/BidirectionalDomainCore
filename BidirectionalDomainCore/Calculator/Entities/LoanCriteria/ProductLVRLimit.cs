namespace Bidirectional.DomainCore.Calculator.Entities.LoanCriteria;

/// <summary>
/// Represents the LVR (Loan to Value Ratio) limit for a product, including related criteria and lookup references.
/// </summary>
public class ProductLVRLimit : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional ID of the related rate calculation criteria.</summary>
    public int? ProductLVRLimit_RateCalculationCriteriaID { get; set; }

    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the maximum LVR limit for the product.</summary>
    public double MaximumLVRLimit { get; set; }

    /// <summary>Gets or sets the optional related rate calculation criteria entity.</summary>
    public RateCalculationCriteria? ProductLVRLimit_RateCalculationCriteria { get; set; }
}
