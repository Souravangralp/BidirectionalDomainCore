namespace Bidirectional.DomainCore.ProductMatrix.Entities.Products;

/// <summary>
/// Represents a product entity with associated category and product lookup identifiers.
/// </summary>
public class Product : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the core database general lookup ID for the product category.
    /// </summary>
    public int? ProductCategory_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the core database general lookup ID for the product.
    /// </summary>
    public int Product_CoreDB_GeneralLookUpID { get; set; }
}
