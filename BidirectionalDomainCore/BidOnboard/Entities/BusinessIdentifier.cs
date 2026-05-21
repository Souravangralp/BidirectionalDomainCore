using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Represents a set of business identifiers and related information for an organization or business unit.
/// </summary>
public class BusinessIdentifier : BaseAuditableEntity
{
    public int? BusinessIdentifier_BusinessDetailID { get; set; }

    public int? BusinessIdentifier_UserID { get; set; }

    public int? ABNStatusType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related organization.
    /// </summary>
    public int? BusinessIdentifier_OrganizationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related trust applicant.
    /// </summary>
    public int? BusinessIdentifier_TrustID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related company applicant.
    /// </summary>
    public int? BusinessIdentifier_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related business unit.
    /// </summary>
    public int? BusinessIdentifier_BusinessUnitID { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN).
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Company Number (ACN).
    /// </summary>
    public string? ACN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Credit Licence (ACL) number.
    /// </summary>
    public string? ACL { get; set; }

    /// <summary>
    /// Gets or sets the GST number.
    /// </summary>
    public string? GST { get; set; }

    /// <summary>
    /// Gets or sets the TFN number.
    /// </summary>
    public string? TFN { get; set; }

    /// <summary>
    /// Gets or sets the related organization entity.
    /// </summary>
    public Organization? BusinessIdentifier_Organization { get; set; }

    /// <summary>
    /// Gets or sets the related trust entity.
    /// </summary>
    public Trust? BusinessIdentifier_Trust { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity.
    /// </summary>
    public CompanyApplicant? BusinessIdentifier_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the related business unit entity.
    /// </summary>
    public BusinessUnit? BusinessIdentifier_BusinessUnit { get; set; }

    public DateTime? ABNEffectiveFrom { get; set; }

    public DateTime? ABNEffectiveTo { get; set; }

    public int? ACNStatusType_CoreDB_GeneralLookUpID { get; set; }

    public DateTime? ACNEffectiveFrom { get; set; }

    public DateTime? ACNEffectiveTo { get; set; }

    public DateTime? ACLIssueDate { get; set; }

    public DateTime? ACLExpiryDate { get; set; }

    public BusinessDetail? BusinessIdentifier_BusinessDetail { get; set; }

    public User? BusinessIdentifier_User { get; set; }
}
