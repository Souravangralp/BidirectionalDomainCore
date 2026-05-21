namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an owner associated with a loan application,
/// including borrower details and percentage of responsibility.
/// </summary>
public class Owner : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the associated borrower.
    /// </summary>
    public int? Owner_BorrowerID { get; set; }

    /// <summary>
    /// Gets or sets the ID referencing the percentage responsible entity.
    /// </summary>
    public int? Owner_ResponsibilityPercentageID { get; set; }

    /// <summary>
    /// Gets or sets the responsibility percentage for the owner.
    /// This property is encrypted in the database.
    /// </summary>
    [EncryptColumn]
    public string? Percent { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the related party.
    /// </summary>
    public string? PartyUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the associated borrower entity.
    /// </summary>
    public Borrower? Owner_Borrower { get; set; }

    /// <summary>
    /// Gets or sets the associated percentage responsible entity.
    /// </summary>
    public ResponsibilityPercentage? Owner_ResponsibilityPercentage { get; set; }
}
