namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the percentage responsibility associated with a loan application's other commitments or other income, and the related owners.
/// </summary>
public class ResponsibilityPercentage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related other commitment, if applicable.
    /// </summary>
    public int? ResponsibilityPercentage_OtherCommitmentID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related other income, if applicable.
    /// </summary>
    public int? ResponsibilityPercentage_OtherIncomeID { get; set; }

    /// <summary>
    /// Gets or sets the proportion of responsibility as a string.
    /// </summary>
    public string? Proportion { get; set; }

    /// <summary>
    /// Gets or sets the associated other commitment entity.
    /// </summary>
    public OtherCommitment? ResponsibilityPercentage_OtherCommitment { get; set; }

    /// <summary>
    /// Gets or sets the associated other income entity.
    /// </summary>
    public OtherIncome? ResponsibilityPercentage_OtherIncome { get; set; }

    /// <summary>
    /// Gets or sets the list of owners who are associated with this responsibility percentage.
    /// </summary>
    public IList<Owner> Owner { get; set; } = new List<Owner>();
}
