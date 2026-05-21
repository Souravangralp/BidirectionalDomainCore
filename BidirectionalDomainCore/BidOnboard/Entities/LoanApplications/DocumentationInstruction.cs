namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents instructions related to documentation for a loan application, including methods, recipients, and related entities.
/// </summary>
public class DocumentationInstruction : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related LoanDetail for this documentation instruction.
    /// </summary>
    public int? DocumentationInstruction_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related Summary for this documentation instruction.
    /// </summary>
    public int? DocumentationInstruction_LoanApplicationSummaryID { get; set; }

    /// <summary>
    /// Gets or sets the method by which documentation will be provided.
    /// </summary>
    public string? DocumentationMethod { get; set; }

    /// <summary>
    /// Gets or sets the recipient of the documentation.
    /// </summary>
    public string? DocumentRecipient { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the nominated authority for this documentation.
    /// </summary>
    public string? NominatedAuthorityUniqueID { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the related LoanDetail entity for this documentation instruction.
    /// </summary>
    public LoanDetail? DocumentationInstruction_LoanDetail { get; set; }

    /// <summary>
    /// Gets or sets the related Summary entity for this documentation instruction.
    /// </summary>
    public LoanApplicationSummary? DocumentationInstruction_LoanApplicationSummary { get; set; }
}
