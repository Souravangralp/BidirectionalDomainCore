namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BookingBusiness : BaseAuditableEntity
{
    public int? BookingBusiness_OrganizationID { get; set; }

    public int? BookingBusiness_BusinessUnitID { get; set; }

    public string? BookingBusinessID { get; set; }

    public string? DefaultDisplayName { get; set; }

    public Organization? BookingBusiness_Organization { get; set; }

    public BusinessUnit? BookingBusiness_BusinessUnit { get; set; }
}
