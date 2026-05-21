namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents a classification for facility types, including associated loan type and heedful points, within the rules engine.
/// </summary>
public class FacilityTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from CoreDB.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the facility type from CoreDB.
    /// </summary>
    public int? FacilityType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points assigned to this facility type classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
