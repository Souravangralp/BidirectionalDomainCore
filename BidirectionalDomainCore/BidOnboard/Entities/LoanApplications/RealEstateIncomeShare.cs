namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a share of real estate income associated with a loan application, detailing the division of ownership and associated parties.
/// </summary>
public class RealEstateIncomeShare : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the related real estate asset.
    /// </summary>
    public int? RealEstateIncomeShare_RealEstateAssetID { get; set; }

    /// <summary>
    /// Gets or sets the ID of the associated applicant.
    /// </summary>
    public int? RealEstateIncomeShare_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the ID of the associated company applicant.
    /// </summary>
    public int? RealEstateIncomeShare_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the registered owner of the real estate income share.
    /// </summary>
    public string? RegisteredOwner { get; set; }

    /// <summary>
    /// Gets or sets the proportion of real estate income shared.
    /// </summary>
    public string? Proportion { get; set; }

    /// <summary>
    /// Gets or sets the percentage of income shared from the real estate asset.
    /// </summary>
    public double? PercentShared { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the involved party.
    /// </summary>
    public string? PartyUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the value of the first extra field for extended data.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets the value of the second extra field for extended data.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets the value of the third extra field for extended data.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity.
    /// </summary>
    public CompanyApplicant? RealEstateIncomeShare_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the related applicant entity.
    /// </summary>
    public Applicant? RealEstateIncomeShare_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the related real estate asset entity.
    /// </summary>
    public RealEstateAsset? RealEstateIncomeShare_RealEstateAsset { get; set; }
}
