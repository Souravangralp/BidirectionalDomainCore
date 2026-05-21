namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the loan term details and associated properties for a loan application.
/// </summary>
public class Term : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the foreign key referencing the LoanDetail entity related to this term.
    /// </summary>
    public int? Term_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the payment type from the GeneralLookUp in the core database.
    /// </summary>
    public int? PaymentType_GeneralLookUpID { get; set; } // We will get this value from GeneralLookUp

    /// <summary>
    /// Gets or sets the units associated with the interest type (e.g., months, years).
    /// </summary>
    public string? InterestTypeUnits { get; set; }

    /// <summary>
    /// Gets or sets the type of interest applied to the loan (e.g., fixed, variable).
    /// </summary>
    public string? InterestType { get; set; }

    /// <summary>
    /// Gets or sets the duration for the payment type.
    /// </summary>
    public string? PaymentTypeDuration { get; set; }

    /// <summary>
    /// Gets or sets the units for the payment type duration (e.g., months, years).
    /// </summary>
    public string? PaymentTypeUnits { get; set; }

    /// <summary>
    /// Gets or sets the total duration of the loan term.
    /// </summary>
    public string? TotalTermDuration { get; set; }

    /// <summary>
    /// Gets or sets the type of the total term (e.g., full-term, partial-term).
    /// </summary>
    public string? TotalTermType { get; set; }

    /// <summary>
    /// Gets or sets the units for the total term duration (e.g., months, years).
    /// </summary>
    public string? TotalTermUnits { get; set; }

    /// <summary>
    /// Gets or sets the duration for the interest type.
    /// </summary>
    public string? InterestTypeDuration { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the related LoanDetail entity.
    /// </summary>
    public LoanDetail? Term_LoanDetail { get; set; }
}
