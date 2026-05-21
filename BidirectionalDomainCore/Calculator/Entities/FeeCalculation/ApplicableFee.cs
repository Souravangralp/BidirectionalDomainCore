namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents whether a particular fee is applicable for a given document, product type, and numeral type.
/// </summary>
public class ApplicableFee : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional loan type look-up ID from the core database.</summary>
    public int? LoanType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional fee ID.</summary>
    public int? ApplicableFee_FeeID { get; set; }

    /// <summary>Gets or sets the optional doc type look-up ID from the core database.</summary>
    public int? DocType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets a value indicating whether the fee is applicable.</summary>
    public bool ISApplicable { get; set; }

    /// <summary>Gets or sets the optional fee.</summary>
    public Fee? ApplicableFee_Fee { get; set; }
}
