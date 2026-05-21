namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Specifies the construction child filter types used to categorize construction or renovation projects.
/// </summary>
public enum ConstructionChildFilter
{
    /// <summary>
    /// Represents a renovation project with no structural changes.
    /// </summary>
    RenovationWithNoStructural = 17,

    /// <summary>
    /// Represents a renovation project that includes structural changes.
    /// </summary>
    RenovationWithStructural = 17,

    /// <summary>
    /// Represents a green construction project with environmentally friendly considerations.
    /// </summary>
    ConstructionGreen = 17,
}
