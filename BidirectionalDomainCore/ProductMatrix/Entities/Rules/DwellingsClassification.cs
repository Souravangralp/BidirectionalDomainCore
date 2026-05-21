namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification rules for dwellings, including loan type, property category,
/// dwelling range, and associated points within the rules engine.
/// </summary>
public class DwellingsClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID referencing the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for the property category type from the core database.
    /// </summary>
    public int? PCCategoryType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the starting range of dwellings included in this classification.
    /// </summary>
    public required int FromDwelling { get; set; }

    /// <summary>
    /// Gets or sets the ending range of dwellings included in this classification.
    /// </summary>
    public required int ToDwelling { get; set; }

    /// <summary>
    /// Gets or sets the points assigned for this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
