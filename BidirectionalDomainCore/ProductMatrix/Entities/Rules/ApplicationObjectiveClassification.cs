namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of an application's objectives, including loan, occupancy, equity, and consolidation types.
/// </summary>
public class ApplicationObjectiveClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID for the loan type from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for the occupancy type from the CoreDB general lookup.
    /// </summary>
    public int? OccupancyType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for the equity type from the CoreDB general lookup.
    /// </summary>
    public int? EquityType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for the away bank type from the CoreDB general lookup.
    /// </summary>
    public int? AwayBankType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum number of loans for consolidation.
    /// </summary>
    [Comment("How many loans have for consolidation.")]
    public double? ConsolidateFrom { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of loans for consolidation.
    /// </summary>
    public double? ConsolidateTo { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with the objective classification.
    /// </summary>
    public int? HeedFulPoints { get; set; }
}
