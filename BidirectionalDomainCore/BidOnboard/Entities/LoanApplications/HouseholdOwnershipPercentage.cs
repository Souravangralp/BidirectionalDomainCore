namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the relationship between a household, its owners, and their ownership percentages within the context of a loan application.
/// </summary>
public class HouseholdOwnershipPercentage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the associated household.
    /// </summary>
    public int? HouseholdOwnershipPercentage_HouseholdID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the related applicant, if applicable.
    /// </summary>
    public int? HouseholdOwnershipPercentage_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the related company applicant, if applicable.
    /// </summary>
    public int? HouseholdOwnershipPercentage_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the name of the registered owner.
    /// </summary>
    public string? RegisteredOwner { get; set; }

    /// <summary>
    /// Gets or sets the owner's proportion of the household as a string.
    /// </summary>
    public string? Proportion { get; set; }

    /// <summary>
    /// Gets or sets the percentage share owned by the party.
    /// </summary>
    public double? PercentShared { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the party.
    /// </summary>
    public string? PartyUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the related applicant entity.
    /// </summary>
    public Applicant? HouseholdOwnershipPercentage_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity.
    /// </summary>
    public CompanyApplicant? HouseholdOwnershipPercentage_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the related household entity.
    /// </summary>
    public Household? HouseholdOwnershipPercentage_Household { get; set; }
}
