using Bidirectional.DomainCore.ProductMatrix.Entities.Postcodes;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of zoning types and associated identifiers within the system.
/// </summary>
public class ZoningTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the associated state.
    /// </summary>
    public int? ZoningTypeClassification_StateID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the loan type from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the zoning type from the CoreDB general lookup.
    /// </summary>
    public int? ZoningType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the zone type from the CoreDB general lookup.
    /// </summary>
    public int? ZoneType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the heedful points, representing an additional attribute for the zoning type classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }

    /// <summary>
    /// Gets or sets the associated <see cref="State"/> entity for the zoning type classification.
    /// </summary>
    public Bidirectional.DomainCore.ProductMatrix.Entities.Postcodes.State? ZoningTypeClassification_State { get; set; }
}
