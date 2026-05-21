namespace Bidirectional.DomainCore.Postcode.Entities;

/// <summary>
/// Represents a postal code entity with associated state information.
/// </summary>
public class Postcode : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the postcode value.
    /// </summary>
    public required string Code { get; set; }

    /// <summary>
    /// Gets or sets the code of the state associated with the postcode.
    /// </summary>
    public string? StateCode { get; set; }
}
