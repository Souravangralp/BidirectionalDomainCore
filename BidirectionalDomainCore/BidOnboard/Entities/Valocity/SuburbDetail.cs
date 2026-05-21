namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents the detailed information and statistics for a suburb, including demographic data, property stock, market metrics, and related property entity.
/// </summary>
public class SuburbDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related property detail entity for this suburb.
    /// </summary>
    public int? SuburbDetail_PropertyDetailID { get; set; }

    /// <summary>
    /// Gets or sets the unique code representing the suburb.
    /// </summary>
    public string? SuburbCode { get; set; }

    /// <summary>
    /// Gets or sets the name of the suburb.
    /// </summary>
    public string? SuburbName { get; set; }

    /// <summary>
    /// Gets or sets the state or region where the suburb is located.
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Gets or sets the lower extreme quartile value, typically used in property price analytics.
    /// </summary>
    public int? LowerExtremeQuartile { get; set; }

    /// <summary>
    /// Gets or sets the lower quartile value for property prices in the suburb.
    /// </summary>
    public int? LowerQuartile { get; set; }

    /// <summary>
    /// Gets or sets the median quartile value for property prices in the suburb.
    /// </summary>
    public int? MedianQuartile { get; set; }

    /// <summary>
    /// Gets or sets the upper quartile value for property prices in the suburb.
    /// </summary>
    public int? UpperQuartile { get; set; }

    /// <summary>
    /// Gets or sets the upper extreme quartile value for property prices in the suburb.
    /// </summary>
    public int? UpperExtremeQuartile { get; set; }

    /// <summary>
    /// Gets or sets the median sale price of units in the last quarter.
    /// </summary>
    public int? UnitMedianSalePriceLastQuarter { get; set; }

    /// <summary>
    /// Gets or sets the median sale price of units in the current quarter.
    /// </summary>
    public int? UnitMedianSalePriceThisQuarter { get; set; }

    /// <summary>
    /// Gets or sets the percentage change in the median sale price of units compared to the previous quarter.
    /// </summary>
    public double? UnitMedianSalePriceChangePercentage { get; set; }

    /// <summary>
    /// Gets or sets the median sale price of houses in the last quarter.
    /// </summary>
    public int? HouseMedianSalePriceLastQuarter { get; set; }

    /// <summary>
    /// Gets or sets the median sale price of houses in the current quarter.
    /// </summary>
    public int? HouseMedianSalePriceThisQuarter { get; set; }

    /// <summary>
    /// Gets or sets the percentage change in the median sale price of houses compared to the previous quarter.
    /// </summary>
    public double? HouseMedianSalePriceChangePercentage { get; set; }

    /// <summary>
    /// Gets or sets the count of unit stock in the suburb.
    /// </summary>
    public int? UnitStockUnitCount { get; set; }

    /// <summary>
    /// Gets or sets the percentage that unit stock represents out of all properties.
    /// </summary>
    public double? UnitStockUnitCountPercentage { get; set; }

    /// <summary>
    /// Gets or sets the count of house stock in the suburb.
    /// </summary>
    public int? HouseStockHouseCount { get; set; }

    /// <summary>
    /// Gets or sets the percentage that house stock represents out of all properties.
    /// </summary>
    public double? HouseStockHouseCountPercentage { get; set; }

    /// <summary>
    /// Gets or sets the total number of properties in the suburb.
    /// </summary>
    public int? PropertyStockTotalCount { get; set; }

    /// <summary>
    /// Gets or sets the area of the suburb in square kilometers.
    /// </summary>
    public string? AreaSquareKiloMeter { get; set; }

    /// <summary>
    /// Gets or sets the population of the suburb.
    /// </summary>
    public int? Population { get; set; }

    /// <summary>
    /// Gets or sets the median age of the suburb's residents.
    /// </summary>
    public int? MedianAge { get; set; }

    /// <summary>
    /// Gets or sets the predominant age group in the suburb.
    /// </summary>
    public string? PredominantAgeGroup { get; set; }

    /// <summary>
    /// Gets or sets the primary type of household in the suburb.
    /// </summary>
    public string? PrimaryHouseholdType { get; set; }

    /// <summary>
    /// Gets or sets the percentage of owner-occupied dwellings in the suburb.
    /// </summary>
    public int? OwnerOccupiedPercentage { get; set; }

    /// <summary>
    /// Gets or sets the median monthly mortgage payment for households in the suburb.
    /// </summary>
    public int? MedianMortgageMonthly { get; set; }

    /// <summary>
    /// Gets or sets the median weekly rent in the suburb.
    /// </summary>
    public int? MedianRentWeekly { get; set; }

    /// <summary>
    /// Gets or sets the average size of households in the suburb.
    /// </summary>
    public int? HouseholdAverageSize { get; set; }

    /// <summary>
    /// Gets or sets the median income of households in the suburb.
    /// </summary>
    public int? MedianHouseholdIncome { get; set; }

    /// <summary>
    /// Gets or sets the total number of houses in the suburb.
    /// </summary>
    public int? TotalNumberOfHouses { get; set; }

    /// <summary>
    /// Gets or sets the total number of units in the suburb.
    /// </summary>
    public int? TotalNumberOfUnits { get; set; }

    /// <summary>
    /// Gets or sets the number of new home listings in the suburb.
    /// </summary>
    public int? NumberOfNewHomeListings { get; set; }

    /// <summary>
    /// Gets or sets the number of new unit listings in the suburb.
    /// </summary>
    public int? NumberOfNewUnitListings { get; set; }

    /// <summary>
    /// Gets or sets the total number of house listings in the suburb.
    /// </summary>
    public int? TotalNumberOfHousesListings { get; set; }

    /// <summary>
    /// Gets or sets the total number of unit listings in the suburb.
    /// </summary>
    public int? TotalNumberOfUnitsListing { get; set; }

    /// <summary>
    /// Gets or sets the median sale price for houses in the suburb.
    /// </summary>
    public int? HouseMediumSalePrice { get; set; }

    /// <summary>
    /// Gets or sets the median sale price for units in the suburb.
    /// </summary>
    public int? UnitMediumSalePrice { get; set; }

    /// <summary>
    /// Gets or sets the number of unit listings over the last 12 months.
    /// </summary>
    public int? UnitLast12MonthsListingsDwellingCount { get; set; }

    /// <summary>
    /// Gets or sets the median value of unit listings over the last 12 months.
    /// </summary>
    public int? UnitLast12MonthsListingsMedianValue { get; set; }

    /// <summary>
    /// Gets or sets the number of active unit listings currently available.
    /// </summary>
    public int? UnitCurrentActiveListingCount { get; set; }

    /// <summary>
    /// Gets or sets the number of unit listings over the last 4 months.
    /// </summary>
    public int? UnitLast4MonthsListingsDwellingCount { get; set; }

    /// <summary>
    /// Gets or sets the number of house listings over the last 12 months.
    /// </summary>
    public int? HouseLast12MonthsListingsDwellingCount { get; set; }

    /// <summary>
    /// Gets or sets the median value of house listings over the last 12 months.
    /// </summary>
    public int? HouseLast12MonthsListingsMedianValue { get; set; }

    /// <summary>
    /// Gets or sets the number of active house listings currently available.
    /// </summary>
    public int? HouseCurrentActiveListingCount { get; set; }

    /// <summary>
    /// Gets or sets the number of house listings over the last 4 months.
    /// </summary>
    public int? HouseLast4MonthsListingsDwellingCount { get; set; }

    /// <summary>
    /// Gets or sets the URI of the image representing the suburb.
    /// </summary>
    public string? SuburbImageUri { get; set; }

    /// <summary>
    /// Gets or sets the caption for the suburb image.
    /// </summary>
    public string? SuburbImageCaption { get; set; }

    /// <summary>
    /// Gets or sets the related property detail entity for the suburb.
    /// </summary>
    public PropertyDetail? SuburbDetail_PropertyDetail { get; set; }
}
