namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the guided by type classification rule, associating loan type, guided-by type, and related scoring information.
/// </summary>
public class GuidedByTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the core database loan type.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the core database guided-by type.
    /// </summary>
    public int? GuidedByType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the heedful points associated with this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
