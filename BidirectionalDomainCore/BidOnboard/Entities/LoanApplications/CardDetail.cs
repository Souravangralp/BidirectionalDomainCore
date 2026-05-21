using Bidirectional.DomainCore.BidOnboard.Enums;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details associated with a card as part of a loan application, including card type, usage, status, and relevant financial information.
/// </summary>
public class CardDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the applicant related to this card detail.
    /// </summary>
    public int? CardDetail_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the company applicant related to this card detail.
    /// </summary>
    public int? CardDetail_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the trust related to this card detail.
    /// </summary>
    public int? CardDetail_TrustID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the card type.
    /// </summary>
    public int? CardType_GeneralLookUpID { get; set; } // We Will be getting CardType From GeneralLookupTable

    /// <summary>
    /// Gets or sets the general lookup identifier for the card option type.
    /// </summary>
    public int? CardOptionType_GeneralLookUpID { get; set; } // We Will be getting CardOptionType From GeneralLookupTable

    public string? OtherCardType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the card is currently in active use.
    /// </summary>
    public bool HASUsage { get; set; }  // true Means Card Is Active

    /// <summary>
    /// Gets or sets a value indicating whether the card balance is cleared in full every month.
    /// </summary>
    public bool ISClearedInFullEveryMonth { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates whether this loan is to be refinanced or none.
    /// </summary>
    public PropertyRefinanceStatus RefinancingStatus { get; set; } = PropertyRefinanceStatus.None;

    /// <summary>
    /// Gets or sets the name of the financial institution associated with the card.
    /// </summary>
    [EncryptColumn]
    public string? FinancialInstitutionName { get; set; }

    /// <summary>
    /// Gets or sets the account number for the card.
    /// </summary>
    [EncryptColumn]
    public string? AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the credit limit of the card.
    /// </summary>
    public double? CreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the amount currently owing on the card.
    /// </summary>
    public decimal? AmountCurrentlyOwing { get; set; }

    #region Salestrekker Payload

    /// <summary>
    /// Gets or sets a value indicating whether the card is being cleared from another source.
    /// </summary>
    public bool ISClearingFromOtherSource { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the card is being cleared from this loan.
    /// </summary>
    public bool ISClearingFromThisLoan { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the card account has arrears.
    /// </summary>
    public bool HASArrears { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the card is negatively geared.
    /// </summary>
    public bool ISNegativelyGeared { get; set; }

    /// <summary>
    /// Gets or sets the negatively geared percentage for the card.
    /// </summary>
    public string? NegativelyGearedPercentage { get; set; }

    /// <summary>
    /// Gets or sets the original amount associated with the card when it was opened.
    /// </summary>
    public string? OriginalAmount { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance on the card.
    /// </summary>
    public string? OutstandingBalance { get; set; }

    /// <summary>
    /// Gets or sets the original purpose for which the loan or card was opened.
    /// </summary>
    public string? OriginalLoanPurpose { get; set; }

    /// <summary>
    /// Gets or sets the new credit limit requested or assigned.
    /// </summary>
    public string? NewCreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the name of another financial institution associated with the card, if applicable.
    /// </summary>
    public string? OtherFinancialInstitutionName { get; set; }

    /// <summary>
    /// Gets or sets the repayment amount for the card.
    /// </summary>
    public string? RepaymentAmount { get; set; }

    /// <summary>
    /// Gets or sets the repayment frequency type identifier from the general lookup table.
    /// </summary>
    public int? RepaymentFrequencyType_GeneralLookUpID { get; set; } // We Will be getting CardOptionType From GeneralLookupTable

    /// <summary>
    /// Gets or sets a value indicating whether repayments are tax deductible.
    /// </summary>
    public bool ISTaxDeductible { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether repayments are regular.
    /// </summary>
    public bool ISRegular { get; set; }

    /// <summary>
    /// Gets or sets additional field for extra data or metadata (1).
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets additional field for extra data or metadata (2).
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets additional field for extra data or metadata (3).
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the associated applicant entity for this card detail.
    /// </summary>
    public Applicant? CardDetail_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the associated company applicant entity for this card detail.
    /// </summary>
    public CompanyApplicant? CardDetail_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the associated trust entity for this card detail.
    /// </summary>
    public Trust? CardDetail_Trust { get; set; }

    #endregion
}
