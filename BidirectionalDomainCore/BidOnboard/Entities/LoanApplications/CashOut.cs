using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents information for cash out loan applications including asset details, imminent property purchases,
/// and associated loan purpose details.
/// </summary>
public class Cashout : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the related loan purpose detail ID for the cash out.
    /// </summary>
    public int? Cashout_LoanPurposeDetailID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the borrower is buying an imminent property.
    /// </summary>
    public bool? ISBuyingImminentProperty { get; set; }

    /// <summary>
    /// Gets or sets the address for the imminent property purchase.
    /// </summary>
    public string? ImminentPurchaseAddress { get; set; }

    /// <summary>
    /// Gets or sets the value of controlled personal assets.
    /// </summary>
    public double? ControlledPersonalAssets { get; set; }

    /// <summary>
    /// Gets or sets the value of uncontrolled personal assets.
    /// </summary>
    public double? UncontrolledPersonalAssets { get; set; }

    /// <summary>
    /// Gets or sets the value of controlled investment assets.
    /// </summary>
    public double? ControlledInvestmentAssets { get; set; }

    /// <summary>
    /// Gets or sets the value of uncontrolled investment assets.
    /// </summary>
    public double? UncontrolledInvestmentAssets { get; set; }

    /// <summary>
    /// Gets or sets the value of controlled business assets.
    /// </summary>
    public double? ControlledBusinessAssets { get; set; }

    /// <summary>
    /// Gets or sets the value of uncontrolled business assets.
    /// </summary>
    public double? UncontrolledBusinessAssets { get; set; }

    /// <summary>
    /// Gets or sets the value of controlled HECS liabilities.
    /// </summary>
    public double? ControlledHECSLiabilities { get; set; }

    /// <summary>
    /// Gets or sets the value of uncontrolled HECS liabilities.
    /// </summary>
    public double? UncontrolledHECSLiabilities { get; set; }

    /// <summary>
    /// Gets or sets the value of controlled working capital.
    /// </summary>
    public double? ControlledWorkingCapital { get; set; }

    /// <summary>
    /// Gets or sets the value of uncontrolled working capital.
    /// </summary>
    public double? UnControlledWorkingCapital { get; set; }

    /// <summary>
    /// Gets or sets the controlled payment amount for Australian Tax Office (ATO) liability.
    /// </summary>
    [Comment("Australian tax office (ATO) liability")]
    public double? ControlledPayment { get; set; }

    /// <summary>
    /// Gets or sets the uncontrolled payment amount for Australian Tax Office (ATO) liability.
    /// </summary>
    [Comment("Australian tax office (ATO) liability")]
    public double? UnControlledPayment { get; set; }

    /// <summary>
    /// Gets or sets the value of controlled development or land banking assets.
    /// </summary>
    public double? ControlledDevelopmentORLandBanking { get; set; }

    /// <summary>
    /// Gets or sets the value of uncontrolled development or land banking assets.
    /// </summary>
    public double? UnControlledDevelopmentORLandBanking { get; set; }

    /// <summary>
    /// Gets or sets the total value of controlled assets.
    /// </summary>
    public double? TotalControlledAssets { get; set; }

    /// <summary>
    /// Gets or sets the total value of uncontrolled assets.
    /// </summary>
    public double? TotalUncontrolledAssets { get; set; }

    /// <summary>
    /// Gets or sets the address for the property that is an imminent purchase.
    /// </summary>
    public Address? ImminentPropertyAddress { get; set; }

    /// <summary>
    /// Gets or sets the related loan purpose detail entity for the cash out.
    /// </summary>
    public LoanPurposeDetail? Cashout_LoanPurposeDetail { get; set; }
}
