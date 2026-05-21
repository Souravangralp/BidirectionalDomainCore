using Bidirectional.DomainCore.BidOnboard.Enums;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents the fees and associated rates applied to a loan application, including borrower, comparison, and offset rates, as well as related fee and discount details.
/// </summary>
public class LoanApplicationFee : BaseAuditableEntity
{
    public int? LoanApplicationFee_OverriddenByUserID { get; set; }

    /// <summary>
    /// Gets or sets the identifier linking this fee to a specific loan split.
    /// </summary>
    public int? LoanApplicationFees_LoanSplitID { get; set; }

    /// <summary>
    /// Gets or sets the status/source of the fee record.
    /// </summary>
    public LoanApplicationFeeStatus Status { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether gets or sets whether this is the currently active/applied fee record.
    /// </summary>
    public bool ISCurrent { get; set; }

    /// <summary>
    /// Gets or sets the reason for admin override.
    /// </summary>
    public string? OverrideReason { get; set; }

    public DateTime? OverriddenUtc { get; set; } = DateTime.UtcNow;

    public string? Version { get; set; }

    /// <summary>
    /// Gets or sets the actual interest rate assigned to the borrower.
    /// </summary>
    public double ActualBorrowerRate { get; set; }

    /// <summary>
    /// Gets or sets the final borrower rate after adjustments or negotiations.
    /// </summary>
    public double FinalBorrowerRate { get; set; }

    /// <summary>
    /// Gets or sets the reverting rate applied after the fixed or introductory period.
    /// </summary>
    public double RevertingRate { get; set; }

    /// <summary>
    /// Gets or sets the comparison rate, which includes both the interest rate and fees.
    /// </summary>
    public double ComparisonRate { get; set; }

    /// <summary>
    /// Gets or sets the monthly repayment amount including fees.
    /// </summary>
    public double MonthlyPaymentInclFee { get; set; }

    /// <summary>
    /// Gets or sets the monthly repayment amount including fees when an offset account is present.
    /// </summary>
    public double MonthlyPaymentInclFeeWithOffsetAccount { get; set; }

    /// <summary>
    /// Gets or sets the borrower rate when an offset account is present.
    /// </summary>
    public double OffsetBorrowerRate { get; set; }

    /// <summary>
    /// Gets or sets the comparison rate when an offset account is included.
    /// </summary>
    public double OffsetComparisonRate { get; set; }

    /// <summary>
    /// Gets or sets the loan-to-value ratio (LVR) limit associated with this fee.
    /// </summary>
    public int LvrLimit { get; set; }

    [TextClass(TextFieldClass.JsonPayload)]
    /// <summary>
    /// Gets or sets the request payload containing additional details or metadata.
    /// </summary>
    public string? RequestPayload { get; set; }

    [TextClass(TextFieldClass.JsonPayload)]
    /// <summary>
    /// Gets or sets the request payload containing additional details or metadata.
    /// </summary>
    public string? Response { get; set; }

    /// <summary>
    /// Gets or sets the related loan split details.
    /// </summary>
    public LoanSplit? LoanApplicationFees_LoanSplit { get; set; }

    /// <summary>
    /// Gets or sets the details of the borrower rate as an associated entity.
    /// </summary>
    public BorrowerRate? BorrowerRateDetails { get; set; }

    /// <summary>
    /// Gets or sets the interest rate details related to this fee.
    /// </summary>
    public InterestRate? InterestRateDetails { get; set; }

    /// <summary>
    /// Gets or sets the comparison rate fee details related to this loan application.
    /// </summary>
    public ComparisonRateFee? ComparisonRateFeeDetails { get; set; }

    /// <summary>
    /// Gets or sets the borrower rate fee details.
    /// </summary>
    public BorrowerRateFee? BorrowerRateFeeDetails { get; set; }

    /// <summary>
    /// Gets or sets the fee reduction information, if applicable.
    /// </summary>
    public FeeReduction? FeeReduction { get; set; }

    public bool ISDiscountApplied { get; set; }

    public double DiscountValue { get; set; }

    /// <summary>
    /// Gets or sets the details of any applied discounts for this fee.
    /// </summary>
    public AppliedDiscountDetail? AppliedDiscountDetail { get; set; }

    /// <summary>
    /// Gets or sets the details of any applied discounts for this fee.
    /// </summary>
    public User? LoanApplicationFee_OverriddenByUser { get; set; }

    /// <summary>
    /// Gets or sets audit rows for updates applied to this fee.
    /// </summary>
    public List<LoanApplicationFeeAudit>? LoanApplicationFeeAudits { get; set; }

    /// <summary>
    /// Need to remove these below 2 properties when we merge db
    /// </summary>
    public string? UserName { get; set; }

    public string? UserAdditionalDetail { get; set; }
}
