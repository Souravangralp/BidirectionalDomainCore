namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification information for a usage type, including related lookup identifiers and points.
/// </summary>
public class UsageTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the loan type from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the usage type from the CoreDB general lookup.
    /// </summary>
    public int? UsageType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the points assigned based on heedful evaluation.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
