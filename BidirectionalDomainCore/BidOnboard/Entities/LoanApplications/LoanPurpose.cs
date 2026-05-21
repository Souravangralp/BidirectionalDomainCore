namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the purpose details associated with a specific loan, including owner builder status, NCCP status, and primary purpose.
/// </summary>
public class LoanPurpose : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related loan detail.
    /// </summary>
    public int? LoanPurpose_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the application is for an owner builder.
    /// </summary>
    public bool ISOwnerBuilderApplication { get; set; }

    /// <summary>
    /// Gets or sets the NCCP (National Consumer Credit Protection) status for the loan.
    /// </summary>
    public string? NCCPStatus { get; set; }

    /// <summary>
    /// Gets or sets the primary purpose of the loan.
    /// </summary>
    public string? PrimaryPurpose { get; set; }

    /// <summary>
    /// Gets or sets the associated loan detail entity.
    /// </summary>
    public LoanDetail? LoanPurpose_LoanDetail { get; set; }
}
