namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the percentage of ownership a specific applicant or company holds in various non-real estate assets within a loan application.
/// </summary>
public class NonRealEstateAssetOwnershipPercentage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the applicant identifier associated with this asset ownership record.
    /// </summary>
    public int? NonRealEstateAssetOwnershipPercentage_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the motor vehicle asset identifier linked to this ownership record.
    /// </summary>
    public int? NonRealEstateAssetOwnershipPercentage_MotorVehicleID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for another (non-vehicle, non-real estate) asset linked to this record.
    /// </summary>
    public int? NonRealEstateAssetOwnershipPercentage_OtherAssetID { get; set; }

    /// <summary>
    /// Gets or sets the superannuation fund asset identifier linked to this ownership record.
    /// </summary>
    public int? NonRealEstateAssetOwnershipPercentage_SuperannuationFundID { get; set; }

    /// <summary>
    /// Gets or sets the saving and term deposit account asset identifier linked to this ownership record.
    /// </summary>
    public int? NonRealEstateAssetOwnershipPercentage_SavingAndTermDepositAccountID { get; set; }

    /// <summary>
    /// Gets or sets the company applicant identifier associated with this asset ownership record.
    /// </summary>
    public int? NonRealEstateAssetOwnershipPercentage_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the trust identifier associated with this asset ownership record.
    /// </summary>
    public int? NonRealEstateAssetOwnershipPercentage_TrustID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the type of proportion share from the general lookup table.
    /// </summary>
    public int? ProportionShareType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the percentage share of the asset owned by the applicant or company.
    /// </summary>
    public double? PercentShared { get; set; }

    /// <summary>
    /// Gets or sets an extra custom field for additional information regarding the ownership record.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra custom field for additional information regarding the ownership record.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra custom field for additional information regarding the ownership record.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the related saving and term deposit account entity for this ownership record.
    /// </summary>
    public SavingAndTermDepositAccount? NonRealEstateAssetOwnershipPercentage_SavingAndTermDepositAccount { get; set; }

    /// <summary>
    /// Gets or sets the related motor vehicle entity for this ownership record.
    /// </summary>
    public MotorVehicle? NonRealEstateAssetOwnershipPercentage_MotorVehicle { get; set; }

    /// <summary>
    /// Gets or sets the related other asset entity for this ownership record.
    /// </summary>
    public OtherAsset? NonRealEstateAssetOwnershipPercentage_OtherAsset { get; set; }

    /// <summary>
    /// Gets or sets the related superannuation fund entity for this ownership record.
    /// </summary>
    public SuperannuationFund? NonRealEstateAssetOwnershipPercentage_SuperannuationFund { get; set; }

    /// <summary>
    /// Gets or sets the related applicant entity for this asset ownership record.
    /// </summary>
    public Applicant? NonRealEstateAssetOwnershipPercentage_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity for this asset ownership record.
    /// </summary>
    public CompanyApplicant? NonRealEstateAssetOwnershipPercentage_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the related trust entity for this asset ownership record.
    /// </summary>
    public Trust? NonRealEstateAssetOwnershipPercentage_Trust { get; set; }
}
