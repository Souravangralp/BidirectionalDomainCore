namespace Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

public class PrivacyPolicyEntityTypeGroupMapper : BaseAuditableEntity
{
    public TargetEntityTypes TargetEntityType { get; set; }

    public int? PrivacyPolicyEntityTypeGroupMapping_PrivacyPolicyTypeID { get; set; }

    public int? PrivacyPolicyEntityTypeGroupMapping_UserGroupID { get; set; }

    public PolicySourceType PolicySourceType { get; set; }

    public PrivacyPolicyType? PrivacyPolicyEntityTypeGroupMapping_PrivacyPolicyType { get; set; }

    public UserGroup? PrivacyPolicyEntityTypeGroupMapping_UserGroup { get; set; }
}
