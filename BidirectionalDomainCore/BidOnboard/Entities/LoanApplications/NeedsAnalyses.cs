namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a need analysis for a loan application, capturing key details such as purpose, benefits, circumstances, and related entities.
/// </summary>
public class NeedsAnalyses : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the related loan application for the need analysis.
    /// </summary>
    public int? NeedsAnalyses_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets a summary description of the purpose for the loan application.
    /// </summary>
    public string? PurposeSummary { get; set; }

    /// <summary>
    /// Gets or sets the description of the benefits to the applicant.
    /// </summary>
    public string? BenefitsToApplicant { get; set; }

    /// <summary>
    /// Gets or sets information about potential future circumstances related to the application.
    /// </summary>
    public string? FutureCircumstance { get; set; }

    /// <summary>
    /// Gets or sets the length of the loan term.
    /// </summary>
    public string? LoanTermLength { get; set; }

    /// <summary>
    /// Gets or sets the unit used for the loan term length (e.g., years, months).
    /// </summary>
    public string? LoanTermUnit { get; set; }

    /// <summary>
    /// Gets or sets the primary purpose of the loan application.
    /// </summary>
    public string? PrimaryApplicationPurpose { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the interview location.
    /// </summary>
    public string? InterviewLocationUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the date of the interview in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? InterviewDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the preferences related to the need analysis.
    /// </summary>
    public LoanApplicationPreference? LoanApplicationPreference { get; set; }

    /// <summary>
    /// Gets or sets the circumstances for responsible lending associated with this need analysis.
    /// </summary>
    public CircumstancesForResponsibleLending? CircumstancesForResponsibleLandings { get; set; }

    /// <summary>
    /// Gets or sets refinancing and consolidation details for the loan application.
    /// </summary>
    public RefinancingConsolidation? RefinancingConsolidations { get; set; }

    /// <summary>
    /// Gets or sets a list of applicant circumstances associated with responsible lending.
    /// </summary>
    public IList<CircumstancesForApplicant> CircumstancesForApplicants { get; set; } = new List<CircumstancesForApplicant>();

    /// <summary>
    /// Gets or sets a list of purposes for the loan application.
    /// </summary>
    public IList<ApplicationPurpose> ApplicationPurposes { get; set; } = new List<ApplicationPurpose>();

    /// <summary>
    /// Gets or sets a list of retirement details for each applicant.
    /// </summary>
    public IList<ApplicantRetirementDetail> ApplicantRetirementDetails { get; set; } = new List<ApplicantRetirementDetail>();

    /// <summary>
    /// Gets or sets the associated loan application entity for the need analysis.
    /// </summary>
    public LoanApplication? NeedsAnalyses_LoanApplication { get; set; }
}
