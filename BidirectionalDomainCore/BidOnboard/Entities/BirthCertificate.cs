namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BirthCertificate : BaseAuditableEntity
{
    public int? BirthCertificate_UserID { get; set; }

    public string? CertificateNumber { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? IssuingAuthority { get; set; } // e.g., Government Agency

    public DateOnly IssueDate { get; set; }

    public string? RegistrationNumber { get; set; } // Unique registration number

    public User? BirthCertificate_User { get; set; }
}
