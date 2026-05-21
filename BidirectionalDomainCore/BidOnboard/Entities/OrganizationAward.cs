namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class OrganizationAward : BaseAuditableEntity
{
    public int? OrganizationAward_OrganizationID { get; set; }

    public int? AwardType_CoreDB_GeneralLookUpID { get; set; }

    public string? OtherAwardType { get; set; }

    public DateTime? AwardDate { get; set; }

    public string? CertificateUrl { get; set; }

    public Organization? OrganizationAward_Organization { get; set; }
}
