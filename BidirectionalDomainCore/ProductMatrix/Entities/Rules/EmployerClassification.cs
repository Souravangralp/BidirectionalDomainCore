using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.ProductMatrix.Entities.Products;

namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification for an employer, including council zoning and employer type information.
/// </summary>
public class EmployerClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the council zoning type ID associated with the employer classification.
    /// </summary>
    public int? EmployerClassification_CouncilZoningTypeID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the employer type.
    /// </summary>
    public int? EmployerType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the heedful points assigned to the employer classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }

    /// <summary>
    /// Gets or sets the council zoning category related to the employer classification.
    /// </summary>
    public CouncilZoningCategory? EmployerClassification_CouncilZoningType { get; set; }

    /// <summary>
    /// Gets or sets the general lookup entity for the employer type.
    /// </summary>
    [ForeignKey(nameof(EmployerType_GeneralLookUpID))]
    public GeneralLookup? EmployerType_GeneralLookUp { get; set; }
}
