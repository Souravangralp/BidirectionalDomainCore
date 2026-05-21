namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details of an interest rate associated with a loan application, including type, preference, explanation, and related parameters.
/// </summary>
public class InterestRateDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the preference related to this interest rate detail.
    /// </summary>
    public int? InterestRateDetail_LoanApplicationPreferenceID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the interest rate type from the GeneralLookUp table.
    /// </summary>
    public int? InterestRateType_GeneralLookUpID { get; set; } // we will get this from GeneralLookUp

    /// <summary>
    /// Gets or sets a value indicating whether the interest rate risk has been explained.
    /// </summary>
    public bool ISRiskExplained { get; set; }

    /// <summary>
    /// Gets or sets the importance level of the interest rate.
    /// </summary>
    public string? InterestRateImportanceLevel { get; set; }

    /// <summary>
    /// Gets or sets the duration of the fixed period for the interest rate.
    /// </summary>
    public string? FixedPeriodLengthDuration { get; set; }

    /// <summary>
    /// Gets or sets the unit type for the fixed period (e.g., months, years).
    /// </summary>
    public string? FixedPeriodUnitType { get; set; }

    /// <summary>
    /// Gets or sets the reason associated with this interest rate detail.
    /// </summary>
    public ApprovalReason? ApprovalReason { get; set; }

    /// <summary>
    /// Gets or sets the preference object associated with this interest rate detail.
    /// </summary>
    public LoanApplicationPreference? InterestRateDetail_LoanApplicationPreference { get; set; }
}
