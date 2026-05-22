namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Credit history snapshot summary for a Form009 company applicant (section 9r).
/// </summary>
public class CreditHistorySnapshot : BaseAuditableEntity
{
    public int? CreditHistorySnapshot_CompanyApplicantID { get; set; }

    public int? CreditHistorySnapshot_IntroductionToTheCustomerID { get; set; }

    [Comment("all fields seeded under type 'CreditHistorySnapshot' in GeneralLookUp Table")]
    public int? CreditHistorySnapshotType_GeneralLookUpID { get; set; }

    public int? Number { get; set; }

    public double? TransactionAmount { get; set; }

    #region Form009 company applicant credit history summary

    public int? CreditEnquiriesNumber { get; set; }

    public decimal? CreditEnquiriesAmount { get; set; }

    public int? CreditEnquiriesUnder12MonthsNumber { get; set; }

    public decimal? CreditEnquiriesUnder12MonthsAmount { get; set; }

    public int? CreditEnquiriesOver12MonthsNumber { get; set; }

    public decimal? CreditEnquiriesOver12MonthsAmount { get; set; }

    public int? BrokerDealerEnquiriesNumber { get; set; }

    public decimal? BrokerDealerEnquiriesAmount { get; set; }

    public int? BrokerDealerEnquiriesUnder12MonthsNumber { get; set; }

    public decimal? BrokerDealerEnquiriesUnder12MonthsAmount { get; set; }

    public int? BrokerDealerEnquiriesOver12MonthsNumber { get; set; }

    public decimal? BrokerDealerEnquiriesOver12MonthsAmount { get; set; }

    public int? MercantileAgentEnquiriesNumber { get; set; }

    public decimal? MercantileAgentEnquiriesAmount { get; set; }

    public int? MercantileAgentEnquiriesUnder12MonthsNumber { get; set; }

    public decimal? MercantileAgentEnquiriesUnder12MonthsAmount { get; set; }

    public int? MercantileAgentEnquiriesOver12MonthsNumber { get; set; }

    public decimal? MercantileAgentEnquiriesOver12MonthsAmount { get; set; }

    public int? PaymentDefaultsNumber { get; set; }

    public decimal? PaymentDefaultsAmount { get; set; }

    public int? DefaultsUnder12MonthsNumber { get; set; }

    public decimal? DefaultsUnder12MonthsAmount { get; set; }

    public int? DefaultsOver12MonthsNumber { get; set; }

    public decimal? DefaultsOver12MonthsAmount { get; set; }

    public int? TelcoDefaultsUnder12MonthsNumber { get; set; }

    public decimal? TelcoDefaultsUnder12MonthsAmount { get; set; }

    public int? UtilityDefaultsUnder12MonthsNumber { get; set; }

    public decimal? UtilityDefaultsUnder12MonthsAmount { get; set; }

    public int? OtherDefaultsUnder12MonthsNumber { get; set; }

    public decimal? OtherDefaultsUnder12MonthsAmount { get; set; }

    public int? PaidDefaultsNumber { get; set; }

    public decimal? PaidDefaultsAmount { get; set; }

    public int? OtherStatusDefaultsNumber { get; set; }

    public decimal? OtherStatusDefaultsAmount { get; set; }

    #endregion

    public CompanyApplicant? CreditHistorySnapshot_CompanyApplicant { get; set; }

    public IntroductionToTheCustomer? CreditHistorySnapshot_IntroductionToTheCustomer { get; set; }
}
