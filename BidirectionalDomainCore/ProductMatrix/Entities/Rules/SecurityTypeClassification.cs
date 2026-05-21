namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details for a security type, including references to loan and security type lookup IDs and the associated heedful points value.
/// </summary>
public class SecurityTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID for the core database loan type associated with this classification.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for the core database security type associated with this classification.
    /// </summary>
    public int? SecurityType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the heedful points assigned to this security type classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
