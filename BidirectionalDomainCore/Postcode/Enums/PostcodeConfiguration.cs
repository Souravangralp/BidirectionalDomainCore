namespace Bidirectional.DomainCore.Postcode.Enums;

/// <summary>
/// Provides configuration values related to postcode processing and ranges.
/// </summary>
public enum PostcodeConfiguration
{
    /// <summary>
    /// Indicates that postcode classifications are defined up to the 9999 range.
    /// </summary>
    [Comment("We have postcode classifications till 9999 range.")]
    PostcodeRange = 3200,
}

/// <summary>
/// Specifies the classification types that can be assigned to a postcode.
/// </summary>
public enum PostCodeClassificationType
{
    /// <summary>
    /// Represents a metropolitan area classification.
    /// </summary>
    Metro = 1,

    /// <summary>
    /// Represents a non-metropolitan area classification.
    /// </summary>
    NonMetro = 2,

    /// <summary>
    /// Represents an inner-city area classification.
    /// </summary>
    InnerCity = 3,

    /// <summary>
    /// Represents a postcode that is excluded from classification.
    /// </summary>
    Excluded = 4,

    /// <summary>
    /// Represents a high-density area classification.
    /// </summary>
    HighDensity = 5,

    /// <summary>
    /// Represents a selected non-metropolitan area classification.
    /// </summary>
    SelectedNonMetro = 6,

    /// <summary>
    /// Represents a metropolitan plus area classification.
    /// </summary>
    MetroPlus = 7,

    /// <summary>
    /// Represents category 1 classification.
    /// </summary>
    Category1 = 8,

    /// <summary>
    /// Represents category 2 classification.
    /// </summary>
    Category2 = 9,

    /// <summary>
    /// Represents category 3 classification.
    /// </summary>
    Category3 = 10,

    /// <summary>
    /// Represents a postcode that has not been listed in classifications.
    /// </summary>
    UnListed = 11,
}
