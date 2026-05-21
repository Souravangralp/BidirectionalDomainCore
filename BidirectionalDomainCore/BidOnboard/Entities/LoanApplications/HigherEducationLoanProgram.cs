namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details of a Higher Education Loan Program (HELP/HECS and similar) associated with a loan application,
/// including financial information, repayment terms, and related attributes.
/// </summary>
public class HigherEducationLoanProgram : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets a value indicating whether there are any HECS/HELP debts.
    /// </summary>
    [Comment("Are there any HECS/HELP debt(s)?")]
    public bool HasHECSorHELPDebts { get; set; }

    /// <summary>
    /// Gets or sets the latest repayment amount for the higher education loan.
    /// </summary>
    public double? LatestRepaymentAmount { get; set; }

    /// <summary>
    /// Gets or sets the current outstanding balance of the loan.
    /// </summary>
    public double? CurrentLoanBalance { get; set; }

    /// <summary>
    /// Gets or sets the BSB number associated with the loan account.
    /// </summary>
    public string? BSBNumber { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID indicating the interest type; true for fixed and false for variable rate.
    /// </summary>
    [Comment("if it is true then current fixed else variable rate")]
    public int? InterestType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the interest rate applied to the loan.
    /// </summary>
    public double? InterestRate { get; set; }

    /// <summary>
    /// Gets or sets the UTC date until which the interest rate is fixed.
    /// </summary>
    public DateTime? FixedTillUtc { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for repayment type; Yes means principal and interest (P & I), No means interest only (IO).
    /// </summary>
    [Comment("Yes means P And I and No means IO")]
    public int? RepaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution providing the loan.
    /// </summary>
    public string? FinancialInstitutionName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the debt is being cleared from another source.
    /// </summary>
    public bool ISClearingFromOtherSource { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the debt is being cleared from this loan.
    /// </summary>
    public bool ISClearingFromThisLoan { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan account currently has arrears.
    /// </summary>
    public bool HASArrears { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is negatively geared.
    /// </summary>
    public bool ISNegativelyGeared { get; set; }

    /// <summary>
    /// Gets or sets the percentage by which the loan is negatively geared.
    /// </summary>
    public string? NegativelyGearedPercentage { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance for the loan in string format.
    /// </summary>
    public string? OutstandingLoanBalance { get; set; }

    /// <summary>
    /// Gets or sets the purpose for which the loan has been taken.
    /// </summary>
    public string? LoanPurpose { get; set; }

    /// <summary>
    /// Gets or sets a description of the loan.
    /// </summary>
    public string? LoanDescription { get; set; }

    /// <summary>
    /// Gets or sets the name of another financial institution involved, if applicable.
    /// </summary>
    public string? OtherFinancialInstitutionName { get; set; }

    /// <summary>
    /// Gets or sets the repayment amount for the loan in string format.
    /// </summary>
    public string? RepaymentAmount { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID representing the repayment frequency type obtained from the general lookup table.
    /// </summary>
    [Comment("We Will get this From GeneralLookupTable")]
    public int? RepaymentFrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID representing the card type obtained from the general lookup table.
    /// </summary>
    [Comment("We Will get this From GeneralLookupTable")]
    public int? CardType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for the frequency type of the remaining loan duration, from the general lookup table.
    /// </summary>
    [Comment("We Will get this From GeneralLookupTable")]
    public int? RemainingFrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the duration remaining on the loan in string format.
    /// </summary>
    public string? RemainingLoanDuration { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is tax deductible.
    /// </summary>
    public bool ISTaxDeductible { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is regular.
    /// </summary>
    public bool ISRegular { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this loan is to be refinanced.
    /// </summary>
    public bool ToBeRefinanced { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information about the loan.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information about the loan.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information about the loan.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the collection of percent owner liabilities associated with the higher education loan.
    /// </summary>
    public IList<OwnerLiabilityPercentage> OwnerLiabilityPercentages { get; set; } = new List<OwnerLiabilityPercentage>();
}
