namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the regular repayment details associated with a loan application, including frequency, amount, and related loan details.
/// </summary>
public class RegularRepayment : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the related loan detail for this regular repayment.
    /// </summary>
    public int? RegularRepayment_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the frequency type, referencing the CoreDB GeneralLookUp table.
    /// </summary>
    public int? FrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the repayment amount for this regular repayment.
    /// </summary>
    [EncryptColumn]
    public double? Amount { get; set; }

    /// <summary>
    /// Gets or sets the amount to be capitalized as part of the regular repayment.
    /// </summary>
    public double? Capitalizing { get; set; }

    /// <summary>
    /// Gets or sets the associated <see cref="LoanDetail"/> entity for this regular repayment.
    /// </summary>
    public LoanDetail? RegularRepayment_LoanDetail { get; set; }
}
