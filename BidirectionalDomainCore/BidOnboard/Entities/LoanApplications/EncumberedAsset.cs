namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an asset that is subject to an encumbrance within a loan application, including its outstanding balance, interest details, and repayment information.
/// </summary>
public class EncumberedAsset : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the motor vehicle associated with the encumbered asset.
    /// </summary>
    public int? EncumberedAsset_MotorVehicleID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the other asset associated with the encumbered asset.
    /// </summary>
    public int? EncumberedAsset_OtherAssetID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the real estate asset associated with the encumbered asset.
    /// </summary>
    public int? EncumberedAsset_RealEstateAssetID { get; set; }

    public string? AccountNumber { get; set; }

    public double? InitialLoanAmount { get; set; }

    public double? RevertingFixedToVariableInterestRate { get; set; }

    public double? RevertingIOToPIInterestRate { get; set; }

    public bool HasDeductibleInterest { get; set; }

    public int? InitialLoanTerm { get; set; }

    public double? AvailableRedraw { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance on the encumbered asset.
    /// </summary>
    public double? BalanceOutstanding { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the interest type. If true then current fixed, else variable rate.
    /// </summary>
    [Comment("if it is true then current fixed else variable rate")]
    public int? InterestType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the interest rate applied to the encumbered asset.
    /// </summary>
    public double? InterestRate { get; set; }

    /// <summary>
    /// Gets or sets the date until which the interest rate is fixed in UTC.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? FixedTillUtc { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the repayment type. Yes means Principal and Interest (P & I), No means Interest Only (IO).
    /// </summary>
    [Comment("Yes means P And I and No means IO")]
    public int? RepaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the monthly repayment amount for the encumbered asset.
    /// </summary>
    public double? MonthlyRepaymentAmount { get; set; }

    public decimal? OriginalLoanAmount { get; set; }

    /// <summary>
    /// Gets or sets the motor vehicle entity associated with the encumbered asset.
    /// </summary>
    public MotorVehicle? EncumberedAsset_MotorVehicle { get; set; }

    /// <summary>
    /// Gets or sets the other asset entity associated with the encumbered asset.
    /// </summary>
    public OtherAsset? EncumberedAsset_OtherAsset { get; set; }

    /// <summary>
    /// Gets or sets the real estate asset entity associated with the encumbered asset.
    /// </summary>
    public RealEstateAsset? EncumberedAsset_RealEstateAsset { get; set; }
}
