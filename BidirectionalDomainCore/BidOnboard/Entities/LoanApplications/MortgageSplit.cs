namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a mortgage split within a loan application, capturing various rate, fee, product, and process details related to the mortgage structure.
/// </summary>
public class MortgageSplit : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier referencing the related Feedback and Indication record for this mortgage split.
    /// </summary>
    public int MortgageSplit_FeedbackAndIndicationID { get; set; }

    /// <summary>
    /// Gets or sets the maximum loan-to-value ratio (LVR) rate for the mortgage split.
    /// </summary>
    public double? MaximumLVRRate { get; set; }

    /// <summary>
    /// Gets or sets the loan amount associated with this split.
    /// </summary>
    public double? LoanAmount { get; set; }

    /// <summary>
    /// Gets or sets the loan term in years for this split.
    /// </summary>
    public int? LoanTermInYears { get; set; }

    /// <summary>
    /// Gets or sets the risk fee rate (as a percent) applicable to the split.
    /// </summary>
    [Comment("for percent")]
    public double? RiskFeeRate { get; set; }

    /// <summary>
    /// Gets or sets the risk fee amount applicable to the split.
    /// </summary>
    [Comment("for amount")]
    public double? RiskFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the application fee for this split.
    /// </summary>
    public double? ApplicationFee { get; set; }

    /// <summary>
    /// Gets or sets the establishment fee rate (as a percent) for this split.
    /// </summary>
    [Comment("for percent")]
    public double? EstablishmentFeeRate { get; set; }

    /// <summary>
    /// Gets or sets the establishment fee amount for this split.
    /// </summary>
    [Comment("for amount")]
    public double? EstablishmentFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the annual facility fee related to the split.
    /// </summary>
    public double? AnnualFacilityFee { get; set; }

    /// <summary>
    /// Gets or sets the monthly facility management fee for the split.
    /// </summary>
    public double? MonthlyFacilityManagementFee { get; set; }

    /// <summary>
    /// Gets or sets the settlement fee associated with this split.
    /// </summary>
    public double? SettlementFee { get; set; }

    /// <summary>
    /// Gets or sets the construction administration fee rate for the split.
    /// </summary>
    public double? ConstructionAdministrationFeeRate { get; set; }

    /// <summary>
    /// Gets or sets the construction administration fee amount for the split.
    /// </summary>
    public double? ConstructionAdministrationFee { get; set; }

    /// <summary>
    /// Gets or sets the discharge fee applicable to the mortgage split.
    /// </summary>
    public double? DischargeFee { get; set; }

    /// <summary>
    /// Gets or sets the rate lock (prepaid &amp; non-refundable) fee rate for this split.
    /// </summary>
    [Comment("Rate lock (prepaid & non-refundable) fee")]
    public double? RateLockFeeRate { get; set; }

    /// <summary>
    /// Gets or sets the rate lock (prepaid &amp; non-refundable) amount for this split.
    /// </summary>
    [Comment("Rate lock (prepaid & non-refundable) amount")]
    public double? RateLockFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the deed of priority fee for the mortgage split.
    /// </summary>
    public double? DeedOfPriorityFee { get; set; }

    /// <summary>
    /// Gets or sets the interest rate for this split.
    /// </summary>
    public double Rate { get; set; }

    /// <summary>
    /// Gets or sets the express fee associated with the mortgage split.
    /// </summary>
    public double? ExpressFee { get; set; }

    /// <summary>
    /// Gets or sets the repayment type general lookup identifier for this split.
    /// </summary>
    [Comment("We will get this data from GeneralLookUp")]
    public int? RepaymentType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the repayment term in months for this split.
    /// </summary>
    public int? RepaymentTermForMonths { get; set; }

    /// <summary>
    /// Gets or sets the document type general lookup identifier for this split.
    /// </summary>
    [Comment("We will get this data from GeneralLookUp")]
    public int? DocType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the facility type general lookup identifier for this split.
    /// </summary>
    [Comment("We will get this data from GeneralLookUp")]
    public int? FacilityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the variable interest rate applicable to the split.
    /// </summary>
    public double? VariableInterestRate { get; set; }

    /// <summary>
    /// Gets or sets the fixed interest rate applicable to the split.
    /// </summary>
    public double? FixedInterestRate { get; set; }

    /// <summary>
    /// Gets or sets the number of years for which the interest rate is fixed or variable.
    /// </summary>
    [Comment("years => ((1-5))")]
    public int? VariableORFixedInterestForYears { get; set; }

    /// <summary>
    /// Gets or sets the most recent Reserve Bank of Australia (RBA) rate rise relevant to the split.
    /// </summary>
    public double? RBARecentRateRise { get; set; }

    /// <summary>
    /// Gets or sets the most recent RBA rate drop relevant to the split.
    /// </summary>
    public double? RBARecentRateDrop { get; set; }

    /// <summary>
    /// Gets or sets the most recent reprice rate rise for the mortgage split.
    /// </summary>
    public double? RecentRepriceRateRise { get; set; }

    /// <summary>
    /// Gets or sets the most recent reprice rate drop for the mortgage split.
    /// </summary>
    public double? RecentRepriceRateDrop { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is a new facility.
    /// </summary>
    public bool ISNewFacility { get; set; }

    /// <summary>
    /// Gets or sets the desired product identifier for this mortgage split.
    /// </summary>
    public int? DesiredProductID { get; set; }

    /// <summary>
    /// Gets or sets the desired product loan-to-value ratio (LVR) for this split.
    /// </summary>
    public double? DesiredProductLVR { get; set; }

    /// <summary>
    /// Gets or sets the collection of mortgage usages related to this split.
    /// </summary>
    public IList<MortgageUsage>? MortgageUsages { get; set; } = new List<MortgageUsage>();

    #region Associated Requests

    /// <summary>
    /// Gets or sets the prepaid fees associated with the mortgage split.
    /// </summary>
    public double? PrepaidFees { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether Lenders Mortgage Insurance (LMI) is provided at cost.
    /// </summary>
    public bool ISLMIAtCost { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether LMI is paid by the funder.
    /// </summary>
    public bool ISLMIPaidByFunder { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether Quantity Surveyor (QS) services are provided at cost.
    /// </summary>
    public bool ISQSAtCost { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether legal services are provided at cost.
    /// </summary>
    public bool ISLegalsAtCost { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether independent advice is provided at cost.
    /// </summary>
    public bool ISIndependentAdviceAtCost { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether valuation services are provided at cost.
    /// </summary>
    public bool ISValuationAtCost { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a $300 valuation subsidy is applied.
    /// </summary>
    [Comment("$300 valuation subsidy")]
    public bool ISThreeHundredValuationSubsidy { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this split involves a pledge loan.
    /// </summary>
    public bool ISPledgeLoan { get; set; }

    /// <summary>
    /// Gets or sets the most recent RBA rate rise or drop for this split.
    /// </summary>
    public double? RBARecentRateRiseDrop { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the most recent RBA movement was a rate rise.
    /// </summary>
    [Comment("RBAs recent rate rise or drop")]
    public bool ISRBARecentRateRise { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the recent reprice has been reset for this split.
    /// </summary>
    public bool ISRecentRepriceReset { get; set; }

    /// <summary>
    /// Gets or sets the most recent reprice rate rise or drop for this split.
    /// </summary>
    public double? RecentRepriceRateRiseDrop { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there has been a recent reprice rate rise.
    /// </summary>
    public bool ISRecentRepriceRateRise { get; set; }

    /// <summary>
    /// Gets or sets the fixed interest rate applied to this split.
    /// </summary>
    public double? FixedRate { get; set; }

    /// <summary>
    /// Gets or sets the primary loan process conducted type general lookup identifier, defining loan application smoothness.
    /// </summary>
    [Comment("These property define the smoothness of loan application.")]
    public int? PrimaryLoanProcessConductedType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the secondary loan process conducted type general lookup identifier for the split.
    /// </summary>
    public int? SecondaryLoanProcessConductedType_GeneralLookUpID { get; set; }

    #endregion

    #region Remove fields

    /// <summary>
    /// Gets or sets a value indicating whether a second split is required for the mortgage.
    /// </summary>
    public bool ISSecondSplitRequired { get; set; }

    #region Second split

    /// <summary>
    /// Gets or sets the usage type general lookup identifier for the secondary split.
    /// </summary>
    public int? MortgageSecondaryUsageType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the cash rate for the secondary split.
    /// </summary>
    public double? CashRate { get; set; }

    /// <summary>
    /// Gets or sets the date on which the cash rate is applicable for the secondary split.
    /// </summary>
    public DateTime? CashRateOnDate { get; set; }

    /// <summary>
    /// Gets or sets the desired product identifier for the secondary split.
    /// </summary>
    public int? SecondaryDesiredProductID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the secondary split is for investment purposes.
    /// </summary>
    public bool ISInvestment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the secondary split is interest only.
    /// </summary>
    public bool ISInterestOnly { get; set; }

    /// <summary>
    /// Gets or sets the interest-only term in years for the secondary split.
    /// </summary>
    public int? InterestOnlyTermInYear { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the secondary split is fixed.
    /// </summary>
    public bool ISFixed { get; set; }

    /// <summary>
    /// Gets or sets the fixed term in years for the secondary split.
    /// </summary>
    public int? FixedTermInYear { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the secondary split includes RBA movements.
    /// </summary>
    public bool ISIncludingRBAs { get; set; }

    /// <summary>
    /// Gets or sets the facility type general lookup identifier for the split facility.
    /// </summary>
    public int? SplitFacilityType_GeneralLookUpID { get; set; }

    #endregion

    #endregion

    /// <summary>
    /// Gets or sets the Feedback and Indication entity associated with this mortgage split.
    /// </summary>
    public FeedbackAndIndication? MortgageSplit_FeedbackAndIndication { get; set; }
}
