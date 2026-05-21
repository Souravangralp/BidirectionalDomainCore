namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents the calculated interest rate and associated repayment and fee details for a loan application.
/// </summary>
public class InterestRate : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the monthly instalment amount, including any applicable fees.
    /// </summary>
    public double MonthlyInstalmentIncludingFee { get; set; }

    /// <summary>
    /// Gets or sets the total repayment amount over the duration of the loan, including all applicable fees.
    /// </summary>
    public double TotalRepaymentIncludingFee { get; set; }

    /// <summary>
    /// Gets or sets the monthly instalment amount, including only the monthly fee.
    /// </summary>
    public double MonthlyInstalmentIncludingMonthlyFee { get; set; }

    /// <summary>
    /// Gets or sets the total fee amount, excluding any monthly fees.
    /// </summary>
    public double TotalFeeExclMonthlyFee { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated loan application fees entity.
    /// </summary>
    public int? InterestRate_LoanApplicationFeesID { get; set; }

    /// <summary>
    /// Gets or sets the related <see cref="LoanApplicationFee"/> entity associated with this interest rate.
    /// </summary>
    public LoanApplicationFee? InterestRate_LoanApplicationFees { get; set; }
}
