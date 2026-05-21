namespace Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

public class PrivacyPolicyCorrectionRequest : BaseAuditableEntity
{
    public int? PrivacyPolicyCorrectionRequest_ReviewedByUserID { get; set; }

    public int PrivacyPolicyCorrectionRequest_RequestedByUserID { get; set; }

    public int PrivacyPolicyCorrectionRequest_PrivacyPolicyID { get; set; }

    public int? PrivacyPolicyCorrectionRequest_OrganizationID { get; set; }

    public int? PrivacyPolicyCorrectionRequest_BusinessUnitID { get; set; }

    public string CorrectionReason { get; set; } = string.Empty;

    public string? ProposedHtmlContent { get; set; }

    public string? ProposedPolicyURL { get; set; }

    public string Status { get; set; } = "Pending"; // e.g. Pending, Approved, Rejected

    public DateTime? ReviewedOn { get; set; }

    public User? PrivacyPolicyCorrectionRequest_ReviewedByUser { get; set; }

    public User PrivacyPolicyCorrectionRequest_RequestedByUser { get; set; } = null!;

    public BusinessUnit? PrivacyPolicyCorrectionRequest_BusinessUnit { get; set; }

    public PrivacyPolicy PrivacyPolicyCorrectionRequest_PrivacyPolicy { get; set; } = null!;

    public Organization? PrivacyPolicyCorrectionRequest_Organization { get; set; }

    public string? ReviewNotes { get; set; }
}
