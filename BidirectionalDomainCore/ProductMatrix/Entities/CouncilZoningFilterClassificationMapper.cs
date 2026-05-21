namespace Bidirectional.DomainCore.ProductMatrix.Entities;

/// <summary>
/// Represents a mapping between a loan type and a zoning filter classification, 
/// associating loan types from the core database with filter classification entities.
/// </summary>
public class CouncilZoningFilterClassificationMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the CoreDB general lookup ID associated with the loan type.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related zoning filter classification.
    /// </summary>
    public int? CouncilZoningFilterClassificationMapper_FilterClassificationID { get; set; }

    /// <summary>
    /// Gets or sets the related filter classification entity for the zoning filter mapping.
    /// </summary>
    public FilterClassification? CouncilZoningFilterClassificationMapper_FilterClassification { get; set; }
}
