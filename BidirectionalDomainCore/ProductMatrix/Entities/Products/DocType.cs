namespace Bidirectional.DomainCore.ProductMatrix.Entities.Products;

/// <summary>
/// Represents a document type associated with a product.
/// </summary>
public class DocType : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the document type.
    /// </summary>
    public required string Name { get; set; }
}
