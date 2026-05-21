namespace Bidirectional.DomainCore.BidOnboard.Entities.Generals.Countries;

/// <summary>
/// Represents a postal code entity, including associated locality, state, and address information.
/// </summary>
public class Postcode
{
    /// <summary>
    /// Gets or sets the unique identifier for the postal code entity.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Gets or sets the locality associated with the postal code.
    /// </summary>
    public string? Locality { get; set; }

    /// <summary>
    /// Gets or sets the state code corresponding to the postal code.
    /// </summary>
    public string? StateCode { get; set; }

    /// <summary>
    /// Gets or sets the type of address for the postal code.
    /// </summary>
    public string? AddressType { get; set; }

    /// <summary>
    /// Gets or sets the residential type associated with the postal code.
    /// </summary>
    public string? ResidentialType { get; set; }
}
