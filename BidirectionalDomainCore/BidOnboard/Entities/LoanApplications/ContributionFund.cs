namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a contribution fund entity associated with a loan application,
/// including details such as contribution type, amount, and related description.
/// </summary>
public class ContributionFund : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated loan application.
    /// </summary>
    public int? ContributionFund_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the contribution type from the GeneralLookUp table.
    /// </summary>
    public int? ContributionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the contribution fund has an associated loan.
    /// </summary>
    public bool HasLoanAssociated { get; set; }

    /// <summary>
    /// Gets or sets the amount of the contribution.
    /// </summary>
    public double? ContributionAmount { get; set; }

    /// <summary>
    /// Gets or sets the description of the contribution.
    /// </summary>
    public string? ContributionDescription { get; set; }

    /// <summary>
    /// Gets or sets the associated loan application entity for this contribution fund.
    /// </summary>
    public LoanApplication? ContributionFund_LoanApplication { get; set; }
}
