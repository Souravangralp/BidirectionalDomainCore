namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the credit history details for both financial and non-financial aspects related to a loan applicant,
/// including historical repayments, arrears, bankruptcies, scheme arrangements, judgements, liabilities, and related financial health information.
/// </summary>
public class CreditHistoryForFinancialAndNonFinancial : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated applicant.
    /// </summary>
    public int? CreditHistoryForFinancialAndNonFinancial_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the enforcement fee amount associated with the applicant.
    /// </summary>
    [Comment("New field added in MSt 3.221")]
    public double? EnforcementFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the arrear fee amount related to the applicant.
    /// </summary>
    [Comment("New field added in MSt 3.221")]
    public double? ArrearFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a default amount exists.
    /// </summary>
    public bool HASDefaultAmount { get; set; }

    /// <summary>
    /// Gets or sets the count of defaulted amounts.
    /// </summary>
    public int? DefaultAmountCount { get; set; }

    /// <summary>
    /// Gets or sets the remaining unpaid amount for the applicant.
    /// </summary>
    public double? RemainingUnpaidAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there are current council arrears.
    /// </summary>
    public bool HASCouncilArrears { get; set; }

    /// <summary>
    /// Gets or sets the remaining unpaid council amount.
    /// </summary>
    public double? RemainingUnpaidCouncilAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the default amounts are cleared.
    /// </summary>
    public bool ISDefaultAmountCleared { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there are monthly repayment arrears.
    /// </summary>
    public bool HASMonthlyRepaymentArrears { get; set; }

    /// <summary>
    /// Gets or sets the monthly mortgage repayment amount.
    /// </summary>
    public int? MonthlyMortgageRepayment { get; set; }

    /// <summary>
    /// Gets or sets the monthly repayment amount for personal or car loans.
    /// </summary>
    public int? MonthlyPersonalOrCarLoanRepayment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the party has a history of financial hardship.
    /// </summary>
    public bool HasHistoryOfFinancialHardship { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is still experiencing financial hardship.
    /// </summary>
    public bool IsStillInFinancialHardship { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a current scheme arrangement.
    /// </summary>
    public bool HASCurrentSchemeArrangement { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a statement claim has been issued.
    /// </summary>
    public bool ISStatementClaimIssued { get; set; }

    /// <summary>
    /// Gets or sets the description related to the issued statement claim.
    /// </summary>
    public string? StatementClaimIssuedDescription { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a judgement has been issued.
    /// </summary>
    public bool ISJudgementIssued { get; set; }

    /// <summary>
    /// Gets or sets the description of the issued judgement.
    /// </summary>
    public string? JudgementIssuedDescription { get; set; }

    /// <summary>
    /// Gets or sets the number of months paid into the current scheme arrangement.
    /// </summary>
    public int? CurrentSchemeArrangementPaidInMonths { get; set; }

    /// <summary>
    /// Gets or sets the number of months in arrears for the current scheme arrangement.
    /// </summary>
    public int? CurrentSchemeArrangementPaidInMonthsInArrears { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a current Part IX arrangement.
    /// </summary>
    public bool HASCurrentPartIXArrangement { get; set; }

    /// <summary>
    /// Gets or sets the number of months paid into the current Part IX arrangement.
    /// </summary>
    public int? CurrentPartIXArrangementPaidInMonths { get; set; }

    /// <summary>
    /// Gets or sets the number of months in arrears for the current Part IX arrangement.
    /// </summary>
    public int? CurrentPartIXArrangementPaidInMonthsInArrears { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a court judgement.
    /// </summary>
    public bool HASCourtJudgement { get; set; }

    /// <summary>
    /// Gets or sets the count of court judgement amounts.
    /// </summary>
    public int? CourtJudgementAmountCount { get; set; }

    /// <summary>
    /// Gets or sets the unpaid amount of court judgements.
    /// </summary>
    public double? CourtJudgementUnpaidAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the court judgement is cleared.
    /// </summary>
    public bool ISCourtJudgementCleared { get; set; }

    /// <summary>
    /// Gets or sets the collection of actions related to entities associated with the credit history.
    /// </summary>
    public IList<RelatedEntityAction> RelatedEntityActions { get; set; } = new List<RelatedEntityAction>();

    /// <summary>
    /// Gets or sets the collection of court judgement details for the applicant.
    /// </summary>
    public IList<CourtJudgementDetail> CourtJudgementDetails { get; set; } = new List<CourtJudgementDetail>();

    public bool HASMissedRepayment { get; set; }

    public IList<RepaymentHistory> RepaymentHistories { get; set; } = new List<RepaymentHistory>();

    /// <summary>
    /// Gets or sets the linked applicant entity for this credit history record.
    /// </summary>
    public Applicant? CreditHistoryForFinancialAndNonFinancial_Applicant { get; set; }

    #region Remove Fields

    /// <summary>
    /// Gets or sets the amount in monthly repayment arrears.
    /// </summary>
    public int? MonthlyRepaymentArrearsAmount { get; set; }

    /// <summary>
    /// Gets or sets the type of credit history using the general lookup table.
    /// </summary>
    [Comment("We Will be getting type from generalLookUp Table  CreditHistory_GeneralLookUpTypeID")]
    public int? CreditHistoryType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the type of monthly repayment using the general lookup table.
    /// </summary>
    [Comment("We will be getting type from generalLookUp Table")]
    public int? MonthlyRepaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether defaults remain unpaid totaling a value.
    /// </summary>
    [Comment("default(s) continue to remain unpaid totaling")]
    public bool ISRemainUnpaidTotaling { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the current scheme arrangement is paid on time.
    /// </summary>
    public bool ISCurrentSchemeArrangementPaidOnTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the current Part IX arrangement is paid on time.
    /// </summary>
    public bool ISCurrentPartIXArrangementPaidOnTime { get; set; }

    /// <summary>
    /// Gets or sets the total number of accounts.
    /// </summary>
    [Comment("Accounts & repayment")]
    public double? AccountCount { get; set; }

    /// <summary>
    /// Gets or sets the total credit limit as a string.
    /// </summary>
    public string? TotalCreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the financial health index of the applicant as a string.
    /// </summary>
    public string? FinancialHealthIndex { get; set; }

    /// <summary>
    /// Gets or sets the worst repayment history indicator (RHI) status in the last 24 months as a string.
    /// </summary>
    public string? WorstRHIStatusLast24month { get; set; }

    /// <summary>
    /// Gets or sets the repayment history in JSON format.
    /// </summary>
    [Comment("We will store RepaymentHistory fields in Json")]
    public string? RepaymentHistory { get; set; }

    /// <summary>
    /// Gets or sets the information about the identification source.
    /// </summary>
    [Comment("Other details")]
    public string? IDSource { get; set; }

    /// <summary>
    /// Gets or sets the account type, this property is encrypted.
    /// </summary>
    [EncryptColumn]
    public string? AccountType { get; set; }

    /// <summary>
    /// Gets or sets the account relationship type.
    /// </summary>
    public string? AccountRelationshipType { get; set; }

    /// <summary>
    /// Gets or sets the loan term as a string.
    /// </summary>
    public string? LoanTerm { get; set; }

    /// <summary>
    /// Gets or sets the method of loan payment.
    /// </summary>
    public string? LoanPaymentMethod { get; set; }

    /// <summary>
    /// Gets or sets the latest start date for an account or liability.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? LatestStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the latest cease date for an account or liability.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? LatestCeaseDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the type of real estate mortgage.
    /// </summary>
    public string? RealEstateMortgageType { get; set; }

    /// <summary>
    /// Gets or sets the status of the real estate mortgage.
    /// </summary>
    public string? RealEstateMortgageStatus { get; set; }

    /// <summary>
    /// Gets or sets the open date for the real estate mortgage.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? RealEstateMortgageOpenDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the most recent limit on the real estate mortgage.
    /// </summary>
    public double? RealEstateMortgageLatestLimit { get; set; }

    /// <summary>
    /// Gets or sets the list of accounts and their repayments related to the applicant.
    /// </summary>
    public IList<AccountAndRepayment> AccountAndRepayments { get; set; } = new List<AccountAndRepayment>();

    /// <summary>
    /// Gets or sets the collection of undisclosed liabilities for the applicant.
    /// </summary>
    public IList<UndisclosedLiability> UndisclosedLiabilities { get; set; } = new List<UndisclosedLiability>();

    /// <summary>
    /// Gets or sets the liability repayments associated with the credit history.
    /// </summary>
    public LiabilityRepayment? LiabilityRepayments { get; set; }

    #endregion
}
