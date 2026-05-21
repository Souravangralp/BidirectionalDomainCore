namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the circumstances related to a specific loan applicant, providing links to need analysis and unique identification information.
/// </summary>
public class CircumstancesForApplicant : BaseAuditableEntity // FutureCircumstances -> Applicant Based on XML
{
    /// <summary>
    /// Gets or sets the identifier for the associated need analysis specific to the applicant's circumstances.
    /// </summary>
    public int? CircumstancesForApplicant_NeedsAnalysesID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the loan applicant.
    /// </summary>
    public string? ApplicantUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the need analysis details associated with the applicant's circumstances.
    /// </summary>
    public NeedsAnalyses? CircumstancesForApplicant_NeedsAnalyses { get; set; }
}
