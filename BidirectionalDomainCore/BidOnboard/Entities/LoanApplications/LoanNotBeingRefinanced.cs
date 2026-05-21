namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents details for a loan linked to a loan application that is not subject to refinancing.
/// </summary>
public class LoanNotBeingRefinanced : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated loan application.
    /// </summary>
    public int? LoanNotBeingRefinanced_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the type or category of the loan.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the name of the lending institution for this loan.
    /// </summary>
    public string? Lender { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance currently owed on the loan.
    /// </summary>
    public string? CurrentBalance { get; set; }

    /// <summary>
    /// Gets or sets the maximum allowable balance or credit limit for the loan.
    /// </summary>
    public string? Limit { get; set; }

    /// <summary>
    /// Gets or sets information about the loan repayment arrangement.
    /// </summary>
    public string? Repayment { get; set; }

    /// <summary>
    /// Gets or sets the related loan application entity instance.
    /// </summary>
    public LoanApplication? LoanNotBeingRefinanced_LoanApplication { get; set; }
}
