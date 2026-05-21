using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class Passport : BaseAuditableEntity
{
    public int Passport_UserID { get; set; }

    public int? Passport_ApplicantID { get; set; }

    [EncryptColumn]
    public string? PassportNumber { get; set; }

    public string? IssuingCountry { get; set; }

    public DateOnly IssueDate { get; set; }

    public DateOnly ExpiryDate { get; set; }

    public string? PlaceOfBirth { get; set; }

    [EncryptColumn]
    public string? FileNumber { get; set; } // Unique file reference number

    public int? PassportType_CoreDB_GeneralLookUpID { get; set; } // e.g., Regular, Diplomatic, Official

    public string? Authority { get; set; } // Issuing authority (e.g., Ministry of External Affairs)

    public string? PersonalNumber { get; set; } // Some countries have an additional ID

    public bool HasVisaStamps { get; set; } // Indicates if the passport has visas/stamps

    public bool HASAustralianPassport { get; set; }

    [Comment("Passport issued in which State")]
    public int? PassportIssuedStateID { get; set; }

    [Comment("Passport Issued in which country")]
    public int? PassportIssuedCountryID { get; set; }

    [EncryptColumn]
    [Comment("Client asked us to make provision for this field")]
    public string? PassportUniqueNumber { get; set; }

    [EncryptColumn]
    public string? PassportExpiring { get; set; }

    public User? Passport_User { get; set; } // List of visa stamps

    public Applicant? Passport_Applicant { get; set; }
}
