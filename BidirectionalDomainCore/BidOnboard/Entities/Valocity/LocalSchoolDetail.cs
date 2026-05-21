namespace Bidirectional.DomainCore.BidOnboard.Entities.Valocity;

/// <summary>
/// Represents the details of a local school near a property, including name, level, and proximity information.
/// </summary>
public class LocalSchoolDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related property detail.
    /// </summary>
    public int? LocalSchoolDetail_PropertyDetailID { get; set; }

    /// <summary>
    /// Gets or sets the name of the local school.
    /// </summary>
    public string? SchoolName { get; set; }

    /// <summary>
    /// Gets or sets the education level of the school (e.g., Primary, Secondary).
    /// </summary>
    public string? Level { get; set; }

    /// <summary>
    /// Gets or sets the distance from the property to the school, in kilometers.
    /// </summary>
    public double? Distance { get; set; }

    /// <summary>
    /// Gets or sets the related property detail entity.
    /// </summary>
    public PropertyDetail? LocalSchoolDetail_PropertyDetail { get; set; }
}
