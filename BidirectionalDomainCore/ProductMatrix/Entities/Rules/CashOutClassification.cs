using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.ProductMatrix.Entities.Products;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification and related metadata for a cash-out operation, 
/// including zoning type, financial lookups, and encoded properties.
/// </summary>
public class CashOutClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the council zoning type associated with the classification.
    /// </summary>
    public int? CashOutClassification_CouncilZoningTypeID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for business finance related to the classification.
    /// </summary>
    public int? BusinessFinance_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the cash-out type classification.
    /// </summary>
    public int? CashOutType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the heedful points associated with the classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }

    /// <summary>
    /// Gets or sets the business finance general lookup entity related to the cash-out classification.
    /// </summary>
    public GeneralLookup? CashOutClassification_BusinessFinance_GeneralLookUp { get; set; }

    /// <summary>
    /// Gets or sets the cash-out type general lookup entity related to the cash-out classification.
    /// </summary>
    public GeneralLookup? CashOutClassification_CashOutType_GeneralLookUp { get; set; }

    /// <summary>
    /// Gets or sets the council zoning category entity associated with the cash-out classification.
    /// </summary>
    public CouncilZoningCategory? CashOutClassification_CouncilZoningType { get; set; }
}
