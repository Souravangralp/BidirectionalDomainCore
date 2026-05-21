using Bidirectional.DomainCore.ProductMatrix.Entities.Products;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of age for credit report evaluation, including applicable zoning type and range of days.
/// </summary>
public class AgeCreditReportClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated council zoning type.
    /// </summary>
    public int? AgeCreditReportClassification_CouncilZoningTypeID { get; set; }

    /// <summary>
    /// Gets or sets the starting day of the age range for classification.
    /// </summary>
    public required int FromDays { get; set; }

    /// <summary>
    /// Gets or sets the ending day of the age range for classification.
    /// </summary>
    public required int ToDays { get; set; }

    /// <summary>
    /// Gets or sets the heedful points associated with this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }

    /// <summary>
    /// Gets or sets the related council zoning category for this classification.
    /// </summary>
    public CouncilZoningCategory? AgeCreditReportClassification_CouncilZoningType { get; set; }
}
