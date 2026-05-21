namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the security details associated with a loan detail, including mortgagor information and security priority.
/// </summary>
public class LoanDetailSecurity : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related loan detail.
    /// </summary>
    public int? LoanDetailSecurity_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets the mortgagor details of the loan security.
    /// </summary>
    public string? MortgagorDetail { get; set; }

    /// <summary>
    /// Gets or sets the priority of the loan security.
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the security.
    /// </summary>
    public string? SecurityUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the associated loan detail entity for this security.
    /// </summary>
    public LoanDetail? LoanDetailSecurity_LoanDetail { get; set; }
}
