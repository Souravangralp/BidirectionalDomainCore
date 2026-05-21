namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of a borrower's financial condition, including loan type, combination count, and related points.
/// </summary>
public class BorrowerFinancialConditionClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the required number of combinations associated with the classification.
    /// </summary>
    public required int CombinationCount { get; set; }

    /// <summary>
    /// Gets or sets the heedful points related to the borrower's financial condition.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
