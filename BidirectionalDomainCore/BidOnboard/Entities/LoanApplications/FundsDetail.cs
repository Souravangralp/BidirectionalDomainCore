namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details of funds for a loan application, including preference, type, risk explanation, importance level, reason, and related preference entity.
/// </summary>
public class FundsDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related preference of the funds detail.
    /// </summary>
    public int? FundsDetail_LoanApplicationPreferenceID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the fund type from the GeneralLookUp in the CoreDB.
    /// </summary>
    public int? FundType_GeneralLookUpID { get; set; } // we will get this from GeneralLookUp

    /// <summary>
    /// Gets or sets a value indicating whether the risk has been explained.
    /// </summary>
    public bool ISRiskExplained { get; set; }

    /// <summary>
    /// Gets or sets the importance level of the fund.
    /// </summary>
    public string? FundImportanceLevel { get; set; }

    /// <summary>
    /// Gets or sets the reason associated with the funds detail.
    /// </summary>
    public ApprovalReason? ApprovalReason { get; set; }

    /// <summary>
    /// Gets or sets the related preference entity for the funds detail.
    /// </summary>
    public LoanApplicationPreference? FundsDetail_LoanApplicationPreference { get; set; }
}
