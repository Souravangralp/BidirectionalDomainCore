namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the various reasons and associated details related to a loan application in the Bidirectional domain.
/// </summary>
public class ApprovalReason : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated preference repayment detail reason.
    /// </summary>
    public int? ApprovalReason_PreferenceRepaymentDetailID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated interest rate detail reason.
    /// </summary>
    public int? ApprovalReason_InterestRateDetailID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated funds detail reason.
    /// </summary>
    public int? ApprovalReason_FundsDetailID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated refinancing and consolidation reason.
    /// </summary>
    public int? ApprovalReason_RefinancingConsolidationID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether flexibility is a reason.
    /// </summary>
    public bool ISFlexible { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant wants terms close to their current loan.
    /// </summary>
    public bool CloseToCurrentLoanTerm { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether dissatisfaction with the current lender is cited as a reason.
    /// </summary>
    public bool HASDissatisfactionWithCurrentLender { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether greater flexibility is an applicant's reason for the loan.
    /// </summary>
    public bool HASGreaterFlexibility { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a lower interest rate is sought as a reason.
    /// </summary>
    public bool HASLowerInterestRate { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether 'other' is specified as a reason.
    /// </summary>
    public bool HASOther { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether reduced repayment is a reason.
    /// </summary>
    public bool HASReducedRepayment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether access to funds is a motivation.
    /// </summary>
    public bool AllowAccessToFund { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether access to funds at any time is required.
    /// </summary>
    public bool AllowAccessToFundAnytime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether paying the loan sooner is a reason.
    /// </summary>
    public bool AllowPayingLoanSooner { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether an increase in total loan amount is sought.
    /// </summary>
    public bool HASIncreaseTotalLoanAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant desires a term close to their current loan's term details.
    /// </summary>
    public bool ISCloseToCurrentLoanTermDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a non-recurring expense item is a reason.
    /// </summary>
    public bool ISNonRecurringExpenseItem { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a temporary reduction in income is a reason.
    /// </summary>
    public bool HASTemporaryReductionInIncome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether variable cash flow is a motivating factor.
    /// </summary>
    public bool HASVariableCashFlow { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether investing and tax planning assistance is sought.
    /// </summary>
    public bool HASInvestingAndTaxPlanningAssistance { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether avoiding rate increase risk is desired.
    /// </summary>
    public bool ISAvoidingRateIncreaseRisk { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether building equity from the start is a reason.
    /// </summary>
    public bool HASBuildEquityFromStart { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a discount on the interest rate is a factor.
    /// </summary>
    public bool HASDiscountOnInterestRate { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether prepaid fund flexibility is desired.
    /// </summary>
    public bool ISFlexibleForPrepaidFund { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether repayment flexibility is a concern.
    /// </summary>
    public bool ISFlexibleForRepayment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan application is for tax purposes.
    /// </summary>
    public bool ForTaxPurpose { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a higher lender limit is sought.
    /// </summary>
    public bool HASHigherLenderLimit { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether minimizing interest over the loan's lifetime is a reason.
    /// </summary>
    public bool MinimizeInterestOverLifeTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a need to apply for lending in the future.
    /// </summary>
    public bool NeedToApplyLendingInFuture { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether limiting rate increase risk is important.
    /// </summary>
    public bool ISLimitingRateIncreaseRisk { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a lower deposit requirement is sought.
    /// </summary>
    public bool ISLowerDepositRequired { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether making budgeting easier is a motivation.
    /// </summary>
    public bool MakingBudgetingEasier { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is an ongoing need for funds.
    /// </summary>
    public bool OngoingNeedForFund { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether 'other' is specified as a standalone reason.
    /// </summary>
    public bool Other { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a potential rate decrease is a reason.
    /// </summary>
    public bool HASPotentialRateDecrease { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is recommended.
    /// </summary>
    public bool HASRecommendation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether taxation or accounting reasons apply.
    /// </summary>
    public bool HASTaxationAccountingReason { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan assists with cash flow and budgeting.
    /// </summary>
    public bool ToAssistWithCashFlowAndBudgeting { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether variable and unpredictable income is a reason.
    /// </summary>
    public bool HASVariableAndUnpredictableIncome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan accommodates anticipated non-recurring expense items.
    /// </summary>
    public bool ISAccommodateAnticipatedNonRecurringExpenseItem { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether accommodating a temporary reduction in income is a factor.
    /// </summary>
    public bool ISAccommodateTemporaryReductionInIncome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether anticipated variable cash flows are a reason.
    /// </summary>
    public bool ISAnticipatedVariableCashFlows { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan assists with investment purchases and tax planning.
    /// </summary>
    public bool ISAssistsWithInvestmentPurchasesAndTaxPlanning { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is flexibility to manage repayments.
    /// </summary>
    public bool HASFlexibilityToManageRepayments { get; set; }

    /// <summary>
    /// Gets or sets details regarding dissatisfaction with the current lender.
    /// </summary>
    public string? DissatisfactionWithCurrentLenderDetails { get; set; }

    /// <summary>
    /// Gets or sets details concerning greater flexibility reasons.
    /// </summary>
    public string? GreaterFlexibilityDetails { get; set; }

    /// <summary>
    /// Gets or sets details regarding increase in total loan amount.
    /// </summary>
    public string? IncreaseTotalLoanAmountDetails { get; set; }

    /// <summary>
    /// Gets or sets details about lower interest rate reasoning.
    /// </summary>
    public string? LowerInterestRateDetails { get; set; }

    /// <summary>
    /// Gets or sets further details about other reasons specified.
    /// </summary>
    public string? OtherDetails { get; set; }

    /// <summary>
    /// Gets or sets details concerning reduced repayment reasons.
    /// </summary>
    public string? ReducedRepaymentDetails { get; set; }

    /// <summary>
    /// Gets or sets the preference repayment detail associated with this reason.
    /// </summary>
    public PreferenceRepaymentDetail? ApprovalReason_PreferenceRepaymentDetail { get; set; }

    /// <summary>
    /// Gets or sets the interest rate detail associated with this reason.
    /// </summary>
    public InterestRateDetail? ApprovalReason_InterestRateDetail { get; set; }

    /// <summary>
    /// Gets or sets the funds detail associated with this reason.
    /// </summary>
    public FundsDetail? ApprovalReason_FundsDetail { get; set; }

    /// <summary>
    /// Gets or sets the refinancing and consolidation details associated with this reason.
    /// </summary>
    public RefinancingConsolidation? ApprovalReason_RefinancingConsolidation { get; set; }
}
