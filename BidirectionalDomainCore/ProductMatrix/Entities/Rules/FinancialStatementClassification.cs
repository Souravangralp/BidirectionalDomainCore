namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details for a financial statement,
/// including loan type, eligibility period in months, and the assigned heedful points.
/// </summary>
public class FinancialStatementClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the loan type from the CoreDB GeneralLookUp table.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the starting month of the classification's applicability period.
    /// </summary>
    public double? FromMonth { get; set; }

    /// <summary>
    /// Gets or sets the ending month of the classification's applicability period.
    /// </summary>
    public double? ToMonth { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points assigned to this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
