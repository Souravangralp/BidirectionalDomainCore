namespace Bidirectional.DomainCore.BidOnboard.Entities.Agreement;

public class AgreementComment : BaseAuditableEntity
{
    public int? AgreementComment_UserID { get; set; }

    public int? AgreementComment_OrganizationBusinessUnitAgreementID { get; set; }

    public string? SelectedText { get; set; }

    public string? Comment { get; set; }

    public OrganizationBusinessUnitAgreement? AgreementComment_OrganizationBusinessUnitAgreement { get; set; }

    public User? AgreementComment_User { get; set; }
}
