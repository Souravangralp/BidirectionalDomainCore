using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.ProductMatrix.Entities.Products;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents a filter for financial and entity classification,
/// linking zoning and general lookup categories to specific filter criteria.
/// </summary>
public class FinancialAndEntityClassificationFilter : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related council zoning type.
    /// </summary>
    public int? CouncilZoningTypeID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related general lookup category.
    /// </summary>
    public int? GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with the filter.
    /// </summary>
    public int? HeedfulPoints { get; set; }

    /// <summary>
    /// Gets or sets the council zoning category associated with this filter.
    /// </summary>
    [ForeignKey(nameof(CouncilZoningTypeID))]
    public CouncilZoningCategory? FinancialAndEntityClassificationFilter_CouncilZoningType { get; set; }

    /// <summary>
    /// Gets or sets the general lookup entity associated with this filter.
    /// </summary>
    [ForeignKey(nameof(GeneralLookUpID))]
    public GeneralLookup? FinancialAndEntityClassificationFilter_GeneralLookUp { get; set; }
}
