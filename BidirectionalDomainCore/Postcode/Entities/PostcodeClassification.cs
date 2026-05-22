namespace Bidirectional.DomainCore.Postcode.Entities;

/// <summary>
/// Represents the classification details associated with a postcode, including security, category, and rating types.
/// </summary>
public class PostcodeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the high security type from the general lookup.
    /// </summary>
    public int? HighSecurityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the postcode category type from the general lookup.
    /// </summary>
    public int? PCCategoryType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the Standard and Poor type from the general lookup.
    /// </summary>
    public int? StandardAndPoorType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the descriptive name of the postcode classification.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the integer value associated with the postcode classification.
    /// </summary>
    public required int Value { get; set; }
}
