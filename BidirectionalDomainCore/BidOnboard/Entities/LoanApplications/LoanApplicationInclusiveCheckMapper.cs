namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the mapping between a loan application and its associated inclusive check and status.
/// </summary>
public class LoanApplicationInclusiveCheckMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the related loan application.
    /// </summary>
    public int? LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the inclusive check associated with the loan application.
    /// </summary>
    public int? InclusiveCheckID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the inclusive check has been marked as checked.
    /// </summary>
    public bool? ISChecked { get; set; }
}
