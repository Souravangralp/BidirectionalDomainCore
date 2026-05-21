namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a product entity with optional description.
/// </summary>
public class Product : BaseAuditableEntity
{
    /// <summary>Gets or sets the product name.</summary>
    public required string Name { get; set; }
}
