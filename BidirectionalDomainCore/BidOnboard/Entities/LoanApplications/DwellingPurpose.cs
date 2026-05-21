namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Encapsulates details regarding the purpose of a dwelling in the context of a loan application, including dwelling type, occupancy, investment purpose, rental income, and associated dwelling features.
/// </summary>
public class DwellingPurpose : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the real estate asset associated with this dwelling purpose.
    /// </summary>
    public int? DwellingPurpose_RealEstateAssetID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the owner-occupied dwelling type.
    /// </summary>
    public int? OwnerOccupiedDwellingType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a textual description for dwelling purposes not covered by standard categories.
    /// </summary>
    public string? OtherDwellingPurpose { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the investment dwelling type.
    /// </summary>
    public int? InvestmentDwellingType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the amount of rental income associated with the dwelling.
    /// </summary>
    public double? RentalIncome { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier representing the frequency type of the rental income.
    /// </summary>
    public int? RentalIncomeFrequencyType_GeneralLookUpID { get; set; } // We will get this from General Lookup

    // May be, in future we need to remove below 6 fields from RealEstateAsset table, if we use it from DwellingPurpose table, as it is only related to dwelling purpose.

    /// <summary>
    /// Gets or sets the total number of dwellings included.
    /// </summary>
    public int? DwellingCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bedrooms in the dwelling.
    /// </summary>
    public int? BedroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bathrooms in the dwelling.
    /// </summary>
    public int? BathroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of garages in the dwelling.
    /// </summary>
    public int? GarageCount { get; set; }

    /// <summary>
    /// Gets or sets the number of levels in the dwelling.
    /// </summary>
    public int? LevelCount { get; set; }

    /// <summary>
    /// Gets or sets the size of the living area in the dwelling.
    /// </summary>
    public double? LivingAreaSize { get; set; }

    /// <summary>
    /// Gets or sets the related dwelling purpose real estate asset entity.
    /// </summary>
    public DwellingPurpose? DwellingPurpose_RealEstateAsset { get; set; }
}
