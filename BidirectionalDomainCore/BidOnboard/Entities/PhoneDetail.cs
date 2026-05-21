using Bidirectional.DomainCore.BidOnboard.Entities.UserRepresentative;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class PhoneDetail : BaseAuditableEntity
{
    public int? PhoneType_CoreDB_GeneralLookUpID { get; set; }

    public int? PhoneDetail_UserID { get; set; }

    public int? PhoneDetail_BusinessDetailID { get; set; }

    public int? PhoneDetail_BusinessUnitID { get; set; }

    public int? PhoneDetail_OrganizationID { get; set; }

    public int? PhoneDetail_RefereeID { get; set; }

    public int? PhoneDetail_UserRepresentativeReferenceID { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CountryCode { get; set; }

    public bool ISPrimary { get; set; }

    public bool ISNotificationEnabled { get; set; }

    public bool ISVerified { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? VerifiedAt { get; set; }

    public User? PhoneDetail_User { get; set; }

    public BusinessDetail? PhoneDetail_BusinessDetail { get; set; }

    public BusinessUnit? PhoneDetail_BusinessUnit { get; set; }

    public Organization? PhoneDetail_Organization { get; set; }

    public Referee? PhoneDetail_Referee { get; set; }

    public UserRepresentativeReference? PhoneDetail_UserRepresentativeReference { get; set; }
}
