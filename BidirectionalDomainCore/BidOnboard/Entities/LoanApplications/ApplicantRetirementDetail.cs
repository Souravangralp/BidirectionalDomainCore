namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the retirement details of an applicant, including target retirement age, unique applicant identifier, and associated need analysis information.
/// </summary>
public class ApplicantRetirementDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier linking the retirement detail to a specific need analysis.
    /// </summary>
    public int? ApplicantRetirementDetail_NeedsAnalysesID { get; set; }

    /// <summary>
    /// Gets or sets the applicant's target retirement age.
    /// </summary>
    public string? TargetRetirementAge { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the applicant related to this retirement detail.
    /// </summary>
    public string? ApplicantUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the repayment options associated with the retirement detail.
    /// </summary>
    public RepaymentOption? RepaymentOptions { get; set; }

    /// <summary>
    /// Gets or sets the related need analysis entity for this retirement detail.
    /// </summary>
    public NeedsAnalyses? ApplicantRetirementDetail_NeedsAnalyses { get; set; }
}
