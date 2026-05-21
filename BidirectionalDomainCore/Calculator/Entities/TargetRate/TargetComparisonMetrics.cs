namespace Bidirectional.DomainCore.Calculator.Entities.TargetRate;

/// <summary>
/// Represents target comparison metrics (difference) for a target base rate and LVR/type criteria.
/// </summary>
public class TargetComparisonMetrics : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional loan type look-up ID from the core database.</summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional target base rate ID.</summary>
    public int? TargetComparisonMetrics_TargetBaseRateID { get; set; }

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

    /// <summary>Gets or sets the difference.</summary>
    public double Difference { get; set; }

    /// <summary>Gets or sets the optional source of target.</summary>
    public string? SourceOfTarget { get; set; }

    /// <summary>Gets or sets the optional target base rate.</summary>
    public TargetBaseRate? TargetComparisonMetrics_TargetBaseRate { get; set; }
}
