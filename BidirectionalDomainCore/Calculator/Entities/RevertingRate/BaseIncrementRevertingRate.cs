namespace Bidirectional.DomainCore.Calculator.Entities.RevertingRate;

/// <summary>
/// Represents the base increment reverting rate by interest type (fixed or variable) and year fixed.
/// </summary>
public class BaseIncrementRevertingRate : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional interest type look-up ID from the core database (fixed or variable).</summary>
    [Comment("This will hold only fixed and variable")]
    public int? InterestType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the year fixed.</summary>
    public int YearFixed { get; set; }

    /// <summary>Gets or sets the incremented value.</summary>
    public double IncrementedValue { get; set; }
}
