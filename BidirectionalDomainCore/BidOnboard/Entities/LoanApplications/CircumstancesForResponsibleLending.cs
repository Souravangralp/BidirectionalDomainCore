namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the set of circumstances and factors considered for responsible lending in a loan application,
/// including anticipated changes, mitigants, and related need analysis.
/// </summary>
public class CircumstancesForResponsibleLending : BaseAuditableEntity  // FutureCircumstances -> ResponsibleLending based on XML
{
    /// <summary>
    /// Gets or sets the foreign key identifier for the associated Need Analysis entity.
    /// </summary>
    public int? CircumstancesForResponsibleLending_NeedsAnalysesID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether anticipated changes are present in the borrower's circumstances.
    /// </summary>
    public bool ISAnticipatedChanges { get; set; }

    /// <summary>
    /// Gets or sets the list of mitigants associated with responsible lending circumstances.
    /// </summary>
    public IList<Mitigant> Mitigants { get; set; } = new List<Mitigant>();

    /// <summary>
    /// Gets or sets the list of significant changes expected in the borrower's circumstances.
    /// </summary>
    public IList<SignificantChange> SignificantChanges { get; set; } = new List<SignificantChange>();

    /// <summary>
    /// Gets or sets the associated Need Analysis entity for responsible lending.
    /// </summary>
    public NeedsAnalyses? CircumstancesForResponsibleLending_NeedsAnalyses { get; set; }
}
