namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification rules for consolidating liabilities, including various criteria such as loan type, consolidation range, arrears period, and assessment points.
/// </summary>
public class LateRepaymentHistoryClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the Loan Type identifier from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the loan status type general lookup identifier.
    /// </summary>
    public int? LoanEquifaxStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the points awarded for heedful (careful) account management within this liability classification.
    /// </summary>
    public int? HeedFulPoints { get; set; }
}
