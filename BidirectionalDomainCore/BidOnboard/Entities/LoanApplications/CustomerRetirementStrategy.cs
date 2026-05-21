namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the retirement strategy details and related financial projections for a loan application customer,
/// including stress test results, anticipated retirement data, financial declarations, and key calculated amounts.
/// </summary>
public class CustomerRetirementStrategy : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related customer declaration associated with the retirement strategy.
    /// </summary>
    public int? CustomerRetirementStrategy_CustomerDeclarationID { get; set; }

    /// <summary>
    /// Gets or sets the result of the retirement strategy stress test.
    /// </summary>
    [Comment("Retirement strategy stress test")]
    public string? RetirementStrategyStressTestResult { get; set; }

    /// <summary>
    /// Gets or sets the amount determined for the retirement strategy.
    /// </summary>
    public string? RetirementStrategyAmount { get; set; }

    /// <summary>
    /// Gets or sets the anticipated quantum of lift (repayment acceleration) in monthly repayments without hardship.
    /// </summary>
    [Comment("Anticipated quantum of lift (repayment acceleration) in monthly repayments without hardship.")]
    public string? MonthlyLiftAmount { get; set; }

    /// <summary>
    /// Gets or sets the collection of retirement financial declarations related to the retirement strategy.
    /// </summary>
    public List<RetirementFinancialDeclaration> RetirementFinancialDeclarations { get; set; } = new List<RetirementFinancialDeclaration>();

    /// <summary>
    /// Gets or sets the loan balance amount from which downsizing is calculated.
    /// </summary>
    public double? DownsizingFromLoanBalanceAmount { get; set; }

    /// <summary>
    /// Gets or sets the loan balance amount to which downsizing is calculated.
    /// </summary>
    public double? DownsizingToLoanBalanceAmount { get; set; }

    /// <summary>
    /// Gets or sets the anticipated number of years into the loan contract before retirement.
    /// </summary>
    [Comment("Anticipated retirement in number of years into the loan contract")]
    public double? AnticipatedRetirementYears { get; set; }

    /// <summary>
    /// Gets or sets the anticipated retirement balance (number of years into the loan contract).
    /// </summary>
    [Comment("Anticipated retirement in number of years into the loan contract")]
    public double? ScheduledRetirementBalance { get; set; }

    /// <summary>
    /// Gets or sets the projected surplus or deficit at the anticipated time of retirement.
    /// </summary>
    [Comment("Projected surplus/deficit at anticipated time of retirement")]
    public string? ProjectedRetirementNetBalance { get; set; }

    /// <summary>
    /// Gets or sets the indicator showing if surplus evidence is present at retirement.
    /// </summary>
    [Comment("Pass if surplus is evident")]
    public string? SurplusEvidencePass { get; set; }

    /// <summary>
    /// Gets or sets the deficit amount for servicing on post-retirement income pension.
    /// </summary>
    [Comment("Test for servicing on aged (post retirement income) pension if deficit of")]
    public string? StressTestDeficitAmount { get; set; }

    /// <summary>
    /// Gets or sets the approved loan term, assumed in years, used for stress testing.
    /// </summary>
    [Comment("assuming an approved year loan of")]
    public string? StressTestApprovedLoanTerm { get; set; }

    /// <summary>
    /// Gets or sets the retirement age in years applied in the stress test.
    /// </summary>
    [Comment("retiring field")]
    public string? StressTestRetirementAgeYears { get; set; }

    /// <summary>
    /// Gets or sets the anticipated loan balance amount at the point of retiring into the loan contract.
    /// </summary>
    [Comment("retiring into the loan contract with an anticipated loan balance of")]
    public string? StressTestAnticipatedLoanBalanceAmount { get; set; }

    /// <summary>
    /// Gets or sets the anticipated growth of super value, including projected increases.
    /// </summary>
    [Comment("and current super value (projected increase of %) plus anticipated increase in super value.")]
    public string? StressTestAnticipatedSuperValueGrowth { get; set; }

    /// <summary>
    /// Gets or sets the total amount after compounding is applied at a specified net rate.
    /// </summary>
    [Comment("increasing at a net compounding rate of �X.XX� %, totaling")]
    public double? TotalAfterCompounding { get; set; }

    /// <summary>
    /// Gets or sets the related customer declaration associated with the retirement strategy.
    /// </summary>
    public CustomerDeclaration? CustomerRetirementStrategy_CustomerDeclaration { get; set; }
}
