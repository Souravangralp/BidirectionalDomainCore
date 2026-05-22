using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.ProductMatrix.Entities.Products;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of arrears including related financial hardship and zoning information.
/// </summary>
public class ArrearsClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated council zoning type used in the arrears classification.
    /// </summary>
    public int? ArrearsClassification_CouncilZoningTypeID { get; set; }

    /// <summary>
    /// Gets or sets the duration of arrears in months.
    /// </summary>
    public int? ArrearInMonths { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the classification is for RHI (Residential Housing Initiative).
    /// </summary>
    public bool ISRHI { get; set; }

    /// <summary>
    /// Gets or sets the number of defaults associated with this arrears classification.
    /// </summary>
    public int? Defaults { get; set; }

    /// <summary>
    /// Gets or sets the total liabilities for this arrears classification.
    /// </summary>
    public int? Liabilities { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the general lookup of financial hardship type.
    /// </summary>
    public int? FinancialHardshipType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup entity associated with the financial hardship type.
    /// </summary>
    public GeneralLookup? FinancialHardshipType_GeneralLookUp { get; set; }

    /// <summary>
    /// Gets or sets the council zoning category associated with this arrears classification.
    /// </summary>
    public CouncilZoningCategory? ArrearsClassification_CouncilZoningType { get; set; }
}
