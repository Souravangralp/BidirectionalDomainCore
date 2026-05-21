namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents a classification for document types, including associated loan types, loan term restrictions, and related points.
/// </summary>
public class DocTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the document type from CoreDB.
    /// </summary>
    public int? DocType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from CoreDB.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum loan term in years required for this document type classification.
    /// </summary>
    public required double MinimumLoanTermInYears { get; set; }

    /// <summary>
    /// Gets or sets the maximum loan term in years permitted for this document type classification.
    /// </summary>
    public required double MaximumLoanTermInYears { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with this classification, if any.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
