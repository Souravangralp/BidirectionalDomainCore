namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents a set of fee reductions applicable to a loan application, including various types of fees that can be adjusted.
/// </summary>
public class FeeReduction : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the reduced risk fee associated with the loan.
    /// </summary>
    public double RiskFee { get; set; }

    /// <summary>
    /// Gets or sets the reduced establishment fee for initiating the loan.
    /// </summary>
    public double EstablishmentFee { get; set; }

    /// <summary>
    /// Gets or sets the reduced application fee for processing the loan application.
    /// </summary>
    public double ApplicationFee { get; set; }

    /// <summary>
    /// Gets or sets the reduced settlement fee applicable at the completion of the loan process.
    /// </summary>
    public double SettlementFee { get; set; }

    /// <summary>
    /// Gets or sets the reduced discharge fee for closing or discharging the loan.
    /// </summary>
    public double DischargeFee { get; set; }

    /// <summary>
    /// Gets or sets the reduced annual facility fee charged on a yearly basis for the loan facility.
    /// </summary>
    public double AnnualFacilityFee { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related LoanApplicationFee to which this fee reduction applies.
    /// </summary>
    public int? FeeReduction_LoanApplicationFeesID { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the related LoanApplicationFee entity for this fee reduction.
    /// </summary>
    public LoanApplicationFee? FeeReduction_LoanApplicationFees { get; set; }
}
