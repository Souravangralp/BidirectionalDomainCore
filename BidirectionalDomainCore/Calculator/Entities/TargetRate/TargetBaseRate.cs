namespace Bidirectional.DomainCore.Calculator.Entities.TargetRate;

/// <summary>
/// Represents a target base rate with LVR range, interest type, and basic/offset rates.
/// </summary>
public class TargetBaseRate : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional loan type look-up ID from the core database.</summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the minimum LVR.</summary>
    public double MinimumLVR { get; set; }

    /// <summary>Gets or sets the maximum LVR.</summary>
    public double MaximumLVR { get; set; }

    /// <summary>Gets or sets the optional property type look-up ID from the core database.</summary>
    public int? PropertyType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional repayment type look-up ID from the core database.</summary>
    public int? RepaymentType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional interest type look-up ID from the core database (fixed or variable).</summary>
    [Comment("This will hold only fixed and variable")]
    public int? InterestType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional year fixed.</summary>
    public int? YearFixed { get; set; }

    /// <summary>Gets or sets the basic interest rate.</summary>
    public double BasicInterestRate { get; set; }

    /// <summary>Gets or sets the basic comparison rate.</summary>
    public double BasicComparisonRate { get; set; }

    /// <summary>Gets or sets the offset interest rate.</summary>
    public double OffSetInterestRate { get; set; }

    /// <summary>Gets or sets the offset comparison rate.</summary>
    public double OffSetComparisonRate { get; set; }

    /// <summary>Gets or sets the last update date.</summary>
    public DateTime LastUpdateDate { get; set; }

    /// <summary>Gets or sets the optional source of target.</summary>
    public string? SourceOfTarget { get; set; }
}
