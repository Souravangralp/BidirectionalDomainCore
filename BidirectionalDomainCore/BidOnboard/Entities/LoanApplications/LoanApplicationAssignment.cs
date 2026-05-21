using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    /// <summary>
    /// Represents the assignment of a loan application to a user, including comments and related details.
    /// </summary>
    public class LoanApplicationAssignment : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the associated loan application.
        /// </summary>
        public int? LoanApplicationAssignment_LoanApplicationID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the assigned user.
        /// </summary>
        public int? LoanApplicationAssignment_UserID { get; set; }

        /// <summary>
        /// Gets or sets the loan application associated with this assignment.
        /// </summary>
        public LoanApplication? LoanApplicationAssignment_LoanApplication { get; set; }

        /// <summary>
        /// Gets or sets the user to whom the loan application is assigned.
        /// </summary>
        public User? LoanApplicationAssignment_User { get; set; }

        /// <summary>
        /// Gets or sets the comment associated with this assignment.
        /// </summary>
        public string? Comment { get; set; }
    }
}
