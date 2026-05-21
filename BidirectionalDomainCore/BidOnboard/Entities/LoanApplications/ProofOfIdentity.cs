namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a record of a proof of identity document provided by an applicant within a loan application.
/// </summary>
public class ProofOfIdentity : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the applicant associated with this proof of identity.
    /// </summary>
    public int? ProofOfIdentity_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether previous name identification has been completed.
    /// </summary>
    public bool PreviousNameIdentification { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the residential address has been verified.
    /// </summary>
    public bool ISResidentialAddressVerified { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the photograph has been verified.
    /// </summary>
    public bool ISPhotographVerified { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the signature on the document has been verified.
    /// </summary>
    public bool ISSignatureVerified { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the document is an original.
    /// </summary>
    public bool ISOriginal { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the date of birth has been verified.
    /// </summary>
    public bool ISDobVerified { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the name on the document has been verified.
    /// </summary>
    public bool ISNameVerified { get; set; }

    /// <summary>
    /// Gets or sets the country where the document was issued.
    /// </summary>
    public string? CountryOfIssue { get; set; }

    /// <summary>
    /// Gets or sets the category of the document (e.g., passport, driver's license).
    /// </summary>
    public string? DocumentCategory { get; set; }

    /// <summary>
    /// Gets or sets the specific type of the identity document.
    /// </summary>
    [EncryptColumn]
    public string? DocumentType { get; set; }

    /// <summary>
    /// Gets or sets the name that appears on the identity document.
    /// </summary>
    public string? NameOnDocument { get; set; }

    /// <summary>
    /// Gets or sets the document number.
    /// </summary>
    [EncryptColumn]
    public string? DocumentNumber { get; set; }

    /// <summary>
    /// Gets or sets an additional description for documents that do not fit predefined categories.
    /// </summary>
    public string? OtherDescription { get; set; }

    /// <summary>
    /// Gets or sets the Australian state where the document was issued, if applicable.
    /// </summary>
    public string? AustralianStateOfIssue { get; set; }

    /// <summary>
    /// Gets or sets the location where the document verification took place.
    /// </summary>
    public string? DocumentVerificationLocation { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the document in UTC.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? ExpiryDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the date the document was issued in UTC.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? DateOfIssueUtc { get; set; }

    /// <summary>
    /// Gets or sets an extra field for future use or customization.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for future use or customization.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for future use or customization.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the applicant entity associated with this proof of identity.
    /// </summary>
    public Applicant? ProofOfIdentity_Applicant { get; set; }
}
