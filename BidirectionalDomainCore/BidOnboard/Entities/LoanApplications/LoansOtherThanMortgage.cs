using Bidirectional.DomainCore.BidOnboard.Enums;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents details of loans other than mortgage associated with a loan application,
/// including financial product details, repayments, liabilities, and related attributes.
/// </summary>
public class LoansOtherThanMortgage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the financial product type identifier from the GeneralLookup table.
    /// </summary>
    public int? FinancialProductType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this loan is to be refinanced or none.
    /// </summary>
    public PropertyRefinanceStatus RefinancingStatus { get; set; } = PropertyRefinanceStatus.None;

    /// <summary>
    /// Gets or sets a value indicating whether there is any loan other than mortgage.
    /// </summary>
    public bool ISThereAnyLoanOtherThenMortgage { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution for the loan.
    /// </summary>
    public string? NameOfFinancialInstitution { get; set; }

    /// <summary>
    /// Gets or sets the account number associated with the loan.
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the monthly repayment amount for the loan.
    /// </summary>
    public double? MonthlyRepayment { get; set; }

    /// <summary>
    /// Gets or sets the interest type identifier from the GeneralLookup table.
    /// True indicates fixed rate; otherwise, variable rate.
    /// </summary>
    [Comment("if it is true then current fixed else variable rate")]
    public int? InterestType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the interest rate applicable to the loan.
    /// </summary>
    public double? InterestRate { get; set; }

    /// <summary>
    /// Gets or sets the UTC date until which the rate is fixed.
    /// </summary>
    public DateTime? FixedTillUtc { get; set; }

    /// <summary>
    /// Gets or sets the repayment type identifier from the GeneralLookup table.
    /// Yes means principal and interest; No means interest only.
    /// </summary>
    [Comment("Yes means P And I and No means IO")]
    public int? RepaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the BSB (Bank State Branch) code for the loan account.
    /// </summary>
    [EncryptColumn]
    public string? BSB { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is being cleared from another source.
    /// </summary>
    public bool ISClearingFromOtherSource { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is being cleared from this loan.
    /// </summary>
    public bool ISClearingFromThisLoan { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan account has arrears.
    /// </summary>
    public bool HASArrears { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is negatively geared.
    /// </summary>
    public bool ISNegativelyGeared { get; set; }

    /// <summary>
    /// Gets or sets the credit limit for the loan or credit facility.
    /// </summary>
    public double? CreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the type of credit card.
    /// </summary>
    [EncryptColumn]
    public string? CreditCardType { get; set; }

    /// <summary>
    /// Gets or sets the annual interest rate for the loan or credit card.
    /// </summary>
    public double? AnnualInterestRate { get; set; }

    /// <summary>
    /// Gets or sets the negatively geared percentage for the property or loan.
    /// </summary>
    public double? NegativelyGearedPercentage { get; set; }

    /// <summary>
    /// Gets or sets the original loan or credit amount.
    /// </summary>
    public double? OriginalAmount { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance currently owed.
    /// </summary>
    public decimal? OutstandingBalance { get; set; }

    /// <summary>
    /// Gets or sets the original purpose of the loan.
    /// </summary>
    public string? OriginalLoanPurpose { get; set; }

    /// <summary>
    /// Gets or sets the new credit limit after refinancing or restructuring.
    /// </summary>
    public double? NewLimit { get; set; }

    /// <summary>
    /// Gets or sets the name of the other financial institution involved.
    /// </summary>
    public string? OtherFIName { get; set; }

    /// <summary>
    /// Gets or sets the amount to be repaid in each repayment period.
    /// </summary>
    public double? RepaymentAmount { get; set; }

    /// <summary>
    /// Gets or sets the repayment frequency type identifier from the GeneralLookup table.
    /// </summary>
    [Comment("We Will be getting CardOptionType From GeneralLookupTable")]
    public int? RepaymentFrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the remaining frequency type identifier from the GeneralLookup table.
    /// </summary>
    [Comment("We Will be getting CardOptionType From GeneralLookupTable")]
    public int? RemainingFrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the remaining duration for the loan or credit facility.
    /// </summary>
    public string? RemainingDuration { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is tax deductible.
    /// </summary>
    public bool ISTaxDeductible { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is a regular ongoing liability.
    /// </summary>
    public bool ISRegular { get; set; }

    /// <summary>
    /// Gets or sets an additional field for custom information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an additional field for custom information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an additional field for custom information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the list of percent owner liabilities associated with this loan.
    /// </summary>
    public IList<OwnerLiabilityPercentage> OwnerLiabilityPercentages { get; set; } = new List<OwnerLiabilityPercentage>();
}
