using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the workflow configuration for approvers associated with a loan application,
/// specifying the entity type, user group, and approval hierarchy.
/// </summary>
public class LoanApplicationApproverWorkflow : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the entity type for this approver workflow (typically "loan application").
    /// </summary>
    public string? EntityType { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user group responsible for this workflow stage.
    /// </summary>
    public int? LoanApplicationApproverWorkflow_UserGroupID { get; set; }

    /// <summary>
    /// Gets or sets the user group entity associated with this workflow.
    /// </summary>
    public UserGroup? LoanApplicationApproverWorkflow_UserGroup { get; set; }

    /// <summary>
    /// Gets or sets the organization type of the approver entity for this workflow.
    /// </summary>
    public DomainOrganizationTypes ApproverEntityType { get; set; }

    /// <summary>
    /// Gets or sets the hierarchy type specifying the approval level for this workflow.
    /// </summary>
    public LoanApplicationHierarchyType? LoanApplicationApproverWorkflow_HierarchyType { get; set; }
}
