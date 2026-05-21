using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents the details of a property, including its address, physical characteristics, valuation, sales history, and related entities.
/// </summary>
public class PropertyDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related address entity for this property.
    /// </summary>
    public int? PropertyDetail_AddressID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the property.
    /// </summary>
    public string? PropertyUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the number of bathrooms in the property.
    /// </summary>
    public int? Bathrooms { get; set; }

    /// <summary>
    /// Gets or sets the number of bedrooms in the property.
    /// </summary>
    public int? Bedrooms { get; set; }

    /// <summary>
    /// Gets or sets the number of car parks available at the property.
    /// </summary>
    public int? CarParks { get; set; }

    /// <summary>
    /// Gets or sets the total floor area of the property, in square meters.
    /// </summary>
    public double? FloorArea { get; set; }

    /// <summary>
    /// Gets or sets the full formatted address of the property.
    /// </summary>
    public string? FullAddress { get; set; }

    /// <summary>
    /// Gets or sets the total land area of the property, in square meters.
    /// </summary>
    public int? LandArea { get; set; }

    /// <summary>
    /// Gets or sets the description of the land use for the property.
    /// </summary>
    public string? LandUseDescription { get; set; }

    /// <summary>
    /// Gets or sets the zoning code for the land.
    /// </summary>
    public string? LandZoneCode { get; set; }

    /// <summary>
    /// Gets or sets the description of the land zoning.
    /// </summary>
    public string? LandZoneDescription { get; set; }

    /// <summary>
    /// Gets or sets the latitude coordinate of the property.
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the legal description of the property.
    /// </summary>
    public string? LegalDescription { get; set; }

    /// <summary>
    /// Gets or sets the longitude coordinate of the property.
    /// </summary>
    public double? Longitude { get; set; }

    /// <summary>
    /// Gets or sets the postcode of the property address.
    /// </summary>
    public string? PostCode { get; set; }

    /// <summary>
    /// Gets or sets the property code used for identification purposes.
    /// </summary>
    public string? PropertyCode { get; set; }

    /// <summary>
    /// Gets or sets the property type code.
    /// </summary>
    public string? PropertyTypeCode { get; set; }

    /// <summary>
    /// Gets or sets the state or region where the property is located.
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Gets or sets the suburb of the property.
    /// </summary>
    public string? Suburb { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the suburb.
    /// </summary>
    public string? SuburbUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the name of the territorial authority responsible for the property.
    /// </summary>
    public string? TerritorialAuthority { get; set; }

    /// <summary>
    /// Gets or sets the year the property was built.
    /// </summary>
    public int? YearBuilt { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the property was sold.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SaleDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the sale price of the property.
    /// </summary>
    public int? SalePrice { get; set; }

    /// <summary>
    /// Gets or sets the UTC settlement date for the property.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SettlementDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the associated suburb detail entity for this property.
    /// </summary>
    public SuburbDetail? SuburbDetails { get; set; }

    /// <summary>
    /// Gets or sets the associated suburb valuation detail entity for this property.
    /// </summary>
    public SuburbValuationDetail? SuburbValuationDetails { get; set; }

    /// <summary>
    /// Gets or sets the list of monthly details for the property's suburb.
    /// </summary>
    public IList<SuburbMonthlyDetail> SuburbMonthlyDetails { get; set; } = new List<SuburbMonthlyDetail>();

    /// <summary>
    /// Gets or sets the consumer estimate details for this property.
    /// </summary>
    public ConsumerEstimateDetail? ConsumerEstimateDetails { get; set; }

    /// <summary>
    /// Gets or sets the list of sales history details for the property.
    /// </summary>
    public IList<PropertySaleHistoryDetail> PropertySaleHistoryDetails { get; set; } = new List<PropertySaleHistoryDetail>();

    /// <summary>
    /// Gets or sets the list of local school details associated with the property.
    /// </summary>
    public IList<LocalSchoolDetail> LocalSchoolDetails { get; set; } = new List<LocalSchoolDetail>();

    /// <summary>
    /// Gets or sets the related address entity for this property.
    /// </summary>
    public Address? PropertyDetail_Address { get; set; }
}
// Image DTO is not being mapped as of now since we dont have any image data from address. while making schema
