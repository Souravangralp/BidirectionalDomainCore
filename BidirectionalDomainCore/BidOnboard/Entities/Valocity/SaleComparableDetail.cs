namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents the details of a property used as a comparable sale, including reference to the related property detail and future extensible fields.
/// </summary>
public class SaleComparableDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related property detail.
    /// </summary>
    public int? SaleComparableDetail_PropertyDetailID { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information related to the sale comparable.
    /// </summary>
    public string? Extrafield1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information related to the sale comparable.
    /// </summary>
    public string? Extrafield2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information related to the sale comparable.
    /// </summary>
    public string? Extrafield3 { get; set; }

    /// <summary>
    /// Gets or sets the related property detail entity for this comparable sale.
    /// </summary>
    public PropertyDetail? SaleComparableDetail_PropertyDetail { get; set; }
}
