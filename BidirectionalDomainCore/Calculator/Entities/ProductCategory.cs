namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a product category entity with auditing information.
/// </summary>
public class ProductCategory : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional ID of the related product.</summary>
    public int? ProductCategory_ProductID { get; set; }

    /// <summary>Gets or sets the numeral name of the product category.</summary>
    public required string NumeralName { get; set; }

    /// <summary>Gets or sets the optional related product entity.</summary>
    public Product? ProductCategory_Product { get; set; }
}
