using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Specifies the types of documentation available.
/// </summary>
public enum DocTypes
{
    /// <summary>
    /// Represents alternative documentation.
    /// </summary>
    [Display(Name = nameof(AltDoc))]
    AltDoc = 1,

    /// <summary>
    /// Represents full documentation.
    /// </summary>
    [Display(Name = nameof(FullDoc))]
    FullDoc = 2,

    /// <summary>
    /// Represents limited or low documentation.
    /// </summary>
    [Display(Name = nameof(LowDoc))]
    LowDoc = 3,

    /// <summary>
    /// Represents no documentation.
    /// </summary>
    [Display(Name = nameof(NoDoc))]
    NoDoc = 4,
}
