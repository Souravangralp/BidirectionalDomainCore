namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the lending purpose details associated with a loan application, including purpose, amount, refinancing inclusion, and related codes.
/// </summary>
public class LendingPurpose : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the related loan detail for the lending purpose.
    /// </summary>
    public int? LendingPurpose_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the lending purpose includes refinancing.
    /// </summary>
    public bool ISIncludingRefinancing { get; set; }

    /// <summary>
    /// Gets or sets the amount associated with the loan purpose.
    /// </summary>
    public double? LoanPurposeAmount { get; set; }

    /// <summary>
    /// Gets or sets the ABS lending purpose description.
    /// </summary>
    public string? ABSLendingPurpose { get; set; }

    /// <summary>
    /// Gets or sets the ABS lending purpose code.
    /// </summary>
    public string? ABSLendingPurposeCode { get; set; }

    /// <summary>
    /// Gets or sets the loan detail entity associated with this lending purpose.
    /// </summary>
    public LoanDetail? LendingPurpose_LoanDetail { get; set; }
}
