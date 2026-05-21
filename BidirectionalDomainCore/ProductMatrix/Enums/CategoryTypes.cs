using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Specifies the available product category types within the Bidirectional Product Matrix API domain.
/// </summary>
public enum CategoryTypes
{
    /// <summary>
    /// Represents the first category type.
    /// </summary>
    [Display(Name = nameof(Category1))]
    Category1 = 1,

    /// <summary>
    /// Represents the second category type.
    /// </summary>
    [Display(Name = nameof(Category1))]
    Category2 = 2,

    /// <summary>
    /// Represents the third category type.
    /// </summary>
    [Display(Name = nameof(Category3))]
    Category3 = 3,

    /// <summary>
    /// Represents the fourth category type.
    /// </summary>
    [Display(Name = nameof(Category4))]
    Category4 = 4,
}
