namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a related entity associated with a loan application, including ownership, identification, and compliance details.
/// </summary>
public class RelatedEntity : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated loan application.
    /// </summary>
    public int? RelatedEntity_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the related entity type identifier, sourced from the general lookup table.
    /// </summary>
    [Comment("We will get this from GeneralLookUpTable")]
    public int? RelatedEntityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the name title type identifier, sourced from the general lookup table.
    /// </summary>
    [Comment("We will get this from GeneralLookUpTable")]
    public int? NameTitleType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the first name of the related entity.
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets an alternate name or nickname for the related entity.
    /// </summary>
    public string? KnownAs { get; set; }

    /// <summary>
    /// Gets or sets the first name in the middle name section, if applicable.
    /// </summary>
    public string? MiddleFirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name or surname in the middle name section, if applicable.
    /// </summary>
    public string? MiddleLastNameORSurname { get; set; }

    /// <summary>
    /// Gets or sets the last name or surname of the related entity.
    /// </summary>
    public string? LastNameORSurname { get; set; }

    /// <summary>
    /// Gets or sets the director's name if the related entity is an organization.
    /// </summary>
    public string? Director { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the director.
    /// </summary>
    public string? DirectorID { get; set; }

    /// <summary>
    /// Gets or sets the collection of percentage ownership details for the related entity.
    /// </summary>
    public IList<OwnershipPercentage> OwnershipPercentages { get; set; } = new List<OwnershipPercentage>();

    /// <summary>
    /// Gets or sets the names or details of beneficiaries associated with the related entity.
    /// </summary>
    public string? Beneficiaries { get; set; }

    /// <summary>
    /// Gets or sets the overall percentage of ownership.
    /// </summary>
    public string? PercentageOwnership { get; set; }

    /// <summary>
    /// Gets or sets the details of the beneficial owner, if applicable.
    /// </summary>
    public string? BeneficialOwner { get; set; }

    /// <summary>
    /// Gets or sets the percentage of beneficial ownership.
    /// </summary>
    public string? PercentageBeneficialOwnership { get; set; }

    /// <summary>
    /// Gets or sets the trading address associated with the related entity.
    /// </summary>
    public string? TradingAddress { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN) for the related entity.
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Company Number (ACN) for the related entity.
    /// </summary>
    public string? ACN { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the registered address is the same as the trading address.
    /// </summary>
    public bool ISRegisteredAddressSameAsTradingAddress { get; set; }

    /// <summary>
    /// Gets or sets the registered address of the related entity.
    /// </summary>
    public string? RegisteredAddress { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the related entity is registered for GST.
    /// </summary>
    public bool ISRegisteredForGST { get; set; }

    /// <summary>
    /// Gets or sets the collection of actions related to this entity.
    /// </summary>
    public IList<RelatedEntityAction> RelatedEntityActions { get; set; } = new List<RelatedEntityAction> { };

    /// <summary>
    /// Gets or sets the UTC registration date of the related entity.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? RegistrationDateUtc { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the director is banned or disqualified.
    /// </summary>
    public bool ISBannedAndDisqualifiedDirector { get; set; }

    /// <summary>
    /// Gets or sets details if the director is banned or disqualified.
    /// </summary>
    public string? BannedAndDisqualifiedDirectorDetail { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity has traded whilst insolvent.
    /// </summary>
    public bool ISTradingWhilstInsolvent { get; set; }

    /// <summary>
    /// Gets or sets the details regarding trading whilst insolvent.
    /// </summary>
    public string? TradingWhilstInsolventDetail { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a court winding up order for the related entity.
    /// </summary>
    public bool ISCourtWindingUpOrder { get; set; }

    /// <summary>
    /// Gets or sets details on any court winding up order.
    /// </summary>
    public string? CourtWindingUpOrderDetail { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity has been placed under involuntary administration.
    /// </summary>
    public bool ISPlacedInvoluntaryAdministration { get; set; }

    /// <summary>
    /// Gets or sets the details of involuntary administration placement.
    /// </summary>
    public string? PlacedInvoluntaryAdministrationDetail { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity is subjected to a petition.
    /// </summary>
    public bool ISSubjectedToAPetition { get; set; }

    /// <summary>
    /// Gets or sets details regarding any petition subjecting the entity.
    /// </summary>
    public string? SubjectedToAPetitionDetail { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity is subject to foreclosure or bailout.
    /// </summary>
    public bool ISSubjectToForeclosureORBailout { get; set; }

    /// <summary>
    /// Gets or sets the associated loan application for the related entity.
    /// </summary>
    public LoanApplication? RelatedEntity_LoanApplication { get; set; }
}
