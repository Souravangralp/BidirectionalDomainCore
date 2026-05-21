using Bidirectional.DomainCore.BidOnboard.Entities.Agreement;

namespace Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

public class PolicyAgreementAcceptanceGroup : BaseAuditableEntity
{
    public int? PolicyAgreementAcceptanceGroup_PrivacyPolicyID { get; set; }

    public int? PolicyAgreementAcceptanceGroup_DefaultAgreementID { get; set; }

    public int? PolicyAgreementAcceptanceGroup_OrganizationBusinessUnitAgreementID { get; set; }

    public int? PolicyAgreementAcceptanceGroup_UserGroupID { get; set; }

    public PrivacyPolicy? PolicyAgreementAcceptanceGroup_PrivacyPolicy { get; set; }

    public DefaultAgreement? PolicyAgreementAcceptanceGroup_DefaultAgreement { get; set; }

    public OrganizationBusinessUnitAgreement? PolicyAgreementAcceptanceGroup_OrganizationBusinessUnitAgreement { get; set; }

    public UserGroup? PolicyAgreementAcceptanceGroup_UserGroup { get; set; }
}
