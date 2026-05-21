namespace Bidirectional.DomainCore.Postcode.Entities.Mappers;

/// <summary>
/// Represents the association between a postcode and its classification.
/// </summary>
public class PostcodeClassificationMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated postcode classification.
    /// </summary>
    public int? PostcodeClassificationMapper_PostcodeClassificationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated postcode.
    /// </summary>
    public int? PostcodeClassificationMapper_PostcodeID { get; set; }

    /// <summary>
    /// Gets or sets the related postcode entity.
    /// </summary>
    public Postcode? PostcodeClassificationMapper_Postcode { get; set; }

    /// <summary>
    /// Gets or sets the related postcode classification entity.
    /// </summary>
    public PostcodeClassification? PostcodeClassificationMapper_PostcodeClassification { get; set; }
}
