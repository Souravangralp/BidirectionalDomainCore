using Bidirectional.DomainCore.Calculator.Entities;
using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.ProductMatrix.Entities.Products;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of documentation requirements, 
/// associating document types, council zoning categories, and 
/// supplementary income evidence types.
/// </summary>
public class DocTypeRequirementClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related council zoning type.
    /// </summary>
    public int? LoDocRequirementClassification_CouncilZoningTypeID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the supplementary income evidence type from the general lookup.
    /// </summary>
    public int? SupplementaryIncomeEvidenceType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated document type.
    /// </summary>
    public int? LoDocRequirementClassification_DocTypeID { get; set; }

    /// <summary>
    /// Gets or sets the supplementary income evidence type lookup object.
    /// </summary>
    public GeneralLookup? SupplementaryIncomeEvidenceType_GeneralLookUp { get; set; }

    /// <summary>
    /// Gets or sets the related council zoning category.
    /// </summary>
    public CouncilZoningCategory? LoDocRequirementClassification_CouncilZoningType { get; set; }

    /// <summary>
    /// Gets or sets the associated document type.
    /// </summary>
    public DocType? LoDocRequirementClassification_DocType { get; set; }
}
