namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the classification of an industry associated with a loan application, 
/// including related descriptions, documents, and associated entities.
/// </summary>
public class IndustryClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated company applicant for the industry classification.
    /// </summary>
    public int? IndustryClassification_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier mapping the industry classification to the customer introduction.
    /// </summary>
    public int? IndustryClassification_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the PPSR (Personal Property Securities Register) specific description of the industry.
    /// </summary>
    public string? PPSRDescription { get; set; }

    /// <summary>
    /// Gets or sets the collection of documents associated with the industry classification.
    /// </summary>
    public List<Document> Documents { get; set; } = new List<Document>();

    /// <summary>
    /// Gets or sets the related company applicant entity for the industry classification.
    /// </summary>
    public CompanyApplicant? IndustryClassification_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the introduction to the customer associated with the industry classification.
    /// </summary>
    public IntroductionToTheCustomer? IndustryClassification_IntroductionToTheCustomer { get; set; }
}
