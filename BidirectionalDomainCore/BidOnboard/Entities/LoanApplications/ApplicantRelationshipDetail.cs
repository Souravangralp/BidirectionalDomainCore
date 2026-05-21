namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

public class ApplicantRelationshipDetail : BaseAuditableEntity
{
    public int? ApplicantRelationshipDetail_ApplicantID { get; set; }

    public int? RelatedToApplicantID { get; set; }

    public bool ISRelatedToApplicant { get; set; } // Applicant vs Non-applicant

    public string? RelatedPersonName { get; set; } // for non-applicant

    public Applicant? ApplicantRelationshipDetail_Applicant { get; set; }

    public Applicant? RelatedToApplicant { get; set; }
}
