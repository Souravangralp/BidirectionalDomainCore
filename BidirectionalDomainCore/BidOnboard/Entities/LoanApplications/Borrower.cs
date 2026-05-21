namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a borrower in a loan application, detailing relationship to loan details and associated owners.
/// </summary>
public class Borrower : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the related loan detail.
    /// </summary>
    public int? Borrower_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets the proportion of the loan attributed to the borrower.
    /// </summary>
    public string? LoanProportion { get; set; }

    /// <summary>
    /// Gets or sets the associated <see cref="LoanDetail"/> for the borrower.
    /// </summary>
    public LoanDetail? Borrower_LoanDetail { get; set; }

    /// <summary>
    /// Gets or sets the list of owners associated with the borrower.
    /// </summary>
    public IList<Owner> Owner { get; set; } = new List<Owner>();
}
