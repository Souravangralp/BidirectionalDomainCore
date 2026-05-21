namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents post-settlement events and conditions related to a loan application, including rebates, rate changes, and specific conduct criteria.
/// </summary>
public class PostSettlementEvent : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated feedback and indication record for the post-settlement event.
    /// </summary>
    public int? PostSettlementEvent_FeedbackAndIndicationID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether direct credit repayment is applicable to the post-settlement event.
    /// </summary>
    public bool HASDirectCreditRepayment { get; set; }

    #region Prevailing Rate

    /// <summary>
    /// Gets or sets a value indicating whether there is an increase in the prevailing rate.
    /// </summary>
    public bool ISIncreasePrevailing { get; set; }

    /// <summary>
    /// Gets or sets the amount by which the prevailing rate is adjusted.
    /// </summary>
    public double? PrevailingRateBy { get; set; }

    /// <summary>
    /// Gets or sets the number of months the prevailing rate adjustment is applicable.
    /// </summary>
    public int? PrevailingRateInMonths { get; set; }

    #region Assuming Good Conduct

    /// <summary>
    /// Gets or sets the primary type for assuming good conduct, based on the GeneralLookUp data.
    /// </summary>
    [Comment("We will get this data from GeneralLookUp")]
    public int? PrimaryAssumingGoodConductType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the secondary type for assuming good conduct, based on the GeneralLookUp data.
    /// </summary>
    public int? SecondaryAssumingGoodConductType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the tertiary type for assuming good conduct, based on the GeneralLookUp data.
    /// </summary>
    public int? TertiaryAssumingGoodConductType_GeneralLookUpID { get; set; }

    #endregion

    /// <summary>
    /// Gets or sets a value indicating whether the loan is being refinanced back to the primary loan.
    /// </summary>
    public bool ISRefinanceBackToPrimaryLoan { get; set; }

    #endregion

    /// <summary>
    /// Gets or sets the amount by which the prevailing rate is increased.
    /// </summary>
    public double? IncreasePrevailingRateBy { get; set; }

    /// <summary>
    /// Gets or sets the number of months the prevailing rate increase is applicable.
    /// </summary>
    public int? IncreasePrevailingRateInMonths { get; set; }

    /// <summary>
    /// Gets or sets the amount by which the prevailing rate is decreased.
    /// </summary>
    public double? DecreasePrevailingRateBy { get; set; }

    /// <summary>
    /// Gets or sets the number of months the prevailing rate decrease is applicable.
    /// </summary>
    public int? DecreasePrevailingRateInMonths { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the assuming good conduct type, based on the GeneralLookUp data.
    /// </summary>
    [Comment("We will get this data from GeneralLookUp")]
    public int? AssumingGoodConductType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a risk fee rebate is included in the post-settlement event.
    /// </summary>
    public bool HASRiskFeeRebate { get; set; }

    /// <summary>
    /// Gets or sets the risk fee rebate as a percentage.
    /// </summary>
    [Comment("for percent")]
    public double? RiskFeeRebateRate { get; set; }

    /// <summary>
    /// Gets or sets the risk fee rebate as a monetary amount.
    /// </summary>
    [Comment("for amount")]
    public double? RiskFeeRebateAmount { get; set; }

    /// <summary>
    /// Gets or sets the number of months for which the risk fee rebate is applicable.
    /// </summary>
    public int? RiskFeeRebateInMonths { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether an establishment fee rebate is included.
    /// </summary>
    public bool HASEstablishmentFeeRebate { get; set; }

    /// <summary>
    /// Gets or sets the establishment fee rebate as a percentage.
    /// </summary>
    [Comment("for percent")]
    public double? EstablishmentFeeRebateRate { get; set; }

    /// <summary>
    /// Gets or sets the establishment fee rebate as a monetary amount.
    /// </summary>
    [Comment("for amount")]
    public double? EstablishmentFeeRebateAmount { get; set; }

    /// <summary>
    /// Gets or sets the number of months for which the establishment fee rebate is applicable.
    /// </summary>
    public int? EstablishmentFeeRebateInMonths { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a cash rebate is provided as part of the post-settlement event.
    /// </summary>
    public bool HASCashRebate { get; set; }

    /// <summary>
    /// Gets or sets the cash rebate amount.
    /// </summary>
    public double? CashRebateAmount { get; set; }

    /// <summary>
    /// Gets or sets the number of months for which the cash rebate is applicable.
    /// </summary>
    public int? CashRebateInMonths { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the $500.00 construction rebate to the loan account is applicable.
    /// (Assuming satisfactory and timely completion, 30 days post acceptable occupation certificate.)
    /// </summary>
    [Comment("$500.00 construction rebate to loan account, (assuming satisfactory & timely completion) 30 days post acceptable occupation certificate")]
    public bool HASFiveHundredConstructionRebate { get; set; }

    /// <summary>
    /// Gets or sets the explanation or details for the $500.00 construction rebate, if applicable.
    /// </summary>
    [Comment("Explanation if above field is selected as true")]
    public string? FiveHundredConstructionRebate { get; set; }

    /// <summary>
    /// Gets or sets the UTC date related to the post-settlement event.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? DateUtc { get; set; }

    /// <summary>
    /// Gets or sets the related feedback and indication entity for the post-settlement event.
    /// </summary>
    public FeedbackAndIndication? PostSettlementEvent_FeedbackAndIndication { get; set; }
}
