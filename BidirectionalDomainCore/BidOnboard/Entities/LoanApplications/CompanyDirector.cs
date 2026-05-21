namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a company director associated with a loan application, 
/// containing personal, identification, and appointment details.
/// </summary>
public class CompanyDirector : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the foreign key for the introduction of the director to the customer.
    /// </summary>
    public int? CompanyDirector_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the full name of the director.
    /// </summary>
    public string? DirectorFullName { get; set; }

    /// <summary>
    /// Gets or sets the unique file number assigned to the director.
    /// </summary>
    public string? DirectorFileNumber { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the director was appointed.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? DirectorAppointmentDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of birth of the director.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? DirectorDateOfBirthUtc { get; set; }

    /// <summary>
    /// Gets or sets the place of birth of the director.
    /// </summary>
    public string? DirectorPlaceOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the gender of the director.
    /// </summary>
    public string? DirectorGender { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if the director resides overseas.
    /// </summary>
    public string? IsDirectorResidentOverseas { get; set; }

    /// <summary>
    /// Gets or sets the address of the director.
    /// </summary>
    public string? DirectorAddress { get; set; }

    /// <summary>
    /// Gets or sets the document number associated with the director's identification.
    /// </summary>
    public string? DirectorDocumentNumber { get; set; }

    /// <summary>
    /// Gets or sets the related introduction to the customer entity for the director.
    /// </summary>
    public IntroductionToTheCustomer? CompanyDirector_IntroductionToTheCustomer { get; set; }
}
