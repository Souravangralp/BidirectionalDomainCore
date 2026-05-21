namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Records the last time each user opened a loan application. At most one active row exists per user and loan application; reopening updates <see cref="LastOpenedUtc"/>.
/// </summary>
public class LoanApplicationUserOpen : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the loan application that was opened.
    /// </summary>
    public int? LoanApplicationUserOpen_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who opened the loan application.
    /// </summary>
    public int? LoanApplicationUserOpen_UserID { get; set; }

    /// <summary>
    /// Gets or sets the loan application that was opened.
    /// </summary>
    public LoanApplication? LoanApplicationUserOpen_LoanApplication { get; set; }

    /// <summary>
    /// Gets or sets the user who opened the loan application.
    /// </summary>
    public User? LoanApplicationUserOpen_User { get; set; }

    /// <summary>
    /// Gets or sets when the user last opened this loan application (UTC). Use this to order recent applications for a user.
    /// </summary>
    public DateTime LastOpenedUtc { get; set; }
}
