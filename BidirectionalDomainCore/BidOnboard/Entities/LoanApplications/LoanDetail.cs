namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details of a loan application, including type, purpose, split, and settlement date.
/// </summary>
public class LoanDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated loan split.
    /// </summary>
    public int? LoanDetail_LoanSplitID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the loan type from the general lookup table.
    /// </summary>
    public int? LoanType_GeneralLookUpID { get; set; } // We Will get this Value from generalLookUp table

    /// <summary>
    /// Gets or sets the estimated settlement date of the loan in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? EstimatedSettlementDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the details of the loan purpose.
    /// </summary>
    public LoanPurposeDetail? LoanPurposeDetails { get; set; }

    /// <summary>
    /// Gets or sets the associated loan split entity.
    /// </summary>
    public LoanSplit? LoanDetail_LoanSplit { get; set; }
}
