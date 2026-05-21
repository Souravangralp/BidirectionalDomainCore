using Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

namespace Bidirectional.DomainCore.BidOnboard.Entities.Agreement;

public class DefaultAgreement : BaseAuditableEntity
{
    public int? DefaultAgreement_UserID { get; set; }

    public int? DefaultAgreement_OrganizationID { get; set; }

    public int? DefaultAgreement_BusinessUnitID { get; set; }

    public AgreementTypes AgreementType { get; set; }

    public DomainEntityTypes ParentEntityType { get; set; } // this field is need for the default agreement where organizationID and businessUnitID is null

    public TargetEntityTypes TargetEntityType { get; set; }

    public string? AgreementDescription { get; set; }

    public string? AgreementURL { get; set; }

    public string? HtmlContent { get; set; }

    public string? Version { get; set; }

    public bool ISDefault { get; set; }

    public Organization? DefaultAgreement_Organization { get; set; }

    public BusinessUnit? DefaultAgreement_BusinessUnit { get; set; }

    public User? DefaultAgreement_User { get; set; }

    public List<PolicyAgreementAcceptanceGroup> DefaultAgreementAcceptanceGroups { get; set; } = [];
}
