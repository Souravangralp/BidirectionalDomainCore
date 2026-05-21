namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the checklist of requirements, documents, and confirmations related to a loan application's processing lifecycle.
/// </summary>
public class Checklist : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated loan application for this checklist.
    /// </summary>
    public int? CheckList_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the minimum insurance value applicable to the loan application.
    /// </summary>
    public double? MinimumInsuranceValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether all instructions are satisfied and LMI is not expired.
    /// </summary>
    public bool HASInstructionsSatisfiedAndLMINotExpired { get; set; }

    /// <summary>
    /// Gets or sets the name of the person who signed the settlement.
    /// </summary>
    public string? SettlementSignedBy { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the certificate document has been imaged.
    /// </summary>
    public bool ISCertificateImaged { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the signed loan contract document has been imaged.
    /// </summary>
    public bool ISSignedLoanContractImaged { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the certificate of currency document has been imaged.
    /// </summary>
    public bool ISCertificateOfCurrencyImaged { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the application fee has been collected or is due upon settlement.
    /// </summary>
    public bool ISApplicationFeeCollectedOROnSettlement { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the settlement checklist document has been imaged.
    /// </summary>
    public bool ISSettlementCheckListImaged { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a funds request has been sent for the loan application.
    /// </summary>
    public bool ISFundsRequestSent { get; set; }

    /// <summary>
    /// Gets or sets the name of the person who signed off on the funding.
    /// </summary>
    public string? FundingSignedBy { get; set; }

    /// <summary>
    /// Gets or sets the name of the person who reviewed and audited the funding process.
    /// </summary>
    public string? FundingReviewedAndAuditedBy { get; set; }

    /// <summary>
    /// Gets or sets a description indicating if all pre-conditions are satisfied for the loan application.
    /// </summary>
    public string? AREAllPreConditionsSatisfied { get; set; }

    /// <summary>
    /// Gets or sets the related loan application entity for this checklist entry.
    /// </summary>
    public LoanApplication? CheckList_LoanApplication { get; set; }
}
