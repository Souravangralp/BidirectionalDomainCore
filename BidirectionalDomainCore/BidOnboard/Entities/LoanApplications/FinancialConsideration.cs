namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the financial considerations associated with a loan application,
/// including refinancing status and various financial account counts.
/// </summary>
public class FinancialConsideration : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the linked loan application for this financial consideration.
    /// </summary>
    public int? FinancialConsideration_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the application involves refinancing.
    /// </summary>
    public bool ISRefinancing { get; set; }

    /// <summary>
    /// Gets or sets the total count of credit cards associated with the loan application.
    /// </summary>
    public int? CreditCardCount { get; set; }

    /// <summary>
    /// Gets or sets the count of credit cards intended to be refinanced.
    /// </summary>
    public int? CreditCardsRefinanceCount { get; set; }

    /// <summary>
    /// Gets or sets the count of credit cards not intended for refinancing.
    /// </summary>
    public int? CreditCardsNotRefinanceCount { get; set; }

    /// <summary>
    /// Gets or sets the total count of consumer facilities associated with the loan application.
    /// </summary>
    public int? ConsumerFacilityCount { get; set; }

    /// <summary>
    /// Gets or sets the count of consumer facilities intended to be refinanced.
    /// </summary>
    public int? ConsumerFacilitiesRefinanceCount { get; set; }

    /// <summary>
    /// Gets or sets the count of consumer facilities not intended for refinancing.
    /// </summary>
    public int? ConsumerFacilitiesNotRefinanceCount { get; set; }

    /// <summary>
    /// Gets or sets the linked loan application entity for this financial consideration.
    /// </summary>
    public LoanApplication? FinancialConsideration_LoanApplication { get; set; }
}
