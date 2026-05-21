namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents units and apartment-related information and attributes for a loan security within a loan application.
/// </summary>
public class UnitsAndApartment : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated LoanSecurity entity.
    /// </summary>
    public int? UnitsAndApartment_LoanSecurityID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is no cash out other than cost for this loan application.
    /// </summary>
    public bool ISNoCashOutOtherThanCost { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID representing the type of refinance source.
    /// </summary>
    [Comment("Refinance")]
    public int? RefinanceFromType_GeneralLookUpID { get; set; }

    #region Remove fields

    /// <summary>
    /// Gets or sets the internal living area in square meters, excluding garages and balconies.
    /// </summary>
    [Comment(" m2 of internal living area excluding garages & balconies (min 18) &")]
    public int? LivingArea { get; set; }

    /// <summary>
    /// Gets or sets the number of levels in the unit or apartment.
    /// </summary>
    public int? LevelCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bedrooms in the unit or apartment.
    /// </summary>
    public int? BedroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of bathrooms in the unit or apartment.
    /// </summary>
    public int? BathroomCount { get; set; }

    /// <summary>
    /// Gets or sets the number of garages available for the unit or apartment.
    /// </summary>
    public int? GarageCount { get; set; }

    /// <summary>
    /// Gets or sets the number of car spaces associated with the unit or apartment.
    /// </summary>
    public int? CarSpaceCount { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the classification type of the unit or apartment.
    /// </summary>
    [Comment("We will get this from GeneralLookUp table")]
    public int? ClassificationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the unit or apartment has an attached laundry.
    /// </summary>
    public bool HASAttachedLaundry { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the unit or apartment has an attached bathroom.
    /// </summary>
    public bool HASAttachedBathroom { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the postcode classification type.
    /// </summary>
    [Comment("We will get this from GeneralLookUp table")]
    public int? PostcodeClassificationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the total number of units in the development.
    /// </summary>
    [Comment("Numbers of this development specifics")]
    public int? UnitCount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether any levels in the development were built prior to 31/12/2011.
    /// </summary>
    [Comment("Levels Built prior to 31/12/2011")]
    public bool HASLevelBuiltPriorTo31Dec2011 { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the title type of the unit or apartment.
    /// </summary>
    [Comment("we will get this from GeneralLookUp table")]
    public int? TitleType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the proposed name to appear on the title for the unit or apartment.
    /// </summary>
    public string? ProposedNameOnTitle { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID representing the type of refinance.
    /// </summary>
    [Comment("Refinance")]
    public int? RefinanceType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the consumer loan amount to be consolidated as part of the refinance.
    /// </summary>
    [Comment("Refinance")]
    public int? ConsumerLoanToBeConsolidated { get; set; }

    #endregion

    /// <summary>
    /// Gets or sets the related LoanSecurity entity for the unit or apartment.
    /// </summary>
    public LoanSecurity? UnitsAndApartment_LoanSecurity { get; set; }
}
