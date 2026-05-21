namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a credit enquiry made by or about a company, including relevant enquiry details and associations.
/// </summary>
public class CompanyCreditEnquiry : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier linking this enquiry to a specific introduction to the customer.
    /// </summary>
    public int? CompanyCreditEnquiry_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the date the enquiry was made, stored in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? EnquiryDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the name of the person or entity making the enquiry.
    /// </summary>
    public string? EnquirerName { get; set; }

    /// <summary>
    /// Gets or sets the reference number associated with the enquiry.
    /// </summary>
    public string? EnquiryReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of any co-borrower associated with the enquiry.
    /// </summary>
    public string? CoBorrowerName { get; set; }

    /// <summary>
    /// Gets or sets the requested loan amount for the enquiry.
    /// </summary>
    public double? LoanAmountRequested { get; set; }

    /// <summary>
    /// Gets or sets the type of account relevant to the enquiry.
    /// </summary>
    public string? AccountType { get; set; }

    /// <summary>
    /// Gets or sets the role held in the context of the enquiry.
    /// </summary>
    public string? RoleInEnquiry { get; set; }

    /// <summary>
    /// Gets or sets the reference to the associated IntroductionToTheCustomer entity.
    /// </summary>
    public IntroductionToTheCustomer? CompanyCreditEnquiry_IntroductionToTheCustomer { get; set; }
}
