namespace Bidirectional.DomainCore.ProductMatrix.Entities.Postcodes;

/// <summary>
/// Represents an Australian state or territory, including its name and abbreviation.
/// </summary>
public class State : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the full name of the state (e.g., "Victoria").
    /// </summary>
    [Comment("Victoria")]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the abbreviated name of the state (e.g., "Vic").
    /// </summary>
    [Comment("Vic")]
    public required string AbbreviatedName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity is a territory instead of a state.
    /// </summary>
    public bool ISTerritory { get; set; }
}
