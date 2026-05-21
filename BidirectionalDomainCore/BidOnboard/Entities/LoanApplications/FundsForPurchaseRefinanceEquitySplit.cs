namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the equity split information for funds used in the purchase or refinance of a loan application.
/// Maps details about the source, type, and amount of funds as well as their associations.
/// </summary>
public class FundsForPurchaseRefinanceEquitySplit : BaseAuditableEntity
{
    // Section 10 - Fields that occur multiple times will get mapped here using GeneralLookUp
    // This Table will be used in Many to 1 relation with FundsToCompleteBalance table

    /// <summary>
    /// Gets or sets the identifier linking to the related FundsToCompleteMustBalance entity.
    /// </summary>
    public int? FundsForPurchaseRefinanceEquitySplits_FundsToCompleteMustBalanceID { get; set; }

    /// <summary>
    /// Gets or sets the GeneralLookUpID referencing the type of funds to complete, as seeded under 'FundsToCompleteType' in the GeneralLookUp table.
    /// </summary>
    [Comment("seeded under type 'FundsToCompleteType' in GeneralLookUp Table")]
    public int? FundsToCompleteType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets details describing the fund source or other relevant information.
    /// </summary>
    public string? FundDetails { get; set; }

    /// <summary>
    /// Gets or sets the amount of funds contributed for the purchase or refinance.
    /// </summary>
    public double? FundAmount { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the related FundsToCompleteMustBalance entity.
    /// </summary>
    public FundsToCompleteMustBalance? FundsForPurchaseRefinanceEquitySplits_FundsToCompleteMustBalance { get; set; }
}
