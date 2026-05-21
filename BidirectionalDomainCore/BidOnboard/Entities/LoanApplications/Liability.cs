namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a financial liability associated with a loan application, including details such as type, repayments, balances, and related securities.
/// </summary>
public class Liability : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan application.
    /// </summary>
    public int? Liability_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the credit card type lookup identifier.
    /// </summary>
    public int? CreditCardType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the liability type lookup identifier.
    /// </summary>
    public int? LiabilityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the remaining unit frequency type lookup identifier.
    /// </summary>
    public int? RemainingUnitFrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the repayment frequency type lookup identifier.
    /// </summary>
    public int? RepaymentFrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this liability is being cleared from this loan.
    /// </summary>
    public bool ISClearingFromThisLoan { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this liability is being cleared from another source.
    /// </summary>
    public bool ISClearingFromOtherSource { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this liability has arrears.
    /// </summary>
    public bool HASArrears { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this liability is negatively geared.
    /// </summary>
    public bool ISNegativelyGeared { get; set; }

    /// <summary>
    /// Gets or sets the percentage by which the liability is negatively geared.
    /// </summary>
    public double? NegativelyGearedPercentage { get; set; }

    /// <summary>
    /// Gets or sets the credit limit for the liability.
    /// </summary>
    public string? CreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the annual interest rate applied to the liability.
    /// </summary>
    public double? AnnualInterestRate { get; set; }

    /// <summary>
    /// Gets or sets the new credit limit for the liability, if applicable.
    /// </summary>
    public double? NewCreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the original loan amount for this liability.
    /// </summary>
    public double? OriginalLoanAmount { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance remaining on the loan.
    /// </summary>
    public double? OutstandingLoanBalance { get; set; }

    /// <summary>
    /// Gets or sets the net financed amount of the liability.
    /// </summary>
    public double? NetFinancedAmount { get; set; }

    /// <summary>
    /// Gets or sets the BSB number of the financial institution for this liability.
    /// </summary>
    [EncryptColumn]
    public string? BSBNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution for this liability.
    /// </summary>
    [EncryptColumn]
    public string? FinancialInstitutionName { get; set; }

    /// <summary>
    /// Gets or sets the name of another financial institution, if applicable.
    /// </summary>
    [EncryptColumn]
    public string? OtherFinancialInstitutionName { get; set; }

    /// <summary>
    /// Gets or sets a description of the loan.
    /// </summary>
    public string? LoanDescription { get; set; }

    /// <summary>
    /// Gets or sets the original purpose of the loan.
    /// </summary>
    public string? OriginalLoanPurpose { get; set; }

    /// <summary>
    /// Gets or sets the remaining loan term duration in applicable units.
    /// </summary>
    [EncryptColumn]
    public double? RemainingLoanTermDuration { get; set; }

    /// <summary>
    /// Gets or sets the original loan term.
    /// </summary>
    public string? OriginalLoanTerm { get; set; }

    /// <summary>
    /// Gets or sets the loan account number.
    /// </summary>
    [EncryptColumn]
    public string? LoanAccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the interest rate for the loan.
    /// </summary>
    public string? LoanInterestRate { get; set; }

    /// <summary>
    /// Gets or sets the description of linked assets for this liability.
    /// </summary>
    public double? LinkedAssetsDescription { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this liability is a refinance.
    /// </summary>
    public bool? ISRefinance { get; set; }

    /// <summary>
    /// Gets or sets the credit card number for the liability.
    /// </summary>
    [EncryptColumn]
    public string? CreditCardNumber { get; set; }

    /// <summary>
    /// Gets or sets the name used for the balance sheet entry.
    /// </summary>
    [EncryptColumn]
    public string? BalanceSheetName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this liability is a regular liability.
    /// </summary>
    public bool ISRegular { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the liability is tax-deductible.
    /// </summary>
    public bool ISTaxDeductible { get; set; }

    /// <summary>
    /// Gets or sets the repayment amount for this liability.
    /// </summary>
    public string? RepaymentAmount { get; set; }

    /// <summary>
    /// Gets or sets the payment type lookup identifier.
    /// </summary>
    public int? PaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the as-at date in UTC for the liability record.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? AsAtDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the fixed expiry date in UTC for the liability.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? FixedExpiryDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the loan term expiry date in UTC for the liability.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? LoanTermExpiryDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the collection of securities associated with this liability.
    /// </summary>
    public IList<LiabilitySecurity> LiabilitySecurities { get; set; } = new List<LiabilitySecurity>();

    /// <summary>
    /// Gets or sets the collection of percent owner liabilities associated with this liability.
    /// </summary>
    public IList<OwnerLiabilityPercentage> OwnerLiabilityPercentages { get; set; } = new List<OwnerLiabilityPercentage>();

    /// <summary>
    /// Gets or sets the related loan application entity.
    /// </summary>
    public LoanApplication? Liability_LoanApplication { get; set; }
}
