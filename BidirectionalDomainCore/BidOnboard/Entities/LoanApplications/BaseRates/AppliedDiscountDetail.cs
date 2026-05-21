namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents the details of a discount applied to loan application fees, including percentages, prepayment values, interest rates, savings, and related fee information.
/// </summary>
public class AppliedDiscountDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated loan application fee to which the discount is applied.
    /// </summary>
    public int? AppliedDiscountDetail_LoanApplicationFeesID { get; set; }

    /// <summary>
    /// Gets or sets the percentage discount applied to the fee.
    /// </summary>
    public double PercentDiscount { get; set; }

    /// <summary>
    /// Gets or sets the prepayment percentage used in the discount calculation.
    /// </summary>
    public double PrepaymentPercent { get; set; }

    /// <summary>
    /// Gets or sets the actual prepayment amount considered in the discount.
    /// </summary>
    public double Prepayment { get; set; }

    /// <summary>
    /// Gets or sets the interest calculated based on the actual interest rate before the discount.
    /// </summary>
    public double InterestOnActualRate { get; set; }

    /// <summary>
    /// Gets or sets the interest calculated based on the discounted interest rate after the discount is applied.
    /// </summary>
    public double InterestOnDiscountedRate { get; set; }

    /// <summary>
    /// Gets or sets the total savings derived from purchasing the discount.
    /// </summary>
    public double SavingOnBuyingDiscount { get; set; }

    /// <summary>
    /// Gets or sets the net savings achieved after applying the discount and including all factors.
    /// </summary>
    public double NetSaving { get; set; }

    /// <summary>
    /// Gets or sets the related loan application fee entity associated with this discount detail.
    /// </summary>
    public LoanApplicationFee? AppliedDiscountDetail_LoanApplicationFees { get; set; }
}
