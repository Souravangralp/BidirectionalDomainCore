namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents the estimate details for a consumer property valuation, including confidence levels and value estimates.
/// </summary>
public class ConsumerEstimateDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related property detail.
    /// </summary>
    public int? ConsumerEstimateDetail_PropertyDetailID { get; set; }

    /// <summary>
    /// Gets or sets the confidence level of the estimate.
    /// </summary>
    public double? ConfidenceLevel { get; set; }

    /// <summary>
    /// Gets or sets the lower bound of the estimated property value.
    /// </summary>
    public double? LowerEstimateValue { get; set; }

    /// <summary>
    /// Gets or sets the upper bound of the estimated property value.
    /// </summary>
    public double? UpperEstimateValue { get; set; }

    /// <summary>
    /// Gets or sets the related property detail entity.
    /// </summary>
    public PropertyDetail? ConsumerEstimateDetail_PropertyDetail { get; set; }
}
