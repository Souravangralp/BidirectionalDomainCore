namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the repayment details of a liability, including payment type, frequency, amounts, and related entities.
/// </summary>
public class LiabilityRepayment : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related liability for this repayment.
    /// </summary>
    public int? LiabilityRepayment_LiabilityID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated credit history record (financial and non-financial) linked to this repayment.
    /// </summary>
    public int? RepaymentDetail_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    /// <summary>
    /// Gets or sets the repayment frequency type using the value from the GeneralLookupTable.
    /// </summary>
    [Comment("We will get this from GeneralLookupTable table")]
    public int? RepaymentFrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the payment type, referencing the GeneralLookupTable.
    /// </summary>
    [Comment("We will get this from GeneralLookupTable table")]
    public int? PaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the payment is a regular payment.
    /// </summary>
    public bool IsRegularPayment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the repayment amount is tax-deductible.
    /// </summary>
    public bool ISTaxDeductible { get; set; }

    /// <summary>
    /// Gets or sets the repayment amount for the liability.
    /// </summary>
    public double? RepaymentAmount { get; set; }

    /// <summary>
    /// Gets or sets information about real estate mortgages associated with this liability repayment.
    /// </summary>
    [Comment("We are storing Real estate Mortgages information here")]
    public string? RealEstateMortgageInformation { get; set; }

    /// <summary>
    /// Gets or sets the status of the related bank account.
    /// </summary>
    public string? BankAccountStatus { get; set; }

    /// <summary>
    /// Gets or sets the credit limit of the associated bank account.
    /// </summary>
    public string? BankCreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the associated bank account was opened.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? BankOpenDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the related liability entity for this repayment.
    /// </summary>
    public Liability? LiabilityRepayment_Liability { get; set; }

    /// <summary>
    /// Gets or sets the related credit history (financial and non-financial) entity for this repayment detail.
    /// </summary>
    public CreditHistoryForFinancialAndNonFinancial? RepaymentDetail_CreditHistoryForFinancialAndNonFinancial { get; set; }
}
