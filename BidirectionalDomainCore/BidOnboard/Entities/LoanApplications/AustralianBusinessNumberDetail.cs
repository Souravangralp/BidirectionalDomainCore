namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details of an Australian Business Number (ABN) associated with a loan application.
/// </summary>
public class AustralianBusinessNumberDetail : BaseAuditableEntity
{
    // Section 9(i)

    /// <summary>
    /// Gets or sets the ID of the related 'Introduction to the Customer' entity for this ABN detail.
    /// </summary>
    public int? AustralianBusinessNumberDetail_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN).
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the date and time (UTC) when the business number was last modified.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? BusinessNumberLastModifiedUtc { get; set; }

    /// <summary>
    /// Gets or sets the status of the ABN.
    /// </summary>
    public string? ABNStatus { get; set; }

    /// <summary>
    /// Gets or sets the GST status of the business.
    /// </summary>
    public string? GSTStatus { get; set; }

    /// <summary>
    /// Gets or sets the name of the business entity.
    /// </summary>
    public string? BusinessEntityName { get; set; }

    /// <summary>
    /// Gets or sets the type of the business entity.
    /// </summary>
    public string? BusinessEntityType { get; set; }

    /// <summary>
    /// Gets or sets the start date of the ABN.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ABNStartDate { get; set; }

    /// <summary>
    /// Gets or sets the state where the business is located.
    /// </summary>
    public string? BusinessLocationState { get; set; }

    /// <summary>
    /// Gets or sets the postcode of the business location.
    /// </summary>
    public string? BusinessLocationPostcode { get; set; }

    /// <summary>
    /// Gets or sets the Australian Company Number (ACN) or other business registrations.
    /// </summary>
    [Comment("ACN or other")]
    public string? OtherRegistrationsACN { get; set; }

    /// <summary>
    /// Gets or sets the primary trading name of the business.
    /// </summary>
    public string? PrimaryTradingName { get; set; }

    /// <summary>
    /// Gets or sets the secondary trading name of the business.
    /// </summary>
    public string? SecondaryTradingName { get; set; }

    /// <summary>
    /// Gets or sets the associated 'Introduction to the Customer' entity for this ABN detail.
    /// </summary>
    public IntroductionToTheCustomer? AustralianBusinessNumberDetail_IntroductionToTheCustomer { get; set; }
}
