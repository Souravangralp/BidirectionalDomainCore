namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the detailed preferences and configurations for loan repayment options within a loan application.
/// </summary>
public class PreferenceRepaymentDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the reference ID for the related preference.
    /// </summary>
    public int? PreferenceRepaymentDetail_LoanApplicationPreferenceID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for repayment frequency type, used for Principal and Interest repayments.
    /// </summary>
    public int? RepaymentFrequencyType_GeneralLookUpID { get; set; } // For PrincipalAndInterest

    /// <summary>
    /// Gets or sets the general lookup ID for the repayment type, indicating the nature of repayment (e.g., Principal and Interest, Interest Only, Line of Credit, Interest In Advance).
    /// </summary>
    public int? RepaymentType_GeneralLookUpID { get; set; } // For getting which type of repayment it is (PrincipalAndInterest, InterestOnly, LineOfCredit,InterestInAdvance)

    /// <summary>
    /// Gets or sets the importance rating or description for the repayment preference.
    /// </summary>
    public string? Importance { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the risk has been explained.
    /// </summary>
    public bool ISRiskExplained { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is income from a co-applicant. Applicable for Line of Credit.
    /// </summary>
    public bool HASCoApplicantIncome { get; set; } // For LineOfCredit

    /// <summary>
    /// Gets or sets a value indicating whether downsizing is involved. Applicable for Line of Credit.
    /// </summary>
    public bool ISDownsizing { get; set; } // For LineOfCredit

    /// <summary>
    /// Gets or sets a value indicating whether income is from other investments. Applicable for Line of Credit.
    /// </summary>
    public bool ISIncomeFromOtherInvestments { get; set; } // For LineOfCredit

    /// <summary>
    /// Gets or sets a value indicating whether other sources are applicable. Applicable for Line of Credit.
    /// </summary>
    public bool HASOther { get; set; } // For LineOfCredit

    /// <summary>
    /// Gets or sets a value indicating whether repayment of the loan prior to end of term is applicable. Applicable for Line of Credit.
    /// </summary>
    public bool ISRepaymentOfLoanPriorToEndOfTerm { get; set; } // For LineOfCredit

    /// <summary>
    /// Gets or sets a value indicating whether sale of assets is considered as part of the repayment method. Applicable for Line of Credit.
    /// </summary>
    public bool HASSaleOfAssets { get; set; } // For LineOfCredit

    /// <summary>
    /// Gets or sets a value indicating whether savings are being considered as part of the repayment method. Applicable for Line of Credit.
    /// </summary>
    public bool HASSavings { get; set; } // For LineOfCredit

    /// <summary>
    /// Gets or sets the duration length of the repayment, relevant for Interest Only repayment.
    /// </summary>
    public string? DurationLength { get; set; } // For Interest only

    /// <summary>
    /// Gets or sets the unit of the duration (e.g., years, months), relevant for Interest Only repayment.
    /// </summary>
    public string? DurationUnit { get; set; } // For Interest only

    /// <summary>
    /// Gets or sets the reason for the repayment preference.
    /// </summary>
    public ApprovalReason? ApprovalReason { get; set; }

    /// <summary>
    /// Gets or sets the associated preference entity for this repayment detail.
    /// </summary>
    public LoanApplicationPreference? PreferenceRepaymentDetail_LoanApplicationPreference { get; set; }
}
