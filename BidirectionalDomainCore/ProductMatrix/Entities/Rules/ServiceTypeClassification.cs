namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details of a service type, including associated loan type and points.
/// </summary>
public class ServiceTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the core database general lookup ID for the associated loan type.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the core database general lookup ID for the service type.
    /// </summary>
    public int? ServiceType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the heedful points assigned to the service type classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
