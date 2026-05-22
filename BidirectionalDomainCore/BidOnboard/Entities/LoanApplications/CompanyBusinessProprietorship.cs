namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a company business proprietorship involved in a loan application, including business registration details and relationships.
/// </summary>
public class CompanyBusinessProprietorship : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the foreign key for the related IntroductionToTheCustomer entity.
    /// </summary>
    public int? CompanyBusinessProprietorship_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the foreign key for the related company applicant (Form009).
    /// </summary>
    public int? CompanyBusinessProprietorship_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the name of the company business proprietorship.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN) of the proprietorship.
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the appointment was made.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? AppointedDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the business registration number of the proprietorship.
    /// </summary>
    public string? BusinessRegNumber { get; set; }

    /// <summary>
    /// Gets or sets the state in which the business is registered.
    /// </summary>
    public string? BusinessRegState { get; set; }

    /// <summary>
    /// Gets or sets the business file number.
    /// </summary>
    public string? BusinessFileNumber { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when proprietary details were sourced from business names.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ProprietaryDetailsSourcedOnDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC time when proprietary details were sourced from business names.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ProprietaryDetailsSourcedAtTimeUtc { get; set; }

    /// <summary>
    /// Gets or sets the related IntroductionToTheCustomer entity for this proprietorship.
    /// </summary>
    public IntroductionToTheCustomer? CompanyBusinessProprietorship_IntroductionToTheCustomer { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant for Form009.
    /// </summary>
    public CompanyApplicant? CompanyBusinessProprietorship_CompanyApplicant { get; set; }
}
