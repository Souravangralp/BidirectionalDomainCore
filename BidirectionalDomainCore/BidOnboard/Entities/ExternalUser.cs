namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class ExternalUser : BaseAuditableEntity
{
    public int? ExternalUser_OrganizationID { get; set; }

    public int? ExternalUser_BusinessUnitID { get; set; }

    public int? ExternalUser_UserID { get; set; }

    public int? ExternalUserType_CoreDB_GeneralLookUpID { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public Organization? ExternalUser_Organization { get; set; }

    public BusinessUnit? ExternalUser_BusinessUnit { get; set; }

    public User? ExternalUser_User { get; set; }
}
