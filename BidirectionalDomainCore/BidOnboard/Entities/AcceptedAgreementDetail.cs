using Bidirectional.DomainCore.BidOnboard.Entities.Agreement;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class AcceptedAgreementDetail : BaseAuditableEntity
{
    public int? AcceptedAgreementDetail_OrganizationBusinessUnitAgreementID { get; set; }

    public string? Status { get; set; }

    public string? EnvelopeID { get; set; }

    public string? UserRequest { get; set; }

    public TargetEntityTypes TargetEntityType { get; set; }

    public List<EnvelopeUser> EnvelopeUser { get; set; } = [];

    public OrganizationBusinessUnitAgreement? AcceptedAgreementDetail_OrganizationBusinessUnitAgreement { get; set; }
}
