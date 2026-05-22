using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.ProductMatrix.Entities.Products;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of a marital status, including associated council zoning category and lookup information.
/// </summary>
public class MaritalStatusClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated council zoning category type.
    /// </summary>
    public int? MaritalStatusClassification_CouncilZoningCategoryTypeID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the marital status type.
    /// </summary>
    public int? MaritalStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with the marital status classification.
    /// </summary>
    public int? HeedFulPoints { get; set; }

    /// <summary>
    /// Gets or sets the council zoning category type associated with this marital status classification.
    /// </summary>
    public CouncilZoningCategory? MaritalStatusClassification_CouncilZoningCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the general lookup information for the marital status type.
    /// </summary>
    public GeneralLookup? MaritalStatusType_GeneralLookUp { get; set; }
}
