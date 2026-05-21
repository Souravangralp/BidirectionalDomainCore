namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    /// <summary>
    /// Represents a type of hierarchy applied to a loan application, defining its structure and associated approval workflow.
    /// </summary>
    public class LoanApplicationHierarchyType : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the associated loan application approver workflow.
        /// </summary>
        public int? LoanApplicationHierarchyType_LoanApplicationApproverWorkflowID { get; set; }

        /// <summary>
        /// Gets or sets the name of the hierarchy type (e.g., "Lender?WLP?Aggregator?Broker").
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the loan application approver workflow associated with this hierarchy type.
        /// </summary>
        public LoanApplicationApproverWorkflow? LoanApplicationHierarchyType_LoanApplicationApproverWorkflow { get; set; }

        /// <summary>
        /// Gets or sets the collection of hierarchy levels that define the order and structure of this hierarchy type.
        /// </summary>
        public ICollection<LoanApplicationHierarchyLevel> Levels { get; set; } = new List<LoanApplicationHierarchyLevel>();
    }
}
