using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    /// <summary>
    /// Represents the mapping between email notification templates and specific loan application hierarchy levels, user groups, and stages.
    /// </summary>
    public class EmailNotificationHierarchyLevelMapper : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the loan application stage associated with this email notification mapping.
        /// </summary>
        public int? EmailNotificationHierarchyLevelMapper_LoanApplicationStageID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user group associated with this email notification mapping.
        /// </summary>
        public int? EmailNotificationHierarchyLevelMapper_UserGroupID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the loan application hierarchy level associated with this email notification mapping.
        /// </summary>
        public int? EmailNotificationHierarchyLevelMapper_LoanApplicationHierarchyLevelID { get; set; }

        /// <summary>
        /// Gets or sets the SendGrid template ID used for email notifications in this mapping.
        /// </summary>
        public string? SendGridTemplateID { get; set; }

        /// <summary>
        /// Gets or sets the loan application stage navigation property for this mapping.
        /// </summary>
        public LoanApplicationStage? EmailNotificationHierarchyLevelMapper_LoanApplicationStage { get; set; }

        /// <summary>
        /// Gets or sets the user group navigation property for this mapping.
        /// </summary>
        public UserGroup? EmailNotificationHierarchyLevelMapper_UserGroup { get; set; }

        /// <summary>
        /// Gets or sets the loan application hierarchy level navigation property for this mapping.
        /// </summary>
        public LoanApplicationHierarchyLevel? EmailNotificationHierarchyLevelMapper_LoanApplicationHierarchyLevel { get; set; }
    }
}
