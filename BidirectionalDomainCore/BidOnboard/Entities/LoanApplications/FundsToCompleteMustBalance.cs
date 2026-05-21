namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details and breakdown of funds required to complete a loan application,
/// including all relevant amounts and their descriptions for settlement, fees, contributions, and related items.
/// </summary>
public class FundsToCompleteMustBalance : BaseAuditableEntity
{
    // In Section 10 - There are many fields with Amount and Description/Type/Details/Source.
    // For uniformity in schema we will use only 2 names i.e., 1).Details for Description/Type/Details/Source And 2).Amount

    /// <summary>
    /// Gets or sets the related Loan Application ID for the funds to complete balance.
    /// </summary>
    public int? FundsToCompleteBalance_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the description of monies required for settlement, excluding fees.
    /// </summary>
    [Comment("Monies required for settlement excluding fees")]
    public string? SettlementMoniesDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of monies required for settlement, excluding fees.
    /// </summary>
    [Comment("Monies required for settlement excluding fees")]
    public double? SettlementMoniesAmount { get; set; }

    /// <summary>
    /// Gets or sets the details of all settlement-related fees, stamp duty, legal costs, valuation, etc.
    /// </summary>
    [Comment("All fees, stamp duty, legal costs, valuation etc")]
    public string? FeesOrStampsDetails { get; set; }

    /// <summary>
    /// Gets or sets the total amount of fees, stamp duty, legal costs, valuation, etc.
    /// </summary>
    [Comment("All fees, stamp duty, legal costs, valuation etc")]
    public double? FeesOrStampsAmount { get; set; }

    /// <summary>
    /// Gets or sets the details of the mortgage insurer, including premium and insurer name.
    /// </summary>
    [Comment("Mortgage insurance premium & insurer")]
    public string? MortgageInsurerDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of the mortgage insurance premium.
    /// </summary>
    [Comment("Mortgage insurance premium & insurer - Amount")]
    public double? MortgagePremiumAmount { get; set; }

    /// <summary>
    /// Gets or sets the details of cash retained by the customer, including buffer amounts.
    /// </summary>
    [Comment("Cash retained by customer(including buffer)")]
    public string? CashRetainedByCustomerDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of cash retained by the customer, including buffer.
    /// </summary>
    [Comment("Cash retained by customer(including buffer)")]
    public double? CashRetainedByCustomerAmount { get; set; }

    /// <summary>
    /// Gets or sets the details of the source or type of cash contribution.
    /// </summary>
    [Comment("Cash source/type & contribution")]
    public string? CashSourceOrContributionDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of cash sourced or contributed.
    /// </summary>
    [Comment("Cash source/type & contribution")]
    public double? CashSourceOrContributionAmount { get; set; }

    /// <summary>
    /// Gets or sets the source details of any gift used as part of the funds to complete.
    /// </summary>
    [Comment("Gift source & amount")]
    public string? GiftSourceDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of the gift used as part of the funds to complete.
    /// </summary>
    [Comment("Gift source & amount")]
    public double? GiftAmount { get; set; }

    /// <summary>
    /// Gets or sets the source of the paid deposit.
    /// </summary>
    [Comment("Deposit paid(source & amount)")]
    public string? PaidDepositSource { get; set; }

    /// <summary>
    /// Gets or sets the amount of deposit paid.
    /// </summary>
    [Comment("Deposit paid (source & amount)")]
    public double? PaidDepositAmount { get; set; }

    /// <summary>
    /// Gets or sets the type and source details of any grants received.
    /// </summary>
    [Comment("Grant type & amount")]
    public string? GrantTypeSource { get; set; }

    /// <summary>
    /// Gets or sets the amount of grants received.
    /// </summary>
    [Comment("Grant type & amount")]
    public double? GrantAmount { get; set; }

    /// <summary>
    /// Gets or sets the source details for any redraw funds used.
    /// </summary>
    [Comment("Redraw source & amount")]
    public string? RedrawSourceDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of redraw funds.
    /// </summary>
    [Comment("Redraw source & amount")]
    public double? RedrawAmount { get; set; }

    /// <summary>
    /// Gets or sets the details of the net proceeds from imminent sale.
    /// </summary>
    [Comment("Net proceeds from imminent sale")]
    public string? ImmediateSaleNetProceedsDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of net proceeds from imminent sale.
    /// </summary>
    [Comment("Net proceeds from imminent sale - Amount")]
    public double? ImmediateSaleNetProceedsAmount { get; set; }

    /// <summary>
    /// Gets or sets the name of the loan product involved.
    /// </summary>
    [Comment("This loan product name & amount")]
    public string? LoanProductName { get; set; }

    /// <summary>
    /// Gets or sets the amount for this loan product.
    /// </summary>
    [Comment("This loan product name & amount")]
    public double? LoanProductAmount { get; set; }

    /// <summary>
    /// Gets or sets the details of any monies nominated towards settlement.
    /// </summary>
    [Comment("monies nominated towards settlement")]
    public string? NominatedMoniesDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of monies nominated towards settlement.
    /// </summary>
    [Comment("monies nominated towards settlement - Amount")]
    public double? NominatedMoniesAmount { get; set; }

    /// <summary>
    /// Gets or sets information regarding any surplus or deficit at settlement.
    /// </summary>
    [Comment("Surplus or deficit at settlement")]
    public string? SurplusOrDeficitDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of surplus or deficit at settlement.
    /// </summary>
    [Comment("Surplus or deficit at settlement - amount")]
    public double? SurplusOrDeficitAmount { get; set; }

    /// <summary>
    /// Gets or sets the collection of equity split details for the purchase or refinance.
    /// </summary>
    public IList<FundsForPurchaseRefinanceEquitySplit> FundsForPurchaseRefinanceEquitySplits { get; set; } = new List<FundsForPurchaseRefinanceEquitySplit>();

    /// <summary>
    /// Gets or sets the LoanApplication entity associated with the funds to complete balance.
    /// </summary>
    public LoanApplication? FundsToCompleteBalance_LoanApplication { get; set; }
}
