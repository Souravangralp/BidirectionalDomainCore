namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents the sale history details of a property, including sale price, relevant dates, and associated property information.
/// </summary>
public class PropertySaleHistoryDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related property detail.
    /// </summary>
    public int? PropertySaleDetail_PropertyDetailID { get; set; }

    /// <summary>
    /// Gets or sets the sale price of the property.
    /// </summary>
    public double? SalePrice { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the settlement occurred.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SettlementDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of the property sale.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SaleDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the associated property detail for this sale history record.
    /// </summary>
    public PropertyDetail? PropertySaleDetail_PropertyDetail { get; set; }
}
