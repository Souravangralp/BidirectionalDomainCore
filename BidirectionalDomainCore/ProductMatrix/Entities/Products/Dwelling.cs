namespace Bidirectional.DomainCore.ProductMatrix.Entities.Products;

/// <summary>
/// Represents a dwelling product, capturing relevant data such as count.
/// </summary>
public class Dwelling : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the number of dwellings.
    /// </summary>
    public int Count { get; set; }
}
