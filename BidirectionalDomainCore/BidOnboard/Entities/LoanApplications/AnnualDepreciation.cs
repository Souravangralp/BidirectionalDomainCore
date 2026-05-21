namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents annual depreciation details, including property counts, types, and related loan security information.
/// </summary>
public class AnnualDepreciation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related loan security for this annual depreciation.
    /// </summary>
    public int? AnnualDepreciation_LoanSecurityID { get; set; }

    /// <summary>
    /// Gets or sets the amount of annual depreciation.
    /// </summary>
    public double? AnnualDepreciationAmount { get; set; }

    /// <summary>
    /// Gets or sets the total number of dwellings associated with this depreciation.
    /// </summary>
    public int? DwellingCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bedrooms present in the property.
    /// </summary>
    public int? BedroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bathrooms in the property.
    /// </summary>
    public int? BathroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of garages for the property.
    /// </summary>
    public int? GarageCount { get; set; }

    /// <summary>
    /// Gets or sets the number of levels or floors in the property.
    /// </summary>
    public int? LevelCount { get; set; }

    /// <summary>
    /// Gets or sets the size of the living area in the property.
    /// </summary>
    public double? LivingAreaSize { get; set; }

    #region Remove fields

    /// <summary>
    /// Gets or sets the general lookup identifier for the free standing home type.
    /// </summary>
    [Comment("We will get this from General lookUp table")]
    public int? FreeStandingHomeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the duplex type.
    /// </summary>
    [Comment("We will get this from General lookUp table")]
    public int? DuplexType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the terrace type.
    /// </summary>
    [Comment("We will get this from General lookUp table")]
    public int? TerraceType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the townhouse type.
    /// </summary>
    [Comment("We will get this from General lookUp table")]
    public int? TownhouseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the development application type.
    /// </summary>
    [Comment("We will get this from General lookUp table")]
    public int? DevelopmentApplicationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the subdivision type.
    /// </summary>
    [Comment("We will get this from General lookUp table")]
    public int? SubdivisionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the display home type.
    /// </summary>
    [Comment("We will get this from General lookUp table")]
    public int? DisplayHomeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the duration, in months, the display home has been in a village.
    /// </summary>
    public int? DisplayHomeInVillageDurationMonths { get; set; }

    /// <summary>
    /// Gets or sets the duration, in months, the display home has been in a street.
    /// </summary>
    public int? DisplayHomeInStreetDurationMonths { get; set; }

    #endregion

    /// <summary>
    /// Gets or sets the related <see cref="LoanSecurity"/> entity for this annual depreciation.
    /// </summary>
    public LoanSecurity? AnnualDepreciation_LoanSecurity { get; set; }
}
