namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a listing of documents associated with a company for a loan application, 
/// including the related introduction to the customer.
/// </summary>
public class CompanyDocumentListing : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the associated IntroductionToTheCustomer entity.
    /// </summary>
    public int? CompanyDocumentListing_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the collection of documents related to the company.
    /// </summary>
    public List<Document> Documents { get; set; } = new List<Document>();

    /// <summary>
    /// Gets or sets the IntroductionToTheCustomer entity related to the company document listing.
    /// </summary>
    public IntroductionToTheCustomer? CompanyDocumentListing_IntroductionToTheCustomer { get; set; }
}
