namespace Bidirectional.DomainCore.BidOnboard.Entities.Agreement;

public class OrganizationBusinessUnitAgreement : BaseAuditableEntity
{
    public int? OrganizationBusinessUnitAgreement_UserID { get; set; } // this is the user who will update the existing document.

    public int? OrganizationBusinessUnitAgreement_AssignedUserID { get; set; } // this is the user who will sign the agreement in case of broker referer with target entity type User.

    public int? OrganizationBusinessUnitAgreement_OrganizationID { get; set; }

    public int? OrganizationBusinessUnitAgreement_BusinessUnitID { get; set; }

    public AgreementTypes AgreementType { get; set; }

    public TargetEntityTypes TargetEntityType { get; set; } // It will have only 3 values:Company, Branch, Aggregator, User.

    public string? AgreementDescription { get; set; }

    public string? AgreementURL { get; set; }

    public string? HtmlContent { get; set; }

    public string? Version { get; set; }

    public Organization? OrganizationBusinessUnitAgreement_Organization { get; set; }

    public BusinessUnit? OrganizationBusinessUnitAgreement_BusinessUnit { get; set; }

    public User? OrganizationBusinessUnitAgreement_User { get; set; }

    public User? OrganizationBusinessUnitAgreement_AssignedUser { get; set; }

    public AcceptedAgreementDetail? AcceptedAgreementDetails { get; set; }

    public ICollection<AgreementComment> AgreementComments { get; set; } = [];
}
