namespace Bidirectional.DomainCore.ProductMatrix.Entities.Products;

/// <summary>
/// Represents a zoning category as defined by the council, including its name, description, and zoning rules relationship.
/// </summary>
public class CouncilZoningCategory : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the council zoning category.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this category is represented in the rules sheet.
    /// </summary>
    public bool ISRepresentingRulesSheet { get; set; }
}
