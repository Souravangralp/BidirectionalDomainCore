namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the refinancing consolidation details within a loan application.
/// </summary>
public class RefinancingConsolidation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related need analysis for refinancing consolidation.
    /// </summary>
    public int? RefinancingConsolidation_NeedsAnalysesID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the high interest risk has been explained.
    /// </summary>
    public bool HASExplainedHighInterestRisk { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the high loan term risk has been explained.
    /// </summary>
    public bool HASExplainedHighLoanTermRisk { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is a plan to close the credit card.
    /// </summary>
    public bool ISPlanToCloseCreditCard { get; set; }

    /// <summary>
    /// Gets or sets the details of the plan to close the credit card, if any.
    /// </summary>
    public string? DetailsOfCreditCardPlan { get; set; }

    /// <summary>
    /// Gets or sets the related need analysis entity for refinancing consolidation.
    /// </summary>
    public NeedsAnalyses? RefinancingConsolidation_NeedsAnalyses { get; set; }

    /// <summary>
    /// Gets or sets the reason associated with the refinancing consolidation.
    /// </summary>
    public ApprovalReason? ApprovalReason { get; set; }
}
