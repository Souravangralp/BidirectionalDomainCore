namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Represents the classification of a renovation as either structural or non-structural.
/// </summary>
public enum RenovationTypeClassification
{
    /// <summary>
    /// Renovation that affects the structure of the building.
    /// </summary>
    Structural = 1,

    /// <summary>
    /// Renovation that does not affect the structure of the building.
    /// </summary>
    NonStructural = 2,
}
