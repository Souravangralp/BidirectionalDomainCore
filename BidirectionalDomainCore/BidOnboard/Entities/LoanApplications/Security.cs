namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a loan security entity, which contains details about a security used in a loan application,
/// including its address, valuation, and associated financial and property attributes.
/// </summary>
public class Security : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related loan application.
    /// </summary>
    public int? LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the GeneralLookUp identifier for the valuation type. This data is retrieved from GeneralLookup.
    /// </summary>
    public int? ValuationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the address of the security.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Gets or sets the latitude coordinate of the security location.
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude coordinate of the security location.
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// Gets or sets the property category (PC category) of the security.
    /// </summary>
    public string? PCCategory { get; set; }

    /// <summary>
    /// Gets or sets the capital value associated with the security.
    /// </summary>
    public string? Capital { get; set; }

    /// <summary>
    /// Gets or sets the size of the land for the security.
    /// </summary>
    public string? LandSize { get; set; }

    /// <summary>
    /// Gets or sets the loan amount related to the security.
    /// </summary>
    public string? LoanAmount { get; set; }

    /// <summary>
    /// Gets or sets the population figure relevant to the security.
    /// </summary>
    public string? Population { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the security is green rated.
    /// </summary>
    public bool GreenRated { get; set; }

    /// <summary>
    /// Gets or sets the proposed name to appear on the property title.
    /// </summary>
    public string? ProposedNameOnTitle { get; set; }

    /// <summary>
    /// Gets or sets the estimated or appraised value of the security.
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Gets or sets the loan-to-value ratio (LVR) of the security.
    /// </summary>
    public double? LVR { get; set; }

    /// <summary>
    /// Gets or sets the loan application associated with this security.
    /// </summary>
    public LoanApplication? LoanApplication { get; set; }
}
