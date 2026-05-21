using Bidirectional.DomainCore.BidOnboard.Entities.UserRepresentative;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class EmailDetail : BaseAuditableEntity
{
    public int? EmailType_CoreDB_GeneralLookUpID { get; set; }

    public int? EmailDetail_UserID { get; set; }

    public int? EmailDetail_BusinessDetailID { get; set; }

    public int? EmailDetail_BusinessUnitID { get; set; }

    public int? EmailDetail_OrganizationID { get; set; }

    public int? EmailDetail_RefereeID { get; set; }

    public int? EmailDetail_BranchEnquiryID { get; set; }

    public int? EmailDetail_BankDetailID { get; set; }

    public int? EmailDetail_UserRepresentativeReferenceID { get; set; }

    public string? Email { get; set; }

    public string? CountryCode { get; set; }

    public bool ISPrimary { get; set; }

    public bool ISNotificationEnabled { get; set; }

    public bool ISVerified { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? VerifiedAt { get; set; }

    // Navigation properties
    public User? EmailDetail_User { get; set; }

    public BusinessDetail? EmailDetail_BusinessDetail { get; set; }

    public BusinessUnit? EmailDetail_BusinessUnit { get; set; }

    public Organization? EmailDetail_Organization { get; set; }

    public Referee? EmailDetail_Referee { get; set; }

    public BankDetail? EmailDetail_BankDetail { get; set; }

    public UserRepresentativeReference? EmailDetail_UserRepresentativeReference { get; set; }
}
