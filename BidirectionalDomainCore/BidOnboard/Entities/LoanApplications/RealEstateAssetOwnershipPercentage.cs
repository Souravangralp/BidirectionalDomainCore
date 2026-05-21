namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the percentage ownership details for an applicant or company in a specific real estate asset within a loan application.
/// </summary>
public class RealEstateAssetOwnershipPercentage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated real estate asset.
    /// </summary>
    public int? RealEstateAssetOwnershipPercentage_RealEstateAssetID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the applicant linked to this ownership record.
    /// </summary>
    public int? RealEstateAssetOwnershipPercentage_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the company applicant linked to this real estate asset ownership.
    /// </summary>
    public int? RealEstateAssetOwnershipPercentage_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the trust linked to this real estate asset ownership.
    /// </summary>
    public int? RealEstateAssetOwnershipPercentage_TrustID { get; set; }

    /// <summary>
    /// Gets or sets the name of the registered owner.
    /// </summary>
    public string? RegisteredOwner { get; set; }

    /// <summary>
    /// Gets or sets the textual representation of the ownership proportion.
    /// </summary>
    public string? Proportion { get; set; }

    /// <summary>
    /// Gets or sets the percentage share owned by the applicant or company.
    /// </summary>
    public double? PercentShared { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the party associated with this record.
    /// </summary>
    public string? PartyUniqueID { get; set; }

    /// <summary>
    /// Gets or sets an additional custom field for storing extra information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets another additional custom field for supplementary information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets a third additional custom field for extra details.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity for this ownership record.
    /// </summary>
    public CompanyApplicant? RealEstateAssetOwnershipPercentage_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the related applicant entity for this ownership record.
    /// </summary>
    public Applicant? RealEstateAssetOwnershipPercentage_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the related trust entity for this ownership record.
    /// </summary>
    public Trust? RealEstateAssetOwnershipPercentage_Trust { get; set; }

    /// <summary>
    /// Gets or sets the related real estate asset entity for this ownership record.
    /// </summary>
    public RealEstateAsset? RealEstateAssetOwnershipPercentage_RealEstateAsset { get; set; }
}
