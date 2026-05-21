namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents a borrower's rate fee, including information about fee reductions and calculated fees associated with a loan application.
/// </summary>
public class BorrowerRateFee : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated loan application fee.
    /// </summary>
    public int? BorrowerRateFee_LoanApplicationFeesID { get; set; }

    /// <summary>
    /// Gets or sets the fee reduction amount excluding the monthly fee.
    /// </summary>
    public double FeeReductionExcludingMonthlyFee { get; set; }

    /// <summary>
    /// Gets or sets the annual fee reduction amount.
    /// </summary>
    public double FeeReductionAnnualFee { get; set; }

    /// <summary>
    /// Gets or sets the collection of calculated fees associated with the borrower's rate fee.
    /// </summary>
    public IList<CalculatedFee> CalculatedFees { get; set; } = [];

    /// <summary>
    /// Gets or sets fee for Early Repayment FeePercent.
    /// </summary>
    public double? EarlyRepaymentFeePercent { get; set; }

    /// <summary>
    /// Gets or sets fee for Minimum Holding Period Years.
    /// </summary>
    public double? MinimumHoldingPeriodYears { get; set; }

    /// <summary>
    /// Gets or sets formatted Early Repayment Fee description.
    /// </summary>
    [TextClass(TextFieldClass.Ignored)]
    public string? EarlyRepaymentFee { get; set; }

    public double? EarlyRepaymentCalculatedFee { get; set; }

    /// <summary>
    /// Gets or sets the related <see cref="LoanApplicationFee"/> entity.
    /// </summary>
    public LoanApplicationFee? BorrowerRateFee_LoanApplicationFees { get; set; }
}
