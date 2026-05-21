namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents the monthly detail data for a suburb, including property specifics and measurement information.
/// </summary>
public class SuburbMonthlyDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated PropertyDetail for this suburb monthly detail.
    /// </summary>
    public int? SuburbMonthlyDetail_PropertyDetailID { get; set; }

    /// <summary>
    /// Gets or sets the name of the property type.
    /// </summary>
    public string? PropertyTypeName { get; set; }

    /// <summary>
    /// Gets or sets the type of measurement (e.g., sales volume, median price).
    /// </summary>
    public string? MeasureType { get; set; }

    /// <summary>
    /// Gets or sets the month in UTC for which the measurement applies.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? MeasureMonthUtc { get; set; }

    /// <summary>
    /// Gets or sets the value of the measurement for the specified month.
    /// </summary>
    public int? MeasureValue { get; set; }

    /// <summary>
    /// Gets or sets the associated PropertyDetail entity.
    /// </summary>
    public PropertyDetail? SuburbMonthlyDetail_PropertyDetail { get; set; }
}
