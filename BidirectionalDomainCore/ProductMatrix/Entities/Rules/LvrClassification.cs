namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the Loan-to-Value Ratio (LVR) classification entity, 
/// encapsulating categorization criteria for loan products based on various parameters and lookups.
/// </summary>
public class LvrClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for manager discretion type.
    /// </summary>
    public int? ManagerDiscretionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for series type.
    /// </summary>
    public int? SeriesType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for loan purpose type.
    /// </summary>
    public int? LoanPurposeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for document type.
    /// </summary>
    public int? DocType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for loan type.
    /// </summary>
    public int? LoanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for occupancy type.
    /// </summary>
    public int? OccupancyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum allowed Loan-to-Value Ratio (LVR) percentage.
    /// </summary>
    public required double MinimumLVR { get; set; }

    /// <summary>
    /// Gets or sets the maximum allowed Loan-to-Value Ratio (LVR) percentage.
    /// </summary>
    public required double MaximumLVR { get; set; }

    /// <summary>
    /// Gets or sets the heedful points associated with this LVR classification.
    /// </summary>
    public int? HeedFulPoints { get; set; }
}
