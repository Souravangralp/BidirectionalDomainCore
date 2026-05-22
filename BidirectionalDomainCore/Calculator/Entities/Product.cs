namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a product entity with optional description.
/// </summary>
public class Product : BaseAuditableEntity
{
    /// <summary>Gets or sets the product name.</summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the core database general lookup ID for the product category.
    /// </summary>
    public int? ProductCategory_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the core database general lookup ID for the product.
    /// </summary>
    public int Product_CoreDB_GeneralLookUpID { get; set; }
}
