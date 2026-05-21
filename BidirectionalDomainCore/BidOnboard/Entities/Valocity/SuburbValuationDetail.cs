namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents detailed statistical valuation information for a suburb, including references to property details and quartile values.
/// </summary>
public class SuburbValuationDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related property detail for this suburb valuation.
    /// </summary>
    public int? SuburbValuationDetail_PropertyDetailID { get; set; }

    /// <summary>
    /// Gets or sets the lower quartile value of the suburb valuation.
    /// </summary>
    public double? LowerQuartile { get; set; }

    /// <summary>
    /// Gets or sets the median quartile value of the suburb valuation.
    /// </summary>
    public double? MedianQuartile { get; set; }

    /// <summary>
    /// Gets or sets the upper quartile value of the suburb valuation.
    /// </summary>
    public double? UpperQuartile { get; set; }

    /// <summary>
    /// Gets or sets the associated property detail entity for this suburb valuation detail.
    /// </summary>
    public PropertyDetail? SuburbValuationDetail_PropertyDetail { get; set; }
}
