using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a split of a loan within a loan application, including its details, types, terms, and related entities.
/// </summary>
public class LoanSplit : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan application for this loan split.
    /// </summary>
    public int? LoanSplit_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the tracking number assigned to this loan split.
    /// </summary>
    public string? SplitTrackingNumber { get; set; }

    public string? SplitSequenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the type of loan for this split.
    /// </summary>
    public int? LoanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the total amount associated with this loan split.
    /// </summary>
    public double? SplitAmount { get; set; }

    /// <summary>
    /// Gets or sets the amount of security provided for this loan split.
    /// </summary>
    public double? SplitSecurityAmount { get; set; }

    //public int? OccupancyType_GeneralLookUpID { get; set; }

    //public double? InvestmentAmount { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the repayment type for this split.
    /// </summary>
    public int? RepaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of months for the interest-only period.
    /// </summary>
    public int? InterestOnlyPeriodInMonths { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the interest type for this split.
    /// </summary>
    public int? InterestType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of fixed term years for this split.
    /// </summary>
    public int? FixedTimeInYears { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the rate for this split is locked.
    /// </summary>
    public bool ISRateLocked { get; set; }

    /// <summary>
    /// Gets or sets the number of years the rate is locked for.
    /// </summary>
    public int? RateLockTimeInYears { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the facility type of this split.
    /// </summary>
    public int? FacilityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for heedful points related to this split.
    /// </summary>
    public int? HeedfulPoints_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the secondary usage of this split.
    /// </summary>
    public int? SecondaryUsage_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the service type of this split.
    /// </summary>
    public int? ServiceType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the loan term type.
    /// </summary>
    public int? LoanTermType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the duration of the loan term in years.
    /// </summary>
    public int LoanTermYears { get; set; }

    /// <summary>
    /// Gets or sets the loan-to-value ratio (LVR) for this loan split.
    /// </summary>
    public double? LVR { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the product type for this split.
    /// </summary>
    public int? ProductType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the numeral type for this split.
    /// </summary>
    public int? NumeralType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the loan purpose details associated with this loan split.
    /// </summary>
    public LoanPurposeDetail? LoanPurposeDetails { get; set; }

    /// <summary>
    /// Gets or sets the associated loan application entity for this split.
    /// </summary>
    public LoanApplication? LoanSplit_LoanApplication { get; set; }

    /// <summary>
    /// Gets or sets the loan security associated with this split.
    /// </summary>
    public LoanSecurity? LoanSecurity { get; set; }

    /// <summary>
    /// Gets or sets the loan application fees applicable to this split.
    /// </summary>
    public List<LoanApplicationFee>? LoanApplicationFees { get; set; }
}
