namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a shareholding record for a company within a loan application,
/// including share class details, issued share count, related company entity, and payment information.
/// </summary>
public class CompanyShare : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related company applicant.
    /// </summary>
    public int? CompanyShare_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the introduction to the customer associated with this share.
    /// </summary>
    public int? CompanyShare_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the class of shares held.
    /// </summary>
    [EncryptColumn]
    public string? ShareClass { get; set; }

    /// <summary>
    /// Gets or sets the count of shares issued.
    /// </summary>
    [EncryptColumn]
    public string? SharesIssuedCount { get; set; }

    /// <summary>
    /// Gets or sets the paid-up capital amount for the shares.
    /// </summary>
    [EncryptColumn]
    public string? PaidUpCapital { get; set; }

    /// <summary>
    /// Gets or sets the document number associated with the shareholding.
    /// </summary>
    [EncryptColumn]
    public string? ShareDocumentNumber { get; set; }

    /// <summary>
    /// Gets or sets the total amount due or payable for the shares.
    /// </summary>
    [EncryptColumn]
    public string? TotalAmountDueORPayable { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity.
    /// </summary>
    public CompanyApplicant? CompanyShare_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the related introduction to the customer entity.
    /// </summary>
    public IntroductionToTheCustomer? CompanyShare_IntroductionToTheCustomer { get; set; }
}
