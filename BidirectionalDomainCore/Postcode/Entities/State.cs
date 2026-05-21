namespace Bidirectional.DomainCore.Postcode.Entities;

/// <summary>
/// Represents an Australian state or territory, including its name, abbreviation, and associated suburbs.
/// </summary>
public class State : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the full name of the state.
    /// </summary>
    [Comment("Victoria")]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the abbreviated name of the state.
    /// </summary>
    [Comment("Vic")]
    public required string AbbreviatedName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity is a territory.
    /// </summary>
    public bool ISTerritory { get; set; }

    /// <summary>
    /// Gets or sets the list of suburbs associated with this state.
    /// </summary>
    public List<Suburb> Suburbs { get; set; } = [];
}
