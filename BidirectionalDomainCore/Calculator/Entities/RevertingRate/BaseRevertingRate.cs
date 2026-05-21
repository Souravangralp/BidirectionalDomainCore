namespace Bidirectional.DomainCore.Calculator.Entities.RevertingRate;

/// <summary>
/// Represents the base reverting rate by product type and numeral type.
/// </summary>
public class BaseRevertingRate : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the base value.</summary>
    public double BaseValue { get; set; }
}
