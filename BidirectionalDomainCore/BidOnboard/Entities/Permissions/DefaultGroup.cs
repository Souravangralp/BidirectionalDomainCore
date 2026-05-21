namespace Bidirectional.DomainCore.BidOnboard.Entities.Permissions;

public class DefaultGroup : BaseAuditableEntity
{
    public int? DefaultGroup_UserGroupID { get; set; } // it will contains the group id from UserGroup table

    public DomainEntityTypes EntityType { get; set; } // it will contains onboarding type like company, branch other

    public UserGroup? DefaultGroup_UserGroup { get; set; }
}
