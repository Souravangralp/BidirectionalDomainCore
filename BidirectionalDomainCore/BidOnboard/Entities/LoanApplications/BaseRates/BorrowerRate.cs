namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Represents the various rate components applicable to a borrower, including base rate, discounts, margin loadings, risk factors, and related loan application fees.
/// </summary>
public class BorrowerRate : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the base interest rate assigned to the borrower.
    /// </summary>
    public double BaseRate { get; set; }

    /// <summary>
    /// Gets or sets the discount applied to the borrower's base rate.
    /// </summary>
    public double Discount { get; set; }

    /// <summary>
    /// Gets or sets the additional margin added due to data entry considerations.
    /// </summary>
    public double DataEntryAdditionMargin { get; set; }

    /// <summary>
    /// Gets or sets the loading applied for multi-brand lending scenarios.
    /// </summary>
    public double MultiBrandLoading { get; set; }

    /// <summary>
    /// Gets or sets the loading added for specific brand requirements.
    /// </summary>
    public double BrandSpecificLoading { get; set; }

    /// <summary>
    /// Gets or sets the margin when targeting a specific rate.
    /// </summary>
    public double MarginWithTarget { get; set; }

    /// <summary>
    /// Gets or sets the loading factor based on the type of documentation provided.
    /// </summary>
    public double DocTypeLoading { get; set; }

    /// <summary>
    /// Gets or sets the loading based on the specific product selected.
    /// </summary>
    public double ProductLoading { get; set; }

    /// <summary>
    /// Gets or sets the residency type loading, which adjusts the rate based on borrower residency status.
    /// </summary>
    public double? ResidencyTypeLoading { get; set; }

    /// <summary>
    /// Gets or sets the loading applied for high-risk borrower profiles.
    /// </summary>
    public double? HighRiskLoading { get; set; }

    /// <summary>
    /// Gets or sets the loading applied if the borrower is considered politically exposed.
    /// </summary>
    public double? PoliticallyExposedLoading { get; set; }

    /// <summary>
    /// Gets or sets the loading based on the facility type associated with the loan.
    /// </summary>
    public double? FacilityTypeLoading { get; set; }

    /// <summary>
    /// Gets or sets the discretionary margin added by a manager.
    /// </summary>
    public double ManagerDiscretion { get; set; }

    /// <summary>
    /// Gets or sets the loading applied for reverting rate scenarios.
    /// </summary>
    public double RevertingRateLoading { get; set; }

    /// <summary>
    /// Gets or sets reverting rate loading when fixed period ends (nullable).
    /// </summary>
    public double? BorrowingEntityTypeLoading { get; set; }

    /// <summary>
    /// Gets or sets reverting rate loading when fixed period ends (nullable).
    /// </summary>
    public double? LoanTypeLoading { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related loan application fees.
    /// </summary>
    public int? BorrowerRate_LoanApplicationFeesID { get; set; }

    /// <summary>
    /// Gets or sets the related loan application fee entity for this borrower rate.
    /// </summary>
    public LoanApplicationFee? BorrowerRate_LoanApplicationFees { get; set; }
}
