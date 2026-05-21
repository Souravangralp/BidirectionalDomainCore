namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessPartnerDetail : BaseAuditableEntity
{
    public int? BusinessPartnerDetails_OrganizationID { get; set; }

    public int? BusinessPartnerType_CoreDB_GeneralLookUpID { get; set; }

    public string? OtherBusinessPartner { get; set; }

    public string? BusinessPartnerName { get; set; }

    public string? NatureOfAlliance { get; set; }

    public int? EstablishedYear { get; set; }

    public Organization? Organization { get; set; }
}
