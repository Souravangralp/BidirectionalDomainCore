namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents a classification for credit index rules, associating loan types, credit agency types, and relevant credit scoring information.
/// </summary>
public class CreditIndexClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the loan type from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the ID of the credit index agency type from the CoreDB general lookup.
    /// </summary>
    public int? CreditIndexAgencyType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum credit score required for this classification.
    /// </summary>
    public double? MinimumCreditScore { get; set; }

    /// <summary>
    /// Gets or sets the heedful points associated with this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
