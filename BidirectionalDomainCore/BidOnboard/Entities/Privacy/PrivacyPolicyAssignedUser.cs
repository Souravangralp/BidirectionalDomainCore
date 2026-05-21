namespace Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

public class PrivacyPolicyAssignedUser : BaseAuditableEntity
{
    public int? PrivacyPolicyAssignedUser_PrivacyPolicyAssignmentID { get; set; }

    public int? PrivacyPolicyAssignedUser_UserID { get; set; }

    public bool ISAccepted { get; set; }

    public int? PrivacyPolicyAssignedUser_UserGroupID { get; set; }

    public PrivacyPolicyAssignment? PrivacyPolicyAssignedUser_PrivacyPolicyAssignment { get; set; }

    public User? PrivacyPolicyAssignedUser_User { get; set; }

    public UserGroup? PrivacyPolicyAssignedUser_UserGroup { get; set; }
}
