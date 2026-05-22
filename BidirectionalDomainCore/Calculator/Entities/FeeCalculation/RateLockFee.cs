namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents the configuration of a rate-lock fee, including interest type, product, and underlying formula.
/// </summary>
public class RateLockFee : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional interest type.</summary>
    public int? InterestType_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional year fixed.</summary>
    public int? YearFixed { get; set; }

    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional base value ID.</summary>
    public int? RateLockFee_BaseValueID { get; set; }

    /// <summary>Gets or sets the optional base formula ID.</summary>
    public int? BaseFormulaID { get; set; }

    /// <summary>Gets or sets the optional base value.</summary>
    public BaseValue? RateLockFee_BaseValue { get; set; }

    /// <summary>Gets or sets the optional base formula.</summary>
    public Formula? BaseFormula { get; set; }
}
