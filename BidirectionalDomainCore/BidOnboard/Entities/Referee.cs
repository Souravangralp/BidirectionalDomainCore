namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class Referee : BaseAuditableEntity
{
    public int? Referee_BusinessUnitID { get; set; }

    public int? Referee_OrganizationID { get; set; }

    public string? Name { get; set; }

    public string? Company { get; set; }

    public string? Position { get; set; }

    public string? Relationship { get; set; }

    public int? OccupationType_CoreDB_GeneralLookUpID { get; set; }

    public string? OtherOccupation { get; set; }

    public Address? Address { get; set; }

    public EmailDetail? Email { get; set; }

    public PhoneDetail? Phone { get; set; }

    public BusinessUnit? Referee_BusinessUnit { get; set; }

    public Organization? Referee_Organization { get; set; }
}
