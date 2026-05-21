namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a customer's declaration as part of a loan application, including financial expectations, circumstances, and related supporting details.
/// </summary>
public class CustomerDeclaration : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the related loan application for this customer declaration.
    /// </summary>
    public int? CustomerDeclaration_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer has been making payments on time.
    /// </summary>
    public bool IsPaymentTimely { get; set; }

    [Comment("Do you meet your payments/commitments on time every time?")]
    /// <summary>
    /// Indicates whether the customer meets repayments/commitments on time.
    /// </summary>
    public bool? ISMeetingRepaymentsOnTime { get; set; }

    /// <summary>
    /// Gets or sets the explanation given for expecting a repayments/commitments on time.
    /// </summary>
    [Comment("The reason property was added for the ISMeetingRepaymentsOnTime option (according to client's response), if selected yes")]
    public string? RepaymentsOnTimeExplanation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer expects a reduction in income over the next 3 years.
    /// </summary>
    [Comment("Do you expect a reduction to your income over the next 3 years? -- (e.g. extended leave, retirement, reduction in working hours or overtime")]
    public bool? ISExpectingIncomeChangeInNext3Years { get; set; }

    /// <summary>
    /// Gets or sets the reason given for expecting a reduction in income.
    /// </summary>
    [Comment("The reason property was added for the ISExpectingIncomeChangeInNext3Years option (according to client's response), if selected yes")]
    public string? IncomeChangeReason { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer expects an increase in expenses over the next 3 years.
    /// </summary>
    [Comment("Do you expect an increase in your expenses over the next 3 years -- (e.g. due to ill health, disability, end of an interest free period etc)")]
    public bool? ISExpectingExpenseIncreaseInNext3Years { get; set; }

    /// <summary>
    /// Gets or sets the reason given for expecting an increase in expenses.
    /// </summary>
    [Comment("The reason property was added for the ISExpectingExpenseIncreaseInNext3Years option (according to client's response), if selected yes")]
    public string? ExpenseIncreaseReason { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer expects a decrease in cash flow or profits over the next 3 years.
    /// </summary>
    [Comment("Do you expect a decrease in your cash flow/profits over the next 3 years (e.g. due to ill health, disability etc.)")]
    public bool? ISExpectingCashFlowDecreaseInNext3Years { get; set; }

    /// <summary>
    /// Gets or sets the reason given for expecting a decrease in cash flow or profits.
    /// </summary>
    [Comment("The reason property was added for the ISExpectingCashFlowDecreaseInNext3Years option (according to client's response), if selected yes")]
    public string? CashFlowOrProfitDecreaseReason { get; set; }

    /// <summary>
    /// Gets or sets the description of how foreseeable changes in circumstances will be mitigated.
    /// </summary>
    [Comment("How will the foreseeable change to circumstances be mitigated")]
    public string? ForeseeableChangeMitigationPlan { get; set; }

    [Comment("If loan term exceeds retirement age 70, can loan be repaid without hardship?")]
    /// <summary>
    /// Indicates whether repayment beyond retirement age 70 is intended without hardship.
    /// </summary>
    public bool? ISLoanRepayableBeyondRetirementWithoutHardship { get; set; }

    [Comment("Explanation for repayment beyond retirement age 70 without hardship.")]
    /// <summary>
    /// Explanation of how repayment will occur if term exceeds retirement age.
    /// </summary>
    public string? LoanRepaymentBeyondRetirementExplanation { get; set; }

    /// <summary>
    /// Gets or sets the ID indicating whether the loan term will exceed retirement age, referenced from the GeneralLookUp table.
    /// </summary>
    [Comment("We will get this from GeneralLookUp Table.")]
    public int? LoanTermExceedRetirementAgeType_GeneralLookUpID { get; set; }

    [Comment("Any additional foreseeable issues that may affect loan repayment?")]
    /// <summary>
    /// Indicates whether there are additional foreseeable issues affecting repayments.
    /// </summary>
    public bool? HASAdditionalForeseeableRepaymentRisks { get; set; }

    [Comment("Explanation for additional foreseeable issues affecting repayment.")]
    /// <summary>
    /// Explanation of additional foreseeable issues and repayment impact.
    /// </summary>
    public string? AdditionalForeseeableRepaymentRisksExplanation { get; set; }

    [Comment("Are you comfortable with ability to make repayments under the proposed loan?")]
    /// <summary>
    /// Indicates whether the customer is comfortable making repayments under the proposed loan.
    /// </summary>
    public bool? ISComfortableWithProposedLoanRepayments { get; set; }

    [Comment("Explanation for comfort with repayments under the proposed loan.")]
    /// <summary>
    /// Explanation related to comfort in meeting proposed loan repayments.
    /// </summary>
    public string? ProposedLoanRepaymentComfortExplanation { get; set; }

    /// <summary>
    /// Gets or sets the ID for the refinance reason, referenced from the GeneralLookUp table.
    /// </summary>
    [Comment("Refinance reason will get this data from GeneralLookUp table")]
    public int? RefinanceReasonType_GeneralLookUpID { get; set; }

    [Comment("Benefits of refinance.")]
    /// <summary>
    /// Summary of refinance benefits.
    /// </summary>
    public string? RefinanceBenefits { get; set; }

    /// <summary>
    /// Gets or sets the explanation of the expected benefit from refinancing.
    /// </summary>
    public string? RefinanceBenefitExplanation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer is able to repay the proposed loan.
    /// </summary>
    public bool ISAbleToRepayProposedLoan { get; set; }

    /// <summary>
    /// Gets or sets an explanation if the customer is not able to repay the proposed loan.
    /// </summary>
    [Comment("Explanation")]
    public string? RepaymentExplanationIfNotAble { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there are any other reasons that may impact the customer's loan application credibility.
    /// </summary>
    [Comment("Is there anything else that may reasonably be expected to have a bearing on your application for credit, knowing that if you leave such information out it may cause problems in making your loan repayments?")]
    public bool HasOtherReasonsImpactingLoanCredibility { get; set; }

    /// <summary>
    /// Gets or sets the explanation for other reasons that may impact the customer's ability to make loan repayments.
    /// </summary>
    [Comment("Explanation")]
    public string? ImpactingLoanCredibilityReason { get; set; }

    /// <summary>
    /// Gets or sets the list of customer retirement strategies associated with the declaration.
    /// </summary>
    public IList<CustomerRetirementStrategy> CustomerRetirementStrategies { get; set; } = new List<CustomerRetirementStrategy>();

    /// <summary>
    /// Gets or sets the collection of features associated with this customer declaration.
    /// </summary>
    public IList<CustomerDeclarationFeature> CustomerDeclarationFeatures { get; set; } = new List<CustomerDeclarationFeature>();

    /// <summary>
    /// Gets or sets the number of splits for the loan account, as specified in the MST field.
    /// </summary>
    [Comment("MST has that field - Loan account split")]
    public int? NumberOfSplits { get; set; }

    /// <summary>
    /// Gets or sets the list of loan declarations associated with the customer.
    /// </summary>
    public IList<CustomerLoanDeclaration> CustomerLoanDeclarations { get; set; } = new List<CustomerLoanDeclaration>();

    /// <summary>
    /// Gets or sets the related loan application entity for this customer declaration.
    /// </summary>
    public LoanApplication? CustomerDeclaration_LoanApplication { get; set; }
}
