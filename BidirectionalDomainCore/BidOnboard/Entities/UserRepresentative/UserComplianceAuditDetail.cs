namespace Bidirectional.DomainCore.BidOnboard.Entities.UserRepresentative;

public class UserComplianceAuditDetail : BaseAuditableEntity
{
    public int? UserComplianceAuditDetail_UserRepresentativeReferenceID { get; set; }

    public DateOnly? DateOfComplianceAndAudit { get; set; }

    public string? ComplianceAndAuditOutcomeDetails { get; set; }

    public string? RemedialActionsTaken { get; set; }

    public UserRepresentativeReference? UserComplianceAuditDetail_UserRepresentativeReference { get; set; }
}
