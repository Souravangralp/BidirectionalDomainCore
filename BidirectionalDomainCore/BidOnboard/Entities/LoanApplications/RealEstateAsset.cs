using Bidirectional.DomainCore.BidOnboard.Enums;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a real estate asset associated with a loan application, including property details, financial data, ownership, and related asset information.
/// </summary>
public class RealEstateAsset : BaseAuditableEntity
{
    public int RealEstateAsset_UserID { get; set; }

    /// <summary>
    /// Gets or sets the property type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? PropertyType_GeneralLookUpID { get; set; }

    public int? OwnershipType_GeneralLookUpID { get; set; } // e.g., Sole, Joint

    /// <summary>
    /// Gets or sets the council zoning type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? CouncilZoningType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is approval in principle for this asset.
    /// </summary>
    public bool HASApprovalInPrinciple { get; set; }

    /// <summary>
    /// Gets or sets the status of the property's security as an asset.
    /// </summary>
    public AssetSecurityStatus PropertyStatus { get; set; }

    /// <summary>
    /// Gets or sets the origin of the asset.
    /// </summary>
    public AssetOrigin AssetOrigin { get; set; }

    /// <summary>
    /// Gets or sets the refinancing status of the property.
    /// </summary>
    public PropertyRefinanceStatus RefinancingStatus { get; set; }

    /// <summary>
    /// Gets or sets the occupancy type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? OccupancyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the investment amount for the asset.
    /// </summary>
    public double? InvestmentAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is classified as field type.
    /// </summary>
    public bool ISFieldType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is tax deductible.
    /// </summary>
    public bool ISTaxDeductable { get; set; }

    /// <summary>
    /// Gets or sets the tax amount associated with the asset.
    /// </summary>
    public double? TaxAmount { get; set; }

    /// <summary>
    /// Gets or sets the title type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? TitleType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the land size of the property.
    /// </summary>
    public double? LandSize { get; set; }

    /// <summary>
    /// Gets or sets the calculated land size of the property.
    /// </summary>
    public double? CalculatedLandSize { get; set; }

    /// <summary>
    /// Gets or sets the area measurement type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? AreaMeasurementType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the total dwelling count in the property.
    /// </summary>
    public int? DwellingCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bedrooms in the property.
    /// </summary>
    public int? BedroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bathrooms in the property.
    /// </summary>
    public int? BathroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of garages in the property.
    /// </summary>
    public int? GarageCount { get; set; }

    /// <summary>
    /// Gets or sets the number of levels in the property.
    /// </summary>
    public int? LevelCount { get; set; }

