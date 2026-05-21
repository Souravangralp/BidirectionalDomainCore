namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents a classification containing repayment and loan type configuration details for a product,
/// including various identifiers, time ranges, and scoring points.
/// </summary>
public class RepaymentTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the loan type from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the repayment type from the CoreDB general lookup.
    /// </summary>
    public int? RepaymentType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the rate type from the CoreDB general lookup.
    /// </summary>
    public int? RateType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the total repayment time in years.
    /// </summary>
    public int? RepaymentTimeInYears { get; set; }

    /// <summary>
    /// Gets or sets the starting value (inclusive) for the rate time period in years.
    /// </summary>
    public int? FromRateTimeInYears { get; set; }

    /// <summary>
    /// Gets or sets the ending value (inclusive) for the rate time period in years.
    /// </summary>
    public int? ToRateTimeInYears { get; set; }

    /// <summary>
    /// Gets or sets the heedful points associated with the classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
