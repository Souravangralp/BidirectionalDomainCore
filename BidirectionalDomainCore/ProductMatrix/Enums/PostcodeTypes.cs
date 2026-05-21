using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Specifies the different types of postcode categorization within the Bidirectional Product Matrix API.
/// </summary>
public enum PostcodeTypes
{
    /// <summary>
    /// Indicates that the postcode is excluded from consideration.
    /// </summary>
    [Display(Name = nameof(Excluded))]
    Excluded = 1999,
}
