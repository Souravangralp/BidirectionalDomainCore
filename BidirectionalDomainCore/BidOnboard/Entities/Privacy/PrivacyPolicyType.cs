namespace Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

public class PrivacyPolicyType : BaseAuditableEntity
{
    public string? Name { get; set; }

    public string? PolicyType { get; set; }

    public int? ComplianceType_CoreDB_GeneralLookUpID { get; set; }
}
