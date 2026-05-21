namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents legal fee settings for a specific product and numeral type.
/// </summary>
public class LegalFee : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional loan type look-up ID from the core database.</summary>
    public int? LoanType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional fee amount.</summary>
    public double? Fee { get; set; }
}
