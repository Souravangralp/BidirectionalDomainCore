using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    /// <summary>
    /// Represents the mapping between a loan application approval stage and a user group responsible for approval, including their entity types.
    /// </summary>
    public class LoanApplicationApproverStageMapper : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier for the related loan application approval stage.
        /// </summary>
        public int? LoanApplicationApproverStageMapper_LoanApplicationStageID { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the associated user group responsible for approval.
        /// </summary>
        public int? LoanApplicationApproverStageMapper_UserGroupID { get; set; }

        /// <summary>
        /// Gets or sets the type of the approver entity for the loan application stage.
        /// </summary>
        public DomainOrganizationTypes ApproverEntityType { get; set; }

        /// <summary>
        /// Gets or sets the loan application stage mapped to this approver.
        /// </summary>
        public LoanApplicationStage? LoanApplicationApproverStageMapper_LoanApplicationStage { get; set; }

        /// <summary>
        /// Gets or sets the user group mapped to this approval stage.
        /// </summary>
        public UserGroup? LoanApplicationApproverStageMapper_UserGroup { get; set; }
    }
}
