using Bidirectional.DomainCore.Postcode.Entities.Generals;

namespace Bidirectional.DomainCore.Postcode.Entities;

/// <summary>
/// Represents a suburb, including its name, associated state, and location type information.
/// </summary>
public class Suburb : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated state for the suburb.
    /// </summary>
    public int? Suburb_StateID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the location type for the suburb.
    /// </summary>
    public int? Suburb_LocationTypeID { get; set; }

    /// <summary>
    /// Gets or sets the name of the suburb.
    /// </summary>
    [TextClass(TextFieldClass.UnicodeLettersWithSeparatorsPolicy)]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the state entity associated with the suburb.
    /// </summary>
    public State? Suburb_State { get; set; }

    /// <summary>
    /// Gets or sets the location type entity associated with the suburb.
    /// </summary>
    public GeneralLookup? Suburb_LocationType { get; set; }
}
