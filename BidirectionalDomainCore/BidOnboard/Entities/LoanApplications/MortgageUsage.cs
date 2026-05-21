namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the usage details and characteristics of a mortgage split within a loan application.
/// </summary>
public class MortgageUsage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated mortgage split.
    /// </summary>
    public int? MortgageUsage_MortgageSplitID { get; set; }

    /// <summary>
    /// Gets or sets the lookup identifier representing the type of usage.
    /// </summary>
    public int? UsageType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the cash rate applicable to the mortgage usage.
    /// </summary>
    public double CashRate { get; set; }

    /// <summary>
    /// Gets or sets the date on which the cash rate applies.
    /// </summary>
    public DateTime? CashRateOnDate { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the product associated with the mortgage usage.
    /// </summary>
    public int? ProductID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the product category.
    /// </summary>
    public int? ProductCategoryID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the mortgage usage is for investment purposes.
    /// </summary>
    public bool ISInvestment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the mortgage usage is interest-only.
    /// </summary>
    public bool ISInterestOnly { get; set; }

    /// <summary>
    /// Gets or sets the term, in years, for which the loan is interest-only.
    /// </summary>
    public int? InterestOnlyTermInYear { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the mortgage usage is a fixed rate.
    /// </summary>
    public bool ISFixed { get; set; }

    /// <summary>
    /// Gets or sets the duration, in years, for which the rate is fixed.
    /// </summary>
    public int? FixedTermInYear { get; set; }

    /// <summary>
    /// Gets or sets the interest rate for the mortgage usage.
    /// </summary>
    public double Rate { get; set; }

    /// <summary>
    /// Gets or sets the lookup identifier for the split facility type.
    /// </summary>
    public int? SplitFacilityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the associated MortgageSplit entity.
    /// </summary>
    public MortgageSplit? MortgageUsage_MortgageSplit { get; set; }
}
