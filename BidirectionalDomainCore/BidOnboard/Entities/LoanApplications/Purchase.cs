using Bidirectional.DomainCore.BidOnboard.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a purchase entity containing information related to a property purchase for a loan application,
/// including purchase details, funding types, property information, and associated metadata.
/// </summary>
public class Purchase : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related loan purpose detail.
    /// </summary>
    public int? Purchase_LoanPurposeDetailID { get; set; }

    /// <summary>
    /// Gets or sets the First Home Owner Grant type lookup identifier.
    /// </summary>
    public int? FHOGType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the pledge loan type lookup identifier.
    /// </summary>
    public int? PledgeLoanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the genuine saving type lookup identifier.
    /// </summary>
    public int? GenuineSavingType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the real estate agent type lookup identifier.
    /// </summary>
    public int? RealEstateAgentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the property intention type lookup identifier.
    /// </summary>
    public int? PropertyIntentionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the buying type lookup identifier.
    /// </summary>
    public int? BuyingType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the property purchase type lookup identifier.
    /// </summary>
    public int? PropertyPurchaseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the paid purchase type lookup identifier.
    /// </summary>
    public int? PaidPurchaseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the deposit amount for the purchase.
    /// </summary>
    public double? DepositAmount { get; set; }

    /// <summary>
    /// Gets or sets the downsizing purchase type lookup identifier.
    /// </summary>
    public int? DownsizingPurchaseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the gift purchase type lookup identifier.
    /// </summary>
    public int? GiftPurchaseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the amount of the gift used for the purchase.
    /// </summary>
    public double? GiftAmount { get; set; }

    /// <summary>
    /// Gets or sets the exchanged purchase type lookup identifier.
    /// </summary>
    public int? ExchangedPurchaseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the date when the purchase was exchanged.
    /// </summary>
    public DateTime? DateOfExchange { get; set; }

    /// <summary>
    /// Gets or sets the vendor rebate purchase type lookup identifier.
    /// </summary>
    public int? VendorRebatePurchaseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the amount of vendor rebate provided for the purchase.
    /// </summary>
    public double? VendorRebateAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the rebate is provided at settlement.
    /// </summary>
    public bool? ISRebateMadeAtSettlement { get; set; }

    /// <summary>
    /// Gets or sets the associated loan purpose detail entity for the purchase.
    /// </summary>
    public LoanPurposeDetail? Purchase_LoanPurposeDetail { get; set; }

    #region Purchase Property Details

    /// <summary>
    /// Gets or sets the property type lookup identifier.
    /// </summary>
    public int? PropertyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the estimated value of the property.
    /// </summary>
    [Range(1, double.MaxValue)]
    public double? EstimatedValue { get; set; }

    /// <summary>
    /// Gets or sets the address of the purchased property.
    /// </summary>
    public Address? Address { get; set; }

    #endregion
}
