namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

public class FamilyRelation : BaseAuditableEntity
{
    public int? FamilyRelation_ApplicantID { get; set; }

    public string? MotherMaidenName { get; set; }

    public string? MothersSpouseFirstNameORChristianName { get; set; }

    public string? MothersSpouseLastNameORSurnameORFamilyName { get; set; }

    public int? NumberOfMaidenName { get; set; }

    public Applicant? FamilyRelation_Applicant { get; set; }
}
