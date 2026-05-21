namespace Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

public class PrivacyPolicy : BaseAuditableEntity
{
    public int? ParentPrivacyPolicyID { get; set; }

    public int? PrivacyPolicy_OrganizationID { get; set; }

    public int? PrivacyPolicy_BusinessUnitID { get; set; }

    public int? PrivacyPolicy_UserID { get; set; }

    public TargetEntityTypes TargetEntityType { get; set; }

    public int? PrivacyPolicy_PrivacyPolicyTypeID { get; set; }

    public string? PolicyDescription { get; set; }

    public string? PolicyURL { get; set; }

    public string? HtmlContent { get; set; }

    public string? Version { get; set; }

    public Organization? PrivacyPolicy_Organization { get; set; }

    public BusinessUnit? PrivacyPolicy_BusinessUnit { get; set; }

    public User? PrivacyPolicy_User { get; set; }

    public bool ISDefault { get; set; }

    public PrivacyPolicy? ParentPrivacyPolicy { get; set; }

    public PrivacyPolicyType? PrivacyPolicy_PrivacyPolicyType { get; set; }

    public List<PrivacyPolicyAssignment> PrivacyPolicyAssignments { get; set; } = [];

    public List<PolicyAgreementAcceptanceGroup> PrivacyPolicyAcceptanceGroups { get; set; } = [];

    //If we remove all migration then uncomment this.
    //public BranchAcceptedPolicy? BranchAcceptedPolicy { get; set; }
}
