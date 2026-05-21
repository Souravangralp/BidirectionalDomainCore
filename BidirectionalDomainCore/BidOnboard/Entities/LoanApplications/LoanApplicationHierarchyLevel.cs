namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    /// <summary>
    /// Represents a hierarchical level within a loan application, defining ordering and related notification mappings for different entity types.
    /// </summary>
    public class LoanApplicationHierarchyLevel : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the ID of the related loan application hierarchy type for this level.
        /// </summary>
        public int? LoanApplicationHierarchyLevel_LoanApplicationHierarchyTypeID { get; set; }

        //public int? LoanApplicationHierarchyLevel_UserGroupID { get; set; }

        /// <summary>
        /// Gets or sets the entity type associated with this hierarchy level, such as Lender, WLP, or Aggregator.
        /// </summary>
        public DomainEntityTypes EntityType { get; set; } // e.g. Lender, WLP, Aggregator

        /// <summary>
        /// Gets or sets the order of the level, where lower numbers indicate higher positions in the hierarchy (e.g., 1 = Lender, 2 = WLP).
        /// </summary>
        public int LevelOrder { get; set; } // e.g. 1 = Lender, 2 = WLP, etc.

        /// <summary>
        /// Gets or sets the list of email notification mappers associated with this hierarchy level.
        /// </summary>
        public List<EmailNotificationHierarchyLevelMapper> EmailNotificationHierarchyLevelMapper { get; set; } = [];

        /// <summary>
        /// Gets or sets the loan application hierarchy type entity associated with this level.
        /// </summary>
        public LoanApplicationHierarchyType? LoanApplicationHierarchyLevel_LoanApplicationHierarchyType { get; set; }

        //public UserGroup? LoanApplicationHierarchyLevel_UserGroup { get; set; } //sender broker
    }
}
