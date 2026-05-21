namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details of a court judgement associated with a loan application's credit history.
/// </summary>
public class CourtJudgementDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier linking to the associated financial or non-financial credit history record.
    /// </summary>
    public int? CourtJudgementDetail_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the payment status type from the general lookup table in the core database.
    /// </summary>
    public int? PaymentStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the value or amount related to the court judgement.
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or sets the date when the court judgement was listed.
    /// </summary>
    public DateOnly? ListedOn { get; set; }

    /// <summary>
    /// Gets or sets the amount that has been paid towards the court judgement.
    /// </summary>
    public double? Paid { get; set; }

    /// <summary>
    /// Gets or sets the date when the payment was made for the court judgement.
    /// </summary>
    public DateOnly? PaidOn { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for the related credit history for financial and non-financial accounts.
    /// </summary>
    public CreditHistoryForFinancialAndNonFinancial? CourtJudgementDetail_CreditHistoryForFinancialAndNonFinancial { get; set; }
}
