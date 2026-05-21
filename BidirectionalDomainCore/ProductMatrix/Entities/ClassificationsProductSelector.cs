namespace Bidirectional.DomainCore.ProductMatrix.Entities;

/// <summary>
/// Represents a selector entity that associates product classification and filter type information for product matrix operations.
/// </summary>
public class ClassificationsProductSelector : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the filter type used in product classification selection.
    /// </summary>
    public int? ProductClassificationSelector_FilterTypeID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID referencing the product type.
    /// </summary>
    public int? ProductType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID referencing the numeral type.
    /// </summary>
    public int? NumeralType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the classification ID associated with the selector.
    /// </summary>
    public int ClassificationID { get; set; }

    /// <summary>
    /// Gets or sets the filter classification entity related to the selector filter type.
    /// </summary>
    public FilterClassification? ProductClassificationSelector_FilterType { get; set; }
}
