namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of residency types and their associated loan and LVR criteria.
/// </summary>
public class ResidencyTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the loan type from the CoreDB general look-up.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the residency type from the CoreDB general look-up.
    /// </summary>
    public int? ResidencyType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum loan-to-value ratio (LVR) for this classification.
    /// </summary>
    public double MinimumLVR { get; set; }

    /// <summary>
    /// Gets or sets the maximum loan-to-value ratio (LVR) for this classification.
    /// </summary>
    public double MaximumLVR { get; set; }

    /// <summary>
    /// Gets or sets the number of HeedFul points associated with this classification.
    /// </summary>
    public int? HeedFulPoints { get; set; }
}
