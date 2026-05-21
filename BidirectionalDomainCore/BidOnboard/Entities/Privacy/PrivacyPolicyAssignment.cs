namespace Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

public class PrivacyPolicyAssignment : BaseAuditableEntity
{
    public int? PrivacyPolicyAssignment_PrivacyPolicyID { get; set; }

    public int? PrivacyPolicyAssignment_OrganizationID { get; set; }

    public int? PrivacyPolicyAssignment_BusinessUnitID { get; set; }

    public bool ISFullyAccepted { get; set; }

    public PrivacyPolicy? PrivacyPolicyAssignment_PrivacyPolicy { get; set; }

    public Organization? PrivacyPolicyAssignment_Organization { get; set; }

    public BusinessUnit? PrivacyPolicyAssignment_BusinessUnit { get; set; }

    public List<PrivacyPolicyAssignedUser> PrivacyPolicyAssignedUsers { get; set; } = [];
}
