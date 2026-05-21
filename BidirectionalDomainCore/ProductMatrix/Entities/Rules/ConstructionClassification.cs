namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details related to construction for a project, including type, builder, structural changes, and special attributes.
/// </summary>
public class ConstructionClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the loan type from the CoreDB General Lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the construction type from the CoreDB General Lookup.
    /// </summary>
    public int? ConstructionType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the builder type from the CoreDB General Lookup.
    /// </summary>
    public int? BuilderType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the structural change type from the CoreDB General Lookup.
    /// </summary>
    public int? StructuralChangeType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the construction involves renovation.
    /// </summary>
    public bool ISRenovation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the construction is green rated.
    /// </summary>
    public bool ISGreenRated { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points assigned to the construction.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
