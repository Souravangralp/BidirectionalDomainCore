namespace Bidirectional.DomainCore.Postcode.Entities.Mappers;

/// <summary>
/// Represents a mapping between a postcode and a suburb, linking their identifiers and related entities.
/// </summary>
public class PostcodeSuburbMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the associated postcode.
    /// </summary>
    public int PostcodeSuburbMapper_PostcodeID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the associated suburb, if available.
    /// </summary>
    public int? PostcodeSuburbMapper_SuburbID { get; set; }

    /// <summary>
    /// Gets or sets the suburb entity associated with this mapping.
    /// </summary>
    public Suburb? PostcodeSuburbMapper_Suburb { get; set; }

    /// <summary>
    /// Gets or sets the postcode entity associated with this mapping.
    /// </summary>
    public Postcode? PostcodeSuburbMapper_Postcode { get; set; }
}
