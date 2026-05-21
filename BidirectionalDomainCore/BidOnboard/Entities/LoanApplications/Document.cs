namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a document associated with a loan application, including metadata, relations, and relevant document details.
/// </summary>
public class Document : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the applicant ID associated with this document.
    /// </summary>
    public int? Document_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the introduction to the customer ID associated with this document.
    /// </summary>
    public int? Document_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the industry classification ID related to this document.
    /// </summary>
    public int? Document_IndustryClassificationID { get; set; }

    /// <summary>
    /// Gets or sets the type of the document.
    /// </summary>
    public int? Type { get; set; }

    /// <summary>
    /// Gets or sets the name of the document.
    /// </summary>
    public string? DocumentName { get; set; }

    /// <summary>
    /// Gets or sets the state in which the document was issued.
    /// </summary>
    public string? DocumentIssuedState { get; set; }

    /// <summary>
    /// Gets or sets the country in which the document was issued.
    /// </summary>
    public string? DocumentIssuedCountry { get; set; }

    /// <summary>
    /// Gets or sets additional comments or notes about the document.
    /// </summary>
    public string? DocumentComments { get; set; }

    /// <summary>
    /// Gets or sets the size information of the document.
    /// </summary>
    public string? DocumentSize { get; set; }

    /// <summary>
    /// Gets or sets the file path of the document.
    /// </summary>
    public string? DocumentPath { get; set; }

    /// <summary>
    /// Gets or sets the code and description associated with the document.
    /// </summary>
    public string? DocumentCodeAndDescription { get; set; }

    /// <summary>
    /// Gets or sets the UTC date the document was received.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? DocumentReceivedUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date the document was processed.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? DocumentProcessedUtc { get; set; }

    /// <summary>
    /// Gets or sets the number of pages in the document.
    /// </summary>
    public int? DocumentNumberOfPages { get; set; }

    /// <summary>
    /// Gets or sets the effective UTC date of the document.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? DocumentEffectiveDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the expiry UTC date of the document.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? DocumentExpiryDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the issue UTC date of the document.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? DocumentIssueDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the applicant associated with this document.
    /// </summary>
    public Applicant? Document_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the introduction to the customer entity related to this document.
    /// </summary>
    public IntroductionToTheCustomer? Document_IntroductionToTheCustomer { get; set; }

    /// <summary>
    /// Gets or sets the industry classification entity for this document.
    /// </summary>
    public IndustryClassification? Document_IndustryClassification { get; set; }
}
