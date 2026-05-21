namespace Bidirectional.DomainCore.ProductMatrix.Entities.Products;

/// <summary>
/// Represents a product category, which defines a grouping for products within the system.
/// </summary>
public class ProductCategory : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the product category.
    /// </summary>
    public required string Name { get; set; }
}
