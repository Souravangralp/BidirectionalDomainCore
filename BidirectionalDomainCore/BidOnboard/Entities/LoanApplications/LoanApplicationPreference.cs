namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a borrower's preferences and related details for a loan application,
/// including lender conflicts, preferred lender information, and associated financial details.
/// </summary>
public class LoanApplicationPreference : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the related need analysis.
    /// </summary>
    public int? LoanApplicationPreference_NeedsAnalysesID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a conflict exists regarding lender preference.
    /// </summary>
    public bool ISConflictExists { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the lender is preferred by the borrower.
    /// </summary>
    public bool ISPreferredLender { get; set; }

    /// <summary>
    /// Gets or sets the description of any conflicts related to lender preference.
    /// </summary>
    public string? ConflictDescription { get; set; }

    /// <summary>
    /// Gets or sets additional preferences specified by the borrower.
    /// </summary>
    public string? OtherPreferences { get; set; }

    /// <summary>
    /// Gets or sets the details about the preferred lender.
    /// </summary>
    public string? PreferredLenderDetail { get; set; }

    /// <summary>
    /// Gets or sets the priority and reasoning given for the borrower's preferences.
    /// </summary>
    public string? PriorityAndReason { get; set; }

    /// <summary>
    /// Gets or sets a summary of the borrower's preferences and rationale.
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Gets or sets the collection of repayment preference details.
    /// </summary>
    public IList<PreferenceRepaymentDetail> PreferenceRepaymentDetails { get; set; } = new List<PreferenceRepaymentDetail>();

    /// <summary>
    /// Gets or sets the collection of interest rate details related to the borrower's preferences.
    /// </summary>
    public IList<InterestRateDetail> InterestRateDetails { get; set; } = new List<InterestRateDetail>();

    /// <summary>
    /// Gets or sets the collection of fund details relevant to the borrower's preferences.
    /// </summary>
    public IList<FundsDetail> FundsDetails { get; set; } = new List<FundsDetail>();

    /// <summary>
    /// Gets or sets the related need analysis entity representing the borrower's financial needs.
    /// </summary>
    public NeedsAnalyses? LoanApplicationPreference_NeedsAnalyses { get; set; }
}
