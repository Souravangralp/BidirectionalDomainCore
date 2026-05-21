namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification rule for a specific type of other income, including its associated loan and other income type lookup IDs, and heedful points.
/// </summary>
public class OtherIncomeTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the core database general lookup ID for the loan type associated with this other income classification.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the core database general lookup ID for the type of other income being classified.
    /// </summary>
    public int? OtherIncomeType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the heedful points assigned to this classification of other income.
    /// </summary>
    public int? HeedFulPoints { get; set; }
}
