using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Specifies the types of borrowers, such as GoodBorrower or Specialist.
/// </summary>
public enum BorrowerType
{
    [Display(Name = nameof(GoodBorrower))]
    GoodBorrower = 1,

    [Display(Name = nameof(Specialist))]
    Specialist = 2
}
