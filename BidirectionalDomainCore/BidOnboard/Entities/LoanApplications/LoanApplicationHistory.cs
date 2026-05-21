using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    /// <summary>
    /// Represents the historical record of changes or actions taken on a loan application, including the user, stage, timestamp, and optional comments.
    /// </summary>
    public class LoanApplicationHistory : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the associated loan application for this history record.
        /// </summary>
        public int? LoanApplicationHistory_LoanApplicationID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who performed the action.
        /// </summary>
        public int? LoanApplicationHistory_UserID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the loan application stage at the time the history was recorded.
        /// </summary>
        public int? LoanApplicationHistory_LoanApplicationStageID { get; set; }

        /// <summary>
        /// Gets or sets the loan application associated with this history entry.
        /// </summary>
        public LoanApplication? LoanApplicationHistory_LoanApplication { get; set; }

        /// <summary>
        /// Gets or sets the user who performed the action recorded in this history entry.
        /// </summary>
        public User? LoanApplicationHistory_User { get; set; }

        /// <summary>
        /// Gets or sets the stage of the loan application at the time this history was created.
        /// </summary>
        public LoanApplicationStage? LoanApplicationHistory_LoanApplicationStage { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this history entry was filled or recorded.
        /// </summary>
        public DateTime FilledOn { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the optional comments associated with this history entry.
        /// </summary>
        public string? Comments { get; set; }
    }
}
