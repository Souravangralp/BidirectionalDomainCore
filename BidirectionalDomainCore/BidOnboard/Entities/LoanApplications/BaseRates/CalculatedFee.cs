namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents a calculated fee within a loan application, including fee amounts, types, and application status.
/// </summary>
public class CalculatedFee : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related BorrowerRateFee.
    /// </summary>
    public int? CalculatedFee_BorrowerRateFeeID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related BorrowerRateFee.
    /// </summary>
    public int? CalculatedFee_ComparisonRateFeeID { get; set; }

    /// <summary>
    /// Gets or sets the percent fee applied in the calculation.
    /// </summary>
    public double? PercentFee { get; set; }

    /// <summary>
    /// Gets or sets the amount calculated as a fee.
    /// </summary>
    public double? CalculatedFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the minimum fee (floor fee) that can be applied.
    /// </summary>
    public double? FloorFee { get; set; }

    /// <summary>
    /// Gets or sets the actual fee amount applied to the loan.
    /// </summary>
    public double? AppliedFee { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the floor fee was applied.
    /// </summary>
    public bool ISFloorFeeApplied { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether any fee was applied.
    /// </summary>
    public bool ISFeeApplied { get; set; }

    /// <summary>
    /// Gets or sets the type of the fee (e.g., origination, service).
    /// </summary>
    public string? FeeType { get; set; }

    /// <summary>
    /// Gets or sets the value by which the fee is reduced.
    /// </summary>
    public double? FeeReductionValue { get; set; }

    /// <summary>
    /// Gets or sets the related BorrowerRateFee details.
    /// </summary>
    public BorrowerRateFee? CalculatedFee_BorrowerRateFee { get; set; }

    /// <summary>
    /// Gets or sets the related BorrowerRateFee details.
    /// </summary>
    public ComparisonRateFee? CalculatedFee_ComparisonRateFee { get; set; }
}
