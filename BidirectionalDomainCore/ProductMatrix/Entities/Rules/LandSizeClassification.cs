namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents a land size classification rule for use in product matrices, including range boundaries and associated points.
/// </summary>
public class LandSizeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID for the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the starting value of the land size range.
    /// </summary>
    public double From { get; set; }

    /// <summary>
    /// Gets or sets the ending value of the land size range.
    /// </summary>
    public double To { get; set; }

    /// <summary>
    /// Gets or sets the heedful points associated with the land size classification.
    /// </summary>
    public int? HeedFulPoints { get; set; }
}
