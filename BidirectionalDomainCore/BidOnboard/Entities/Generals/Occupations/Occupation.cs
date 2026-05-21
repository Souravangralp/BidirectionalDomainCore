namespace Bidirectional.DomainCore.BidOnboard.Entities.Generals.Occupations;

/// <summary>
/// Represents an occupation within the system, including code, name, and active status.
/// </summary>
public class Occupation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the code that uniquely identifies the occupation.
    /// </summary>
    public string? OccupationCode { get; set; }

    /// <summary>
    /// Gets or sets the name of the occupation.
    /// </summary>
    public string? Name { get; set; }
}
