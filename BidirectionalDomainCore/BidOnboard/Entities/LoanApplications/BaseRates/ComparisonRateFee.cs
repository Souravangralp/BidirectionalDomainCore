namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents the various fees and percentages used to calculate the comparison rate for a loan application, including application, legal, risk, facility, and other associated charges.
/// </summary>
public class ComparisonRateFee : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets fees other than the monthly fee that are included in the comparison rate calculation.
    /// </summary>
    public double OtherFeeExcludingMonthlyFee { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated loan application fee entity.
    /// </summary>
    public int? ComparisonRateFee_LoanApplicationFeesID { get; set; }

    /// <summary>
    /// Gets or sets the collection of calculated fees associated with the borrower's rate fee.
    /// </summary>
    public IList<CalculatedFee> CalculatedFees { get; set; } = [];

    /// <summary>
    /// Gets or sets the related <see cref="LoanApplicationFee"/> entity associated with this comparison rate fee.
    /// </summary>
    public LoanApplicationFee? ComparisonRateFee_LoanApplicationFees { get; set; }
}
