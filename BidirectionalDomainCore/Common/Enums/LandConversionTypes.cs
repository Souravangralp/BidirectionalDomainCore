using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.Common.Enums;

/// <summary>
/// Specifies the types of land conversion units.
/// </summary>
public enum LandConversionTypes
{
    /// <summary>
    /// Represents a measurement in square meters.
    /// </summary>
    [Display(Name = nameof(MeterSquare))]
    MeterSquare = 1,

    /// <summary>
    /// Represents a measurement in acres.
    /// </summary>
    [Display(Name = nameof(Acres))]
    Acres = 2,
}