    /// <summary>
    /// Gets or sets the size of the living area in the property.
    /// </summary>
    public double? LivingAreaSize { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is consent to a second mortgage.
    /// </summary>
    public bool? ISConsentToSecondMortgage { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a market transaction associated with the property.
    /// </summary>
    public bool HASMarketTransaction { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is legal representation for the property.
    /// </summary>
    public bool HASLegalRepresentation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is for contract of sale.
    /// </summary>
    public bool ForContractOfSale { get; set; }

    /// <summary>
    /// Gets or sets the primary usage description of the property.
    /// </summary>
    public string? PrimaryUsage { get; set; }

    /// <summary>
    /// Gets or sets the current status of the property.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is to be sold.
    /// </summary>
    public bool ISToBeSold { get; set; }

    /// <summary>
    /// Gets or sets the transaction details for the property.
    /// </summary>
    public string? Transaction { get; set; }

    /// <summary>
    /// Gets or sets information about who is holding the property.
    /// </summary>
    public string? Holding { get; set; }

    /// <summary>
    /// Gets or sets the estimated value of the property.
    /// </summary>
    public double? EstimatedValue { get; set; }

    /// <summary>
    /// Gets or sets the basis on which the estimated value was determined.
    /// </summary>
    public string? EstimatedBasis { get; set; }

    /// <summary>
    /// Gets or sets the property amount (e.g., value or related amount).
    /// </summary>
    public double? PropertyAmount { get; set; }

    /// <summary>
    /// Gets or sets the property frequency type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? PropertyFrequencyType_GeneralLookUpID { get; set; } // We will get this from General Lookup

    /// <summary>
    /// Gets or sets a value indicating whether evidence of tenancy exists for the property.
    /// </summary>
    public bool HASEvidenceOfTenancy { get; set; }

    /// <summary>
    /// Gets or sets the rental income generated by the property.
    /// </summary>
    public double? RentalIncome { get; set; }

    /// <summary>
    /// Gets or sets the rental income frequency type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? RentalIncomeFrequencyType_GeneralLookUpID { get; set; } // We will get this from General Lookup

    /// <summary>
    /// Gets or sets a value indicating whether rental income is shared.
    /// </summary>
    public bool? ISRentalIncomeShared { get; set; }

    /// <summary>
    /// Gets or sets the shared rental income type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? SharedRentalIncomeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the description for other types of shared rental income.
    /// </summary>
    public string? OtherSharedRentalIncomeType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether at least 25% of the complex will be owned.
    /// </summary>
    public bool WillOwn25PercentOfComplex { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether at least 3 units in the complex will be owned.
    /// </summary>
    public bool WillOwn3UnitsInComplex { get; set; }

    /// <summary>
    /// Gets or sets the visit contact type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? VisitContactType_GeneralLookUpID { get; set; } // We will get this from General Lookup

    /// <summary>
    /// Gets or sets the zoning type lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? ZoningType_GeneralLookUpID { get; set; } // We will get this from GeneralLookUp

    /// <summary>
    /// Gets or sets the boundary easement lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? BoundaryEasement_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the folio number for the property's title.
    /// </summary>
    public double? Folio { get; set; }

    /// <summary>
    /// Gets or sets the lot number of the property.
    /// </summary>
    public double? Lot { get; set; }

    /// <summary>
    /// Gets or sets the plan reference for the property.
    /// </summary>
    public string? Plan { get; set; }

    /// <summary>
    /// Gets or sets the tenure type of the property.
    /// </summary>
    public string? TenureType { get; set; }

    /// <summary>
    /// Gets or sets the title system associated with the property.
    /// </summary>
    public string? TitleSystem { get; set; }

    /// <summary>
    /// Gets or sets the volume of the property (from title details).
    /// </summary>
    public double? Volume { get; set; }

    /// <summary>
    /// Gets or sets the real estate asset lookup ID from the CoreDB General Lookup.
    /// </summary>
    public int? RealEstateAsset_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the description for other types of real estate assets.
    /// </summary>
    public string? OtherRealEstateAsset { get; set; }

    /// <summary>
    /// Gets or sets the name of the registered owner of the property.
    /// </summary>
    public string? RegisteredOwner { get; set; }

    /// <summary>
    /// Gets or sets the weekly rent amount received from the property.
    /// </summary>
    public double? WeeklyRent { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution related to the property.
    /// </summary>
    public string? NameOfFinancialInstitution { get; set; }

    /// <summary>
    /// Gets or sets the highest mortgage amount taken against the property.
    /// </summary>
    public double? HighestMortgage { get; set; }

    /// <summary>
    /// Gets or sets the first extra field for additional custom data.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets the second extra field for additional custom data.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets the third extra field for additional custom data.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the identifier relating to the usage type of the mortgaged property from the General Lookup table.
    /// </summary>
    public int? UsageType_GeneralLookupID { get; set; }

    public string? AnnualDepreciation { get; set; }

    public string? FullAddress { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public double PurchasePrice { get; set; }

    public bool ISPrimaryResidence { get; set; }

    public string? OtherPropertyType { get; set; }

    public string? OtherOwnershipType { get; set; }

    public bool ISRented { get; set; }

    public double RentalIncomePerMonth { get; set; }

    public User? RealEstateAsset_User { get; set; }

    /// <summary>
    /// Gets or sets the address details associated with the property.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// Gets or sets the collection of percent owners linked to this real estate asset.
    /// </summary>
    public IList<RealEstateAssetOwnershipPercentage> RealEstateAssetOwnershipPercentages { get; set; } = new List<RealEstateAssetOwnershipPercentage>();

    /// <summary>
    /// Gets or sets the collection of income shares related to the real estate asset.
    /// </summary>
    public IList<RealEstateIncomeShare> RealEstateIncomeShares { get; set; } = new List<RealEstateIncomeShare>();

    /// <summary>
    /// Gets or sets the collection of encumbered assets related to this real estate asset.
    /// </summary>
    public IList<EncumberedAsset> EncumberedAssets { get; set; } = new List<EncumberedAsset>();

    /// <summary>
    /// Gets or sets the collection of loan securities in which the real estate asset is involved.
    /// </summary>
    public IList<LoanSecurity> LoanSecurities { get; set; } = new List<LoanSecurity>();

    /// <summary>
    /// Gets or sets the collection of purposes for which the dwelling is used.
    /// </summary>
    public IList<DwellingPurpose> DwellingPurposes { get; set; } = new List<DwellingPurpose>();
}
