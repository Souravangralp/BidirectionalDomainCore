namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the contact address details associated with a loan applicant, including address types, locations, and metadata.
/// </summary>
public class ContactAddress : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the loan applicant linked to this contact address.
    /// </summary>
    public int? ContactAddress_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the address type as defined in the CoreDB general lookup table.
    /// </summary>
    public int? ContactAddressType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the mailing address of the applicant.
    /// </summary>
    public string? MailingAddress { get; set; }

    /// <summary>
    /// Gets or sets the residential address of the applicant.
    /// </summary>
    public string? ResidentialAddress { get; set; }

    /// <summary>
    /// Gets or sets the housing status of the applicant.
    /// </summary>
    public string? HousingStatus { get; set; }

    /// <summary>
    /// Gets or sets the latitude coordinate for the address.
    /// </summary>
    public string? Latitude { get; set; } // As Client requested to have this field

    /// <summary>
    /// Gets or sets the longitude coordinate for the address.
    /// </summary>
    public string? Longitude { get; set; } // As Client requested to have this field

    /// <summary>
    /// Gets or sets the start date in UTC for when the address is valid.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the end date in UTC for when the address is no longer valid.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? EndDateUtc { get; set; }

    /// <summary>
    /// Gets or sets an additional field for future or custom data.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an additional field for future or custom data.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an additional field for future or custom data.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the associated loan applicant entity for this contact address.
    /// </summary>
    public Applicant? ContactAddress_Applicant { get; set; }
}
