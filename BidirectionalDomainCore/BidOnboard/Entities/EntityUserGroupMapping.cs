namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class EntityUserGroupMapping : BaseAuditableEntity
{
    public DomainEntityTypes DomainEntityType { get; set; }

    public TargetEntityTypes TargetEntityType { get; set; }

    public int? EntityUserGroupMapping_UserGroupID { get; set; }

    public UserGroup? EntityUserGroupMapping_UserGroup { get; set; }

    public ICollection<OnboardingRequiredDocument> OnboardingRequiredDocuments { get; set; } = [];
}
