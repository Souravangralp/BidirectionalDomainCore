using Bidirectional.DomainCore.BidOnboard.Entities.Crms;
using Bidirectional.DomainCore.BidOnboard.Enums;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a loan application entity, encapsulating the main details, status, and related information for a single loan application.
/// </summary>
public class LoanApplication : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the user ID associated with the loan application.
    /// </summary>
    public int? LoanApplication_UserID { get; set; }

    /// <summary>
    /// Gets or sets the organization ID associated with the loan application.
    /// </summary>
    public int? LoanApplication_OrganizationID { get; set; }

    /// <summary>
    /// Gets or sets the business unit ID associated with the loan application.
    /// </summary>
    public int? LoanApplication_BusinessUnitID { get; set; }

    /// <summary>
    /// Gets or sets the file number for the loan application.
    /// </summary>
    [Comment("TrackingNumber is changed to ProgressNumber as per client request on excel (07-04-2023) // ProgressNumber is now changed to Application Number (09-15-2023) // ApplicationNumber is now change to FileNumber (10-03-2023)")]
    public long? LoanAccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID representing the form type for this loan application.
    /// </summary>
    [Comment("This will indicate which type of form is this")]
    public int? FormType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the CRM sync log ID from which this loan application was obtained.
    /// </summary>
    [Comment("This will indicate from which Crm we are getting this loanApplication")]
    public int? LoanApplication_CrmSyncLogID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for loan type.
    /// </summary>
    public int? LoanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for secured personal type.
    /// </summary>
    public int? SecuredPersonalType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for required response time type.
    /// </summary>
    public int? RequiredResponseTimeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID indicating who guided the application process.
    /// </summary>
    public int? GuidedByType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is for a purchase.
    /// </summary>
    public bool ISPurchase { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is for a refinance.
    /// </summary>
    public bool ISRefinance { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if additional payments will be made to repay the loan as fast as possible.
    /// </summary>
    [Comment("Make additional repayments to pay off the loan as fast as possible as --(True)-- and Make the minimum repayments and pay off the loan over the entire term --(False)--")]
    public bool ISPayAdditionalPayment { get; set; }

    /// <summary>
    /// Gets or sets a description of the investment strategy associated with the loan.
    /// </summary>
    public string? InvestmentStrategyDescription { get; set; }

    /// <summary>
    /// Gets or sets financial freedom-related information for the application.
    /// </summary>
    [Comment("Information for FinancialFreedom is stored inside LoanApplicationFinancialFreedomMapper Table")]
    public string? FinancialFreedomDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if the applicant wants to reduce personal debt and invest in the future.
    /// </summary>
    [Comment("Reduce personal debt and invest in the future")]
    public bool ISReduceDebtAndInvest { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if this is a test lead for the LoanApplication UserModule.
    /// </summary>
    [Comment("This is for testing our LoanApplication UserModule")]
    public bool ISTestLead { get; set; }

    /// <summary>
    /// Gets or sets the quote number (broker sync).
    /// </summary>
    [Comment("Ken added he wants data to sync when the broker saves")]
    public int? MSt003QuoteNumber { get; set; }

    /// <summary>
    /// Gets or sets the quote date in UTC (broker sync).
    /// </summary>
    [Comment("Ken added he wants data to sync when the broker saves")]
    [Column(TypeName = "date")]
    public DateTime? MSt003QuoteDateUtc { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if the application has clawback.
    /// </summary>
    [Comment("true means Standard, false means Null")]
    public bool HASClawBack { get; set; }

    /// <summary>
    /// Gets or sets the date of approval in principal, in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ApprovalInPrincipalDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the letter of offer date, in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? LetterOfOfferDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the conditional approval date in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ConditionalApprovalDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the unconditional approval date in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? UnconditionalApprovalDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the settlement date in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? SettlementDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the requirement type lookup ID (from GeneralLookUpTable).
    /// </summary>
    [Comment("we will get this data from GeneralLookUpTable")]
    public int? RequirementType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the document type lookup ID (from GeneralLookUpTable).
    /// </summary>
    [Comment("We Will get this data from GeneralLookUpTable")]
    public int? DocType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the progression status or notes for the application.
    /// </summary>
    [Comment("need to confirm are these going to be text fields or will they contain data")]
    public string? ApplicationProgression { get; set; }

    /// <summary>
    /// Gets or sets the collection of security addresses for settlement purposes.
    /// </summary>
    public IList<SettlementSecurityAddress> SettlementSecurityAddresses { get; set; } = new List<SettlementSecurityAddress>();

    /// <summary>
    /// Gets or sets detailed comments explaining the purpose or reasoning for the loan.
    /// </summary>
    [Comment("Can you talk me trough what you are hoping to achieve? (for example: renovation, relocation, debt consolidation, school fees, holiday, car etc.)")]
    public string? DetailedComment { get; set; }

    /// <summary>
    /// Gets or sets the status type lookup ID (from GeneralLookUpTable). Used for saving as draft, etc.
    /// </summary>
    [Comment("We Will get this data from GeneralLookUpTable Save as draft")]
    public int? StatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lender ID associated with the application.
    /// </summary>
    public string? LenderID { get; set; }

    /// <summary>
    /// Gets or sets the name of the company associated with the loan application.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Gets or sets the desired product ID for the loan.
    /// </summary>
    public int? DesiredProductID { get; set; }

    /// <summary>
    /// Gets or sets the total loan amount being applied for.
    /// </summary>
    public decimal? TotalLoanAmount { get; set; }

    /// <summary>
    /// Gets or sets the total security amount for the loan.
    /// </summary>
    public decimal? TotalSecurity { get; set; }

    /// <summary>
    /// Gets or sets the Loan to Value Ratio (LVR).
    /// </summary>
    public double? LVR { get; set; }

    /// <summary>
    /// Gets or sets additional custom field 1.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets additional custom field 2.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets additional custom field 3.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the age difference between applicants.
    /// </summary>
    public int? ApplicantAgeDifference { get; set; }

    /// <summary>
    /// Gets or sets the Equifax credit index score for the applicant(s).
    /// </summary>
    public double? EquifaxCreditIndex { get; set; }

    /// <summary>
    /// Gets or sets the Illion credit index score for the applicant(s).
    /// </summary>
    public double? IllionCreditIndex { get; set; }

    /// <summary>
    /// Gets or sets the borrowing entity type lookup ID.
    /// </summary>
    public int? BorrowingEntityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the borrowing entity type lookup ID.
    /// </summary>
    public int? ApplicationForType_GeneralLookUpID { get; set; } // Individual, Company, Trust

    /// <summary>
    /// Gets or sets the guarantor entity type lookup ID.
    /// </summary>
    public int? GuarantorEntityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the HTML content for supporting documents (Section 16).
    /// </summary>
    [Comment("We will Save the HTML of Section 16 Supporting Documents")]
    public string? SupportingDocuments { get; set; }

    /// <summary>
    /// Gets or sets the current section of the loan application being processed.
    /// </summary>
    public int? CurrentLoanApplicationSection { get; set; }

    /// <summary>
    /// Gets or sets the external application identifier (NextGen or SalesTrekker ID) associated with this loan application.
    /// </summary>
    public string? ExternalApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the submission date of the loan application in UTC.
    /// </summary>
    public DateTime? SubmissionDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the current process stage of the loan application.
    /// </summary>
    public LoanApplicationProcessStage ProcessStage { get; set; }

    /// <summary>
    /// Gets or sets the list of contribution funds related to the loan application.
    /// </summary>
    public IList<ContributionFund> ContributionFunds { get; set; } = new List<ContributionFund>();

    /// <summary>
    /// Gets or sets the list of liabilities for the loan application.
    /// </summary>
    public IList<Liability> Liabilities { get; set; } = new List<Liability>();

    /// <summary>
    /// Gets or sets the list of other incomes for the loan application.
    /// </summary>
    public IList<OtherIncome> OtherIncomes { get; set; } = new List<OtherIncome>();

    /// <summary>
    /// Gets or sets the overview data for the loan application.
    /// </summary>
    public LoanApplicationOverview? LoanApplicationOverview { get; set; }

    /// <summary>
    /// Gets or sets the sales channel associated with the loan application.
    /// </summary>
    public SalesChannel? SalesChannel { get; set; }

    //public DLAResponse? DLAResponses { get; set; }

    /// <summary>
    /// Gets or sets the summary data for the loan application.
    /// </summary>
    public LoanApplicationSummary? LoanApplicationSummary { get; set; }

    /// <summary>
    /// Gets or sets the needs analysis for the loan application.
    /// </summary>
    public NeedsAnalyses? NeedsAnalyses { get; set; }

    /// <summary>
    /// Gets or sets the broker declaration information for the loan application.
    /// </summary>
    public BrokerDeclaration? BrokerDeclaration { get; set; }

    /// <summary>
    /// Gets or sets the customer declaration for the loan application.
    /// </summary>
    public CustomerDeclaration? CustomerDeclaration { get; set; }

    /// <summary>
    /// Gets or sets the recommendation details for the loan application.
    /// </summary>
    public Recommendation? Recommendation { get; set; }

    /// <summary>
    /// Gets or sets observations related to the loan application.
    /// </summary>
    public ApplicantObservation? Observation { get; set; }

    /// <summary>
    /// Gets or sets first-time buyer information for the loan application.
    /// </summary>
    public FirstTimeBuyer? FirstTimeBuyer { get; set; }

    /// <summary>
    /// Gets or sets the list of loans that are not being refinanced.
    /// </summary>
    public List<LoanNotBeingRefinanced> LoansNotBeingRefinanced { get; set; } = new List<LoanNotBeingRefinanced>();

    /// <summary>
    /// Gets or sets the funds-to-complete must balance data for the loan application.
    /// </summary>
    public FundsToCompleteMustBalance? FundsToCompleteMustBalance { get; set; }

    /// <summary>
    /// Gets or sets the list of loan splits for the loan application.
    /// </summary>
    public IList<LoanSplit> LoanSplits { get; set; } = new List<LoanSplit>();

    /// <summary>
    /// Gets or sets the list of pertinent contacts related to the loan application.
    /// </summary>
    public IList<PertinentContact> PertinentContacts { get; set; } = new List<PertinentContact>();

    /// <summary>
    /// Gets or sets the credit history for financial and non-financial data.
    /// </summary>
    public IList<CreditHistoryForFinancialAndNonFinancial> CreditHistoryForFinancialAndNonFinancials { get; private set; } = new List<CreditHistoryForFinancialAndNonFinancial>();

    /// <summary>
    /// Gets or sets the list of mortgages associated with the loan application.
    /// </summary>
    public IList<Mortgage> Mortgages { get; set; } = new List<Mortgage>();

    /// <summary>
    /// Gets or sets the list of feedback and indications for the loan application.
    /// </summary>
    public IList<FeedbackAndIndication> FeedbackAndIndications { get; set; } = new List<FeedbackAndIndication>();

    /// <summary>
    /// Gets or sets the list of related entities connected to the loan application.
    /// </summary>
    public IList<RelatedEntity> RelatedEntities { get; set; } = new List<RelatedEntity>();

    /// <summary>
    /// Gets or sets the checklist for the loan application.
    /// </summary>
    public Checklist? Checklist { get; set; }

    /// <summary>
    /// Gets or sets the list of other observations for the loan application.
    /// </summary>
    public IList<OtherObservation> OtherObservations { get; set; } = new List<OtherObservation>();

    /// <summary>
    /// Gets or sets the loan application history records.
    /// </summary>
    public IList<LoanApplicationHistory> LoanApplicationHistories { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of applicant mappers linking applicants to the loan application.
    /// </summary>
    [InverseProperty(nameof(LoanApplicationApplicantMapper.LoanApplicationApplicantMapper_LoanApplication))]
    public IList<LoanApplicationApplicantMapper> LoanApplicationApplicantMappers { get; set; } = [];

    /// <summary>
    /// Gets or sets financial considerations related to the loan application.
    /// </summary>
    public FinancialConsideration? FinancialConsideration { get; set; }

    /// <summary>
    /// Gets or sets the CRM sync log entity related to the application.
    /// </summary>
    public CrmSyncLog? LoanApplication_CrmSyncLog { get; set; }

    /// <summary>
    /// Gets or sets the user entity associated with this loan application.
    /// </summary>
    public User? LoanApplication_User { get; set; }

    /// <summary>
    /// Gets or sets the organization entity associated with this loan application.
    /// </summary>
    public Organization? LoanApplication_Organization { get; set; }

    /// <summary>
    /// Gets or sets the business unit entity associated with this loan application.
    /// </summary>
    public BusinessUnit? LoanApplication_BusinessUnit { get; set; }

    /// <summary>
    /// Gets or sets the list of assignments for the loan application.
    /// </summary>
    public IList<LoanApplicationAssignment> LoanApplicationAssignments { get; set; } = new List<LoanApplicationAssignment>();

    /// <summary>
    /// Gets or sets open events for this loan application (each user open is a separate row).
    /// </summary>
    public IList<LoanApplicationUserOpen> LoanApplicationUserOpens { get; set; } = [];
}
