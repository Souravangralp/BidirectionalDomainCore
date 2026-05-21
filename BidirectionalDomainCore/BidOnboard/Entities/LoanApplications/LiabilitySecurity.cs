namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a security associated with a liability in a loan application, capturing links to mortgagors,
/// applicants, real estate assets, and company applicants that secure a liability.
/// </summary>
public class LiabilitySecurity : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated liability.
    /// </summary>
    public int? LiabilitySecurity_LiabilityID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the applicant related to this liability security.
    /// </summary>
    public int? LiabilitySecurity_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the real estate asset used as security.
    /// </summary>
    public int? LiabilitySecurity_RealEstateAssetID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the company applicant associated with the liability security.
    /// </summary>
    public int? LiabilitySecurity_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the mortgagor.
    /// </summary>
    public string? MortgagorUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the security asset.
    /// </summary>
    public string? SecurityAssetUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the related liability entity for this security.
    /// </summary>
    public Liability? LiabilitySecurity_Liability { get; set; }

    /// <summary>
    /// Gets or sets the applicant entity associated with this liability security.
    /// </summary>
    public Applicant? LiabilitySecurity_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the company applicant entity related to this liability security.
    /// </summary>
    public CompanyApplicant? LiabilitySecurity_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the real estate asset used as security for this liability.
    /// </summary>
    public RealEstateAsset? LiabilitySecurity_RealEstateAsset { get; set; }
}
