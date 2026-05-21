namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details and parameters for a discharged bankrupt case,
/// including lookup identifiers, timeframes, and assessment points.
/// </summary>
public class DischargedBankruptClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier corresponding to the loan type from the CoreDB general lookup table.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lower boundary in months for the discharged bankrupt period.
    /// </summary>
    public double DischargeBankruptStartInMonths { get; set; }

    /// <summary>
    /// Gets or sets the upper boundary in months for the discharged bankrupt period.
    /// </summary>
    public double DischargeBankruptEndInMonths { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points attributed to this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
