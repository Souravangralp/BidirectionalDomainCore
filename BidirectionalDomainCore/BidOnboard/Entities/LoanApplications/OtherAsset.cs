using Bidirectional.DomainCore.BidOnboard.Enums;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an asset other than real estate associated with a loan application, including its financial and ownership details.
/// </summary>
public class OtherAsset : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the monetary value of the asset.
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or sets the asset type from the general lookup table.
    /// </summary>
    public int? OtherAssetType_GeneralLookUpID { get; set; } // We are Getting this from general look Up table ( need to seed data for this )

    public int? OtherLoanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the security status of the asset.
    /// </summary>
    public AssetSecurityStatus AssetSecurityStatus { get; set; }

    /// <summary>
    /// Gets or sets the origin of the asset.
    /// </summary>
    public AssetOrigin AssetOrigin { get; set; }

    /// <summary>
    /// Gets or sets the refinancing status of the property tied to the asset.
    /// </summary>
    public PropertyRefinanceStatus RefinancingStatus { get; set; }

    /// <summary>
    /// Gets or sets the type or category of the asset.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the asset is to be used as security for the loan.
    /// </summary>
    public bool ISToBeUsedAsSecurity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the asset is intended to be sold.
    /// </summary>
    public bool ISToBeSold { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a contract of sale for the asset.
    /// </summary>
    public bool ISContractOfSale { get; set; }

    /// <summary>
    /// Gets or sets the basis or rationale for holding the asset.
    /// </summary>
    public string? Basis { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution associated with the asset.
    /// </summary>
    [Comment("Provider will be saved here")]
    public string? NameOfFinancialInstitution { get; set; }

    public string? AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of any other financial institution associated with the asset.
    /// </summary>
    public string? OtherFIName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether ownership of the asset is to be transferred to SMSF.
    /// </summary>
    public bool ISTransferOwnershipToSMSF { get; set; }

    /// <summary>
    /// Gets or sets the list of percent owners for non-real estate assets.
    /// </summary>
    public IList<NonRealEstateAssetOwnershipPercentage> NonRealEstateAssetOwnershipPercentages { get; set; } = new List<NonRealEstateAssetOwnershipPercentage>();

    /// <summary>
    /// Gets or sets the list of encumbered assets associated with this asset.
    /// </summary>
    public IList<EncumberedAsset> EncumberedAssets { get; set; } = new List<EncumberedAsset>();

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    public int OtherAsset_UserID { get; set; }

    public string? AssetType { get; set; } // e.g., Collectibles, Art, Jewellery, etc.

    public string? AssetName { get; set; } // e.g., Rolex Watch, Picasso Painting

    public string? Category { get; set; } // e.g., Electronics, Furniture, etc.

    public string? Address { get; set; } // e.g., where the asset is located

    public DateOnly? AcquiredDate { get; set; } // e.g., when the asset was acquired

    public string? OtherAssetTypeDescription { get; set; } // this is the description for the other general lookup type.

    public User? OtherAsset_User { get; set; }

    #region Remove fields

    /// <summary>
    /// Gets or sets the type of the asset. (Marked for removal)
    /// </summary>
    public string? TypeOfAsset { get; set; }

    /// <summary>
    /// Gets or sets the value of the asset. (Marked for removal)
    /// </summary>
    public double? ValueOfAsset { get; set; }

    /// <summary>
    /// Gets or sets the portion of the asset value to be used toward the transaction. (Marked for removal)
    /// </summary>
    public double? TowardsTransaction { get; set; }

    /// <summary>
    /// Gets or sets the length of time the savings have been held. (Marked for removal)
    /// </summary>
    public int? LengthOfSavings { get; set; }

    /// <summary>
    /// Gets or sets the collection the asset belongs to. (Marked for removal)
    /// </summary>
    public string? Collection { get; set; }

    #endregion
}
