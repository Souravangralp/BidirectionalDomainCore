namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a first-time buyer application and its associated properties within a loan application context.
/// </summary>
public class FirstTimeBuyer : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier linking this entity to the associated loan application.
    /// </summary>
    public int FirstTimeBuyer_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant qualifies for government assistance.
    /// </summary>
    public bool ISQualifyForGovernmentAssistance { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the type of party making the application, retrieved from the general lookup table.
    /// </summary>
    [Comment("We Will get this data from GeneralLookUpTable ")]
    public int? PartyMakingTheApplicationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the type of first-time buyers applying, retrieved from the general lookup table.
    /// </summary>
    [Comment("We Will get this data from GeneralLookUpTable ")]
    public int? FirstTimeBuyersApplyingType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the guidance provider type, retrieved from the general lookup table.
    /// </summary>
    [Comment("We Will get this data from GeneralLookUpTable ")]
    public int? GuidedByType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the motivation, strategy, or plan type, retrieved from the general lookup table.
    /// </summary>
    [Comment("We Will get this data from GeneralLookUpTable")]
    public int? MotivationStrategyOrPlanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the nature of the transaction, retrieved from the general lookup table.
    /// </summary>
    [Comment("We Will get this data from GeneralLookUpTable")]
    public int? NatureOfTransactionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the transaction is non arm's length (true) or involves a nominee/purchaser different from the borrower (false).
    /// </summary>
    [Comment("if true Non arm�s length else Nominee/purchaser different to borrower")]
    public bool HasNonArmLengthTransaction { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the first-time buyer is a licensed real estate agent.
    /// </summary>
    public bool IsLicensedRealEstateAgent { get; set; }

    /// <summary>
    /// Gets or sets the name of the real estate agency if the first-time buyer is a licensed agent.
    /// </summary>
    [Comment("If FirstTime Buyer is LicensedAgent We will need to add Agency Name")]
    public string? RealEstateAgencyName { get; set; }

    /// <summary>
    /// Gets or sets the associated loan application entity for the first-time buyer.
    /// </summary>
    public LoanApplication? FirstTimeBuyer_LoanApplication { get; set; }
}
