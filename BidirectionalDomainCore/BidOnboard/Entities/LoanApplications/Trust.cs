using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a trust applicant in a loan application, including details about the trust, trustee, and its purpose.
/// </summary>
public class Trust : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the trust type and this is gent from generalLook up.
    /// </summary>
    public int? TrustType_GeneralLookUpID { get; set; } // Discretionary / Unit / Hybrid / SMSF

    /// <summary>
    /// Gets or sets the name of the trust.
    /// </summary>
    public string? TrustName { get; set; }

    /// <summary>
    /// Gets or sets the name of the settlor of the trust.
    /// </summary>
    public string? SettlorName { get; set; }

    /// <summary>
    /// Gets or sets the stated purpose of the trust.
    /// </summary>
    public string? TrustPurpose { get; set; }

    public decimal? AnnualIncome { get; set; }

    public decimal? NetAssets { get; set; }

    public decimal? Liabilities { get; set; }

    public DateOnly? EstablishmentDate { get; set; }

    public string? TrustDeedURL { get; set; }

    public string? TrustDeedVersion { get; set; }

    public decimal? SettlementAmount { get; set; }

    /// <summary>
    /// Gets or sets the applicant's Equifax credit score.
    /// </summary>
    public int? EquifaxCreditScore { get; set; }

    /// <summary>
    /// Gets or sets the structure type of the trust.
    /// </summary>
    public string? TrustStructure { get; set; }

    public Address? Address { get; set; }

    public BusinessIdentifier? BusinessIdentifier { get; set; }

    public List<Applicant> Applicants { get; set; } = []; // Applicant may be director/manager and other user.

    [InverseProperty(nameof(LoanApplicationApplicantMapper.LoanApplicationApplicantMapper_Trust))]
    public IList<LoanApplicationApplicantMapper> LoanApplicationApplicantMappers { get; set; } = [];
}
