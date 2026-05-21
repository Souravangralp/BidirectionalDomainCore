namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the current company secretary details for a loan application, including identity, appointment, and personal information.
/// </summary>
public class CompanyCurrentSecretary : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier linking the company secretary to the introduction to the customer entity.
    /// </summary>
    public int? CompanyCurrentSecretary_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the full name of the company secretary.
    /// </summary>
    public string? SecretaryFullName { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the secretary was appointed.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SecretaryAppointmentDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of birth of the secretary.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SecretaryDateOfBirthUtc { get; set; }

    /// <summary>
    /// Gets or sets the place of birth of the secretary.
    /// </summary>
    public string? SecretaryPlaceOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the address of the secretary.
    /// </summary>
    public string? SecretaryAddress { get; set; }

    /// <summary>
    /// Gets or sets the document number associated with the secretary.
    /// </summary>
    public string? SecretaryDocumentNumber { get; set; }

    /// <summary>
    /// Gets or sets the related introduction to the customer entity.
    /// </summary>
    public IntroductionToTheCustomer? CompanyCurrentSecretary_IntroductionToTheCustomer { get; set; }
}
