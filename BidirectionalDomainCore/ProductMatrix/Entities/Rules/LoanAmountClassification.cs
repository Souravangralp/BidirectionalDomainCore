namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of a loan amount based on various loan criteria and types.
/// </summary>
public class LoanAmountClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup identifier for the manager discretion type.
    /// </summary>
    public int? ManagerDiscretionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the series type.
    /// </summary>
    public int? SeriesType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the loan purpose type.
    /// </summary>
    public int? LoanPurposeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the document type.
    /// </summary>
    public int? DocType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the loan type.
    /// </summary>
    public int? LoanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the occupancy type.
    /// </summary>
    public int? OccupancyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lower bound of the loan amount range.
    /// </summary>
    public double FromAmount { get; set; }

    /// <summary>
    /// Gets or sets the upper bound of the loan amount range.
    /// </summary>
    public double ToAmount { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with the loan classification.
    /// </summary>
    public int? HeedFulPoints { get; set; }
}
