namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the mapping between a loan application and an applicant,
/// including whether the applicant is the primary applicant.
/// </summary>
public class LoanApplicationApplicantMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan application.
    /// </summary>
    public int LoanApplicationApplicantMapper_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated applicant.
    /// </summary>
    public int? LoanApplicationApplicantMapper_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated applicant.
    /// </summary>
    public int? LoanApplicationApplicantMapper_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated applicant.
    /// </summary>
    public int? LoanApplicationApplicantMapper_TrustID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is the primary applicant.
    /// </summary>
    public bool ISPrimaryApplicant { get; set; }

    /// <summary>
    /// Gets or sets the loan application entity linked to this mapping.
    /// </summary>
    [InverseProperty(nameof(LoanApplication.LoanApplicationApplicantMappers))]
    public LoanApplication? LoanApplicationApplicantMapper_LoanApplication { get; set; }

    /// <summary>
    /// Gets or sets the applicant entity linked to this mapping.
    /// </summary>
    [InverseProperty(nameof(Applicant.LoanApplicationApplicantMappers))]
    public Applicant? LoanApplicationApplicantMapper_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the company applicant entity linked to this mapping.
    /// </summary>

    [InverseProperty(nameof(CompanyApplicant.LoanApplicationApplicantMappers))]
    public CompanyApplicant? LoanApplicationApplicantMapper_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the trust entity linked to this mapping.
    /// </summary>
    [InverseProperty(nameof(Trust.LoanApplicationApplicantMappers))]
    public Trust? LoanApplicationApplicantMapper_Trust { get; set; }
}
