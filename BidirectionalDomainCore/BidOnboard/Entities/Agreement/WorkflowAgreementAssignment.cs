namespace Bidirectional.DomainCore.BidOnboard.Entities.Agreement;

public class WorkflowAgreementAssignment : BaseAuditableEntity
{
    public int? WorkflowAgreementAssignment_UserGroupID { get; set; }

    public DomainEntityTypes ParentEntityType { get; set; }

    public TargetEntityTypes TargetEntityType { get; set; }

    public AgreementTypes AgreementType { get; set; }

    public int? AssignmentOrder { get; set; }

    public UserGroup? WorkflowAgreementAssignment_UserGroup { get; set; }
}
