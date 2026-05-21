namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the purpose of a loan application, including requested amount, description, purpose type, and its relationship to a need analysis.
/// </summary>
public class ApplicationPurpose : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier linking this application purpose to a specific need analysis.
    /// </summary>
    public int? ApplicationPurpose_NeedsAnalysesID { get; set; }

    /// <summary>
    /// Gets or sets the amount requested for the loan application.
    /// </summary>
    public double RequestedAmount { get; set; }

    /// <summary>
    /// Gets or sets the specific purpose for which the loan is being applied.
    /// </summary>
    public string? Purpose { get; set; }

    /// <summary>
    /// Gets or sets the need analysis entity related to this application purpose.
    /// </summary>
    public NeedsAnalyses? ApplicationPurpose_NeedsAnalyses { get; set; }
}
