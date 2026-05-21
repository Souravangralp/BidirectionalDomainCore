namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents information about the beneficial ownership structure of a company within a loan application,
/// including ownership percentages and beneficial/non-beneficial help amounts.
/// </summary>
public class CompanyBeneficialOwnership : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related IntroductionToTheCustomer entity.
    /// </summary>
    public int? CompanyBeneficialOwnership_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the name and address of the beneficial owner.
    /// </summary>
    public string? BeneficialOwnerNameAndAddress { get; set; }

    /// <summary>
    /// Gets or sets the total percentage of ownership held by the beneficial owner.
    /// </summary>
    public double? TotalOwnershipPercentage { get; set; } // Total (%)

    /// <summary>
    /// Gets or sets the percentage representing non-beneficial help provided.
    /// </summary>
    public double? NonBeneficialHelpAmount { get; set; } // Non beneficially help (%)

    /// <summary>
    /// Gets or sets the percentage representing beneficial help provided.
    /// </summary>
    public double? BeneficialHelpAmount { get; set; } // Beneficially help (%)

    /// <summary>
    /// Gets or sets the related IntroductionToTheCustomer entity for the company beneficial ownership.
    /// </summary>
    public IntroductionToTheCustomer? CompanyBeneficialOwnership_IntroductionToTheCustomer { get; set; }
}
