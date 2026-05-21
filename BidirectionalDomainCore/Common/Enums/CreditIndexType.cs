using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.Common.Enums;

/// <summary>
/// Represents the type of credit index.
/// </summary>
public enum CreditIndexType
{
    /// <summary>
    /// Equifax credit index type.
    /// </summary>
    [Display(Name = nameof(Equifax))]
    Equifax = 1,

    /// <summary>
    /// Illion credit index type.
    /// </summary>
    [Display(Name = nameof(Illion))]
    Illion = 2,
}
