namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a mapping between a user and a loan application, including the user's role, associated company, activation status, and tracking of the last update.
/// </summary>
public class UserLoanApplicationMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the foreign key referencing the related loan application.
    /// </summary>
    public int? UserLoanApplicationMapper_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the user's role within the loan application.
    /// </summary>
    public int? UserLoanApplicationMapper_RoleID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the mapped user.
    /// </summary>
    public int? UserLoanApplicationMapper_UserID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated company within the mapping. Used to update applicants for a specific company.
    /// </summary>
    public int? UserLoanApplicationMapper_CompanyID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the mapping is active.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Gets or sets the UTC date and time when the mapping was last updated.
    /// </summary>
    public DateTime LastUpdatedUtc { get; set; }
}
