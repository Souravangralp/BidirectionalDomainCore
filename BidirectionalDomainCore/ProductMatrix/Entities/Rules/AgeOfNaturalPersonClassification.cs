namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the age classification rules for a natural person in relation to a loan type,
/// including minimum and maximum age limits and associated points.
/// </summary>
public class AgeOfNaturalPersonClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum allowed age for classification.
    /// </summary>
    public required double MinimumAge { get; set; }

    /// <summary>
    /// Gets or sets the maximum allowed age for classification.
    /// </summary>
    public required double MaximumAge { get; set; }

    /// <summary>
    /// Gets or sets the points assigned for meeting the age criteria.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
