using AutoMapper;
using Bidirectional.Application.Common.Interfaces;
using Bidirectional.Application.Common.Models;
using Bidirectional.Application.Common.StoredProcedure;
using Bidirectional.DomainCore.BidOnboard.Assessment.Assignments;
using Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;
using Bidirectional.DomainCore.BidOnboard.Assessment.Templates;
using Bidirectional.DomainCore.BidOnboard.Entities;
using Bidirectional.DomainCore.BidOnboard.Entities.Audit;
using Bidirectional.DomainCore.BidOnboard.Entities.Crms;
using Bidirectional.DomainCore.BidOnboard.Entities.Generals.Industries;
using Bidirectional.DomainCore.BidOnboard.Entities.Generals.Occupations;
using Bidirectional.DomainCore.BidOnboard.Entities.Leads;
using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;
using Bidirectional.DomainCore.BidOnboard.Entities.Organizations;
using Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;
using Bidirectional.DomainCore.BidOnboard.Entities.UserActivity;
using Bidirectional.DomainCore.BidOnboard.Entities.Valocity;
using Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common;
using Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Helpers;
using Bidirectional.DomainCore.BidOnboard.Permission;
using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;
using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.OrganizationBusinessUnits;
using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.Users;
using Bidirectional.DomainCore.BidOnboard.Entities.Permissions;
using Bidirectional.DomainCore.BidOnboard.Entities.Privacy;
using Bidirectional.DomainCore.BidOnboard.Entities.UserRepresentative;
using Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.Helpers;
using Bidirectional.DomainCore.Persistence.Configurations.Bid;
using Bidirectional.DomainCore.Persistence.Configurations.Onboarding;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Concurrent;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using Crm = Bidirectional.DomainCore.BidOnboard.Entities.Crms.Crm;

namespace Bidirectional.DomainCore.Persistence;

/// <summary>
/// Represents the application's database context, handling DbSets, configuration, and persistence logic.
/// </summary>
public partial class PlatformDbContext : DbContext
{
    #region Fields

    private readonly ICurrentUserService _currentUserService;
    private readonly IGetLocalIPAddress _getLocalUserIPAddress;
    private readonly IMediator _mediator;
    private readonly ISecretProvider _azureKeyVaultService;
    private readonly IMapper _mapper;
    private readonly ILogger _logger = null!;
    private readonly ITextPolicyService _textPolicyService;
    private static readonly ConcurrentDictionary<IEntityType, IProperty[]> StringPropsCache = new();
    private readonly IConfiguration _configurationSection;

    #endregion

    #region Ctor
    /// <summary>
    /// Initializes a new instance of the <see cref="PlatformDbContext"/> class with required dependencies.
    /// </summary>
    /// <param name="currentUserService">Service for retrieving the current user.</param>
    /// <param name="getLocalUserIPAddress">Service for retrieving the user's IP address.</param>
    /// <param name="options">The options to configure the context.</param>
    /// <param name="azureKeyVaultService">Service for accessing secrets in Azure Key Vault.</param>
    /// <param name="mediator">Mediator for sending domain events.</param>
    /// <param name="mapper">Automapper service for mapping entities.</param>
    /// <param name="logger">Logger instance for this context.</param>
    /// <param name="textPolicyService">Service for text policy validation.</param>
    /// <param name="configurationSection">Configuration section used for secrets and settings.</param>
    public PlatformDbContext(
        ICurrentUserService currentUserService,
        IGetLocalIPAddress getLocalUserIPAddress,
        DbContextOptions options,
        ISecretProvider azureKeyVaultService,
        IMediator mediator,
        IMapper mapper,
        ILogger logger,
        ITextPolicyService textPolicyService,
        IConfiguration configurationSection)
        : base(options)
    {
        _currentUserService = currentUserService;
        _getLocalUserIPAddress = getLocalUserIPAddress;
        _mediator = mediator;
        _azureKeyVaultService = azureKeyVaultService;
        _mapper = mapper;
        _logger = logger;
        _textPolicyService = textPolicyService;
        _configurationSection = configurationSection;
    }

    /// <summary>
    /// Lightweight constructor for onboarding-only hosts (Identity, seeding).
    /// </summary>
    public PlatformDbContext(DbContextOptions options, IConfiguration configurationSection)
        : base(options)
    {
        _configurationSection = configurationSection;
        _logger = Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
    }

    #endregion

    #region Methods

    #region DbContext

    /// <summary>
    /// Gets the DbSet for Domains.
    /// </summary>
    public DbSet<Bidirectional.DomainCore.BidOnboard.Entities.Settings.Domain> Domains => Set<Bidirectional.DomainCore.BidOnboard.Entities.Settings.Domain>();

    /// <summary>
    /// Gets the DbSet for other observations.
    /// </summary>
    public DbSet<OtherObservation> OtherObservations => Set<OtherObservation>();

    /// <summary>
    /// Gets the DbSet for percentage ownership entities.
    /// </summary>
    public DbSet<OwnershipPercentage> OwnershipPercentages => Set<OwnershipPercentage>();

    /// <summary>
    /// Gets the DbSet for related entity actions.
    /// </summary>
    public DbSet<RelatedEntityAction> RelatedEntityActions => Set<RelatedEntityAction>();

    /// <summary>
    /// Gets the DbSet for loan application inclusive check mappers.
    /// </summary>
    public DbSet<LoanApplicationInclusiveCheckMapper> LoanApplicationInclusiveCheckMapper => Set<LoanApplicationInclusiveCheckMapper>();

    /// <summary>
    /// Gets the DbSet for income statements.
    /// </summary>
    public DbSet<IncomeStatement> IncomeStatements => Set<IncomeStatement>();

    /// <summary>
    /// Gets the DbSet for check lists.
    /// </summary>
    public DbSet<Checklist> Checklists => Set<Checklist>();

    //public DbSet<InclusiveCheck> InclusiveChecks => Set<InclusiveCheck>();

    //public DbSet<IncomeDossier> IncomeDossiers => Set<IncomeDossier>();

    /// <summary>
    /// Gets the DbSet for occupations.
    /// </summary>
    public DbSet<Occupation> Occupations => Set<Occupation>();

    /// <summary>
    /// Gets the DbSet for industries.
    /// </summary>
    public DbSet<Industry> Industries => Set<Industry>();

    /// <summary>
    /// Gets the DbSet for countries.
    /// </summary>
    /// <summary>
    /// Gets the DbSet for countries (loan schema). Onboarding countries: <see cref="IOnboardingDbContext.Countries"/>.
    /// </summary>
    public DbSet<Country> Countries => Set<Country>();

    /// <summary>
    /// Gets the DbSet for states (loan schema). Onboarding states: <see cref="IOnboardingDbContext.States"/>.
    /// </summary>
    public DbSet<State> States => Set<State>();

    /// <summary>
    /// Gets the DbSet for users (loan schema). Onboarding users: <see cref="IOnboardingDbContext.Users"/>.
    /// </summary>
    public DbSet<User> Users => Set<User>();

    /// <summary>
    /// Gets the DbSet for organizations (loan schema). Onboarding organisations: <see cref="IOnboardingDbContext.Organizations"/>.
    /// </summary>
    public DbSet<Organization> Organizations => Set<Organization>();

    /// <summary>
    /// Gets the DbSet for loan application financial freedom mappers.
    /// </summary>
    public DbSet<LoanApplicationFinancialFreedomMapper> LoanApplicationFinancialFreedomMapper => Set<LoanApplicationFinancialFreedomMapper>();

    /// <summary>
    /// Gets the DbSet for loan application stage mappers.
    /// </summary>
    public DbSet<LoanApplicationStageMapper> LoanApplicationStageMapper => Set<LoanApplicationStageMapper>();

    /// <summary>
    /// Gets the DbSet for loan application applicant mappers.
    /// </summary>
    public DbSet<LoanApplicationApplicantMapper> LoanApplicationApplicantMapper => Set<LoanApplicationApplicantMapper>();

    /// <summary>
    /// Gets the DbSet for CRM sync logs.
    /// </summary>
    public DbSet<CrmSyncLog> CrmSyncLogs => Set<CrmSyncLog>();

    /// <summary>
    /// Gets the DbSet for CRMs.
    /// </summary>
    public DbSet<Crm> Crms => Set<Crm>();

    /// <summary>
    /// Gets the DbSet for general lookups.
    /// </summary>
    public DbSet<Bidirectional.DomainCore.BidOnboard.Entities.Generals.GeneralLookup> GeneralLookups => Set<Bidirectional.DomainCore.BidOnboard.Entities.Generals.GeneralLookup>();

    /// <summary>
    /// Gets the DbSet for loan applications.
    /// </summary>
    public DbSet<LoanApplication> LoanApplications => Set<LoanApplication>();

    /// <summary>
    /// Gets the DbSet for accepted privacy consents.
    /// </summary>
    public DbSet<AcceptedPrivacyPolicy> AcceptedPrivacyPolicies => Set<AcceptedPrivacyPolicy>();

    /// <summary>
    /// Gets the DbSet for consent documents.
    /// </summary>
    public DbSet<PrivacyPolicy> PrivacyPolicies => Set<PrivacyPolicy>();

    /// <summary>
    /// Gets the DbSet for settlement security addresses.
    /// </summary>
    public DbSet<SettlementSecurityAddress> SettlementSecurityAddresses => Set<SettlementSecurityAddress>();

    /// <summary>
    /// Gets the DbSet for bridging and relocation records.
    /// </summary>
    public DbSet<BridgingAndRelocation> BridgingAndRelocations => Set<BridgingAndRelocation>();

    //public DbSet<DLAResponse> DLAResponses => Set<DLAResponse>();

    /// <summary>
    /// Gets the DbSet for construction entities.
    /// </summary>
    public DbSet<Construction> Constructions => Set<Construction>();

    /// <summary>
    /// Gets the DbSet for addresses.
    /// </summary>
    public DbSet<Address> Addresses => Set<Address>();

    /// <summary>
    /// Gets the DbSet for company applicants.
    /// </summary>
    public DbSet<CompanyApplicant> CompanyApplicants => Set<CompanyApplicant>();

    /// <summary>
    /// Gets the DbSet for industry classification entities.
    /// </summary>
    public DbSet<IndustryClassification> IndustryClassifications => Set<IndustryClassification>();

    /// <summary>
    /// Gets the DbSet for company scores.
    /// </summary>
    public DbSet<CompanyScore> CompanyScores => Set<CompanyScore>();

    /// <summary>
    /// Gets the DbSet for company shares.
    /// </summary>
    public DbSet<CompanyShare> CompanyShares => Set<CompanyShare>();

    /// <summary>
    /// Gets the DbSet for company financials.
    /// </summary>
    public DbSet<CompanyFinancial> CompanyFinancials => Set<CompanyFinancial>();

    /// <summary>
    /// Gets the DbSet for contribution funds.
    /// </summary>
    public DbSet<ContributionFund> ContributionFunds => Set<ContributionFund>();

    /// <summary>
    /// Gets the DbSet for applicants.
    /// </summary>
    public DbSet<Applicant> Applicants => Set<Applicant>();

    /// <summary>
    /// Gets the DbSet for higher education loan programs.
    /// </summary>
    public DbSet<HigherEducationLoanProgram> HigherEducationLoanPrograms => Set<HigherEducationLoanProgram>();

    /// <summary>
    /// Gets the DbSet for PAYG records.
    /// </summary>
    public DbSet<Payg> Paygs => Set<Payg>();

    /// <summary>
    /// Gets the DbSet for not employed entities.
    /// </summary>
    public DbSet<NotEmployed> NotEmployed => Set<NotEmployed>();

    /// <summary>
    /// Gets the DbSet for self-employed entities.
    /// </summary>
    public DbSet<SelfEmploymentDetail> SelfEmploymentDetails => Set<SelfEmploymentDetail>();

    /// <summary>
    /// Gets the DbSet for households.
    /// </summary>
    public DbSet<Household> Households => Set<Household>();

    /// <summary>
    /// Gets the DbSet for loan securities.
    /// </summary>
    public DbSet<LoanSecurity> LoanSecurities => Set<LoanSecurity>();

    /// <summary>
    /// Gets the DbSet for broker declarations.
    /// </summary>
    public DbSet<BrokerDeclaration> BrokerDeclarations => Set<BrokerDeclaration>();

    /// <summary>
    /// Gets the DbSet for proof of identity records.
    /// </summary>
    public DbSet<ProofOfIdentity> ProofOfIdentities => Set<ProofOfIdentity>();

    /// <summary>
    /// Gets the DbSet for recommendations.
    /// </summary>
    public DbSet<Recommendation> Recommendations => Set<Recommendation>();

    /// <summary>
    /// Gets the DbSet for observations.
    /// </summary>
    public DbSet<ApplicantObservation> ApplicantObservations => Set<ApplicantObservation>();

    /// <summary>
    /// Gets the DbSet for customer declarations.
    /// </summary>
    public DbSet<CustomerDeclaration> CustomerDeclarations => Set<CustomerDeclaration>();

    /// <summary>
    /// Gets the DbSet for customer declaration features.
    /// </summary>
    public DbSet<CustomerDeclarationFeature> CustomerDeclarationFeatures => Set<CustomerDeclarationFeature>();

    //public DbSet<WritOfExecution> WritOfExecutions => Set<WritOfExecution>();

    /// <summary>
    /// Gets the DbSet for first time buyers.
    /// </summary>
    public DbSet<FirstTimeBuyer> FirstTimeBuyers => Set<FirstTimeBuyer>();

    /// <summary>
    /// Gets the DbSet for pertinent contacts.
    /// </summary>
    public DbSet<PertinentContact> PertinentContacts => Set<PertinentContact>();

    /// <summary>
    /// Gets the DbSet for trust applicants.
    /// </summary>
    public DbSet<Trust> Trusts => Set<Trust>();

    /// <summary>
    /// Gets the DbSet for related entities.
    /// </summary>
    public DbSet<RelatedEntity> RelatedEntities => Set<RelatedEntity>();

    /// <summary>
    /// Gets the DbSet for mortgages.
    /// </summary>
    public DbSet<Mortgage> Mortgages => Set<Mortgage>();

    /// <summary>
    /// Gets the DbSet for mortgage account informations.
    /// </summary>
    public DbSet<MortgageAccountInformation> MortgageAccountInformations => Set<MortgageAccountInformation>();

    /// <summary>
    /// Gets the DbSet for superannuation funds.
    /// </summary>
    public DbSet<SuperannuationFund> SuperannuationFunds => Set<SuperannuationFund>();

    /// <summary>
    /// Gets the DbSet for passports.
    /// </summary>
    public DbSet<Passport> Passports => Set<Passport>();

    /// <summary>
    /// Gets the DbSet for Medicare entities.
    /// </summary>
    public DbSet<MedicareDetail> MedicareDetails => Set<MedicareDetail>();

    /// <summary>
    /// Gets the DbSet for summaries.
    /// </summary>
    public DbSet<LoanApplicationSummary> LoanApplicationSummaries => Set<LoanApplicationSummary>();

    /// <summary>
    /// Gets the DbSet for credit history for financial and non-financial entities.
    /// </summary>
    public DbSet<CreditHistoryForFinancialAndNonFinancial> CreditHistoryForFinancialAndNonFinancials => Set<CreditHistoryForFinancialAndNonFinancial>();

    /// <summary>
    /// Gets the DbSet for court judgement details.
    /// </summary>
    public DbSet<CourtJudgementDetail> CourtJudgementDetails => Set<CourtJudgementDetail>();

    /// <summary>
    /// Gets the DbSet for undisclosed liabilities.
    /// </summary>
    public DbSet<UndisclosedLiability> UndisclosedLiabilities => Set<UndisclosedLiability>();

    /// <summary>
    /// Gets the DbSet for account and repayments.
    /// </summary>
    public DbSet<AccountAndRepayment> AccountAndRepayments => Set<AccountAndRepayment>();

    /// <summary>
    /// Gets the DbSet for liability repayments.
    /// </summary>
    public DbSet<LiabilityRepayment> LiabilityRepayments => Set<LiabilityRepayment>();

    /// <summary>
    /// Gets the DbSet for introduction to the customer records.
    /// </summary>
    public DbSet<IntroductionToTheCustomer> IntroductionToTheCustomers => Set<IntroductionToTheCustomer>();

    /// <summary>
    /// Gets the DbSet for motor vehicles.
    /// </summary>
    public DbSet<MotorVehicle> MotorVehicles => Set<MotorVehicle>();

    /// <summary>
    /// Gets the DbSet for saving and term deposit accounts.
    /// </summary>
    public DbSet<SavingAndTermDepositAccount> SavingAndTermDepositAccounts => Set<SavingAndTermDepositAccount>();

    /// <summary>
    /// Gets the DbSet for other assets.
    /// </summary>
    public DbSet<OtherAsset> OtherAssets => Set<OtherAsset>();

    /// <summary>
    /// Gets the DbSet for real estate assets.
    /// </summary>
    public DbSet<RealEstateAsset> RealEstateAssets => Set<RealEstateAsset>();

    /// <summary>
    /// Gets the DbSet for dwelling purposes.
    /// </summary>
    public DbSet<DwellingPurpose> DwellingPurposes => Set<DwellingPurpose>();

    /// <summary>
    /// Gets the DbSet for card details.
    /// </summary>
    public DbSet<CardDetail> CardDetails => Set<CardDetail>();

    /// <summary>
    /// Gets the DbSet for loans other than mortgages.
    /// </summary>
    public DbSet<LoansOtherThanMortgage> LoansOtherThanMortgages => Set<LoansOtherThanMortgage>();

    /// <summary>
    /// Gets the DbSet for loans not being refinanced.
    /// </summary>
    public DbSet<LoanNotBeingRefinanced> LoanNotBeingRefinanced => Set<LoanNotBeingRefinanced>();

    /// <summary>
    /// Gets the DbSet for feedback and indications.
    /// </summary>
    public DbSet<FeedbackAndIndication> FeedbackAndIndications => Set<FeedbackAndIndication>();

    /// <summary>
    /// Gets the DbSet for mortgage splits.
    /// </summary>
    public DbSet<MortgageSplit> MortgageSplits => Set<MortgageSplit>();

    /// <summary>
    /// Gets the DbSet for mortgage usages.
    /// </summary>
    public DbSet<MortgageUsage> MortgageUsages => Set<MortgageUsage>();

    /// <summary>
    /// Gets the DbSet for post settlement events.
    /// </summary>
    public DbSet<PostSettlementEvent> PostSettlementEvents => Set<PostSettlementEvent>();

    /// <summary>
    /// Gets the DbSet for documentation instructions.
    /// </summary>
    public DbSet<DocumentationInstruction> DocumentationInstructions => Set<DocumentationInstruction>();

    /// <summary>
    /// Gets the DbSet for borrowers.
    /// </summary>
    public DbSet<Borrower> Borrowers => Set<Borrower>();

    /// <summary>
    /// Gets the DbSet for contacts.
    /// </summary>
    public DbSet<Contact> Contacts => Set<Contact>();

    /// <summary>
    /// Gets the DbSet for contact persons.
    /// </summary>
    public DbSet<ContactPerson> ContactPersons => Set<ContactPerson>();

    /// <summary>
    /// Gets the DbSet for dependents.
    /// </summary>
    public DbSet<Dependent> Dependents => Set<Dependent>();

    /// <summary>
    /// Gets the DbSet for lending purposes.
    /// </summary>
    public DbSet<LendingPurpose> LendingPurposes => Set<LendingPurpose>();

    /// <summary>
    /// Gets the DbSet for liabilities.
    /// </summary>
    public DbSet<Liability> Liabilities => Set<Liability>();

    /// <summary>
    /// Gets the DbSet for liability securities.
    /// </summary>
    public DbSet<LiabilitySecurity> LiabilitySecurities => Set<LiabilitySecurity>();

    //public DbSet<MortgagorDetail> MortgagorDetails => Set<MortgagorDetail>();

    /// <summary>
    /// Gets the DbSet for living expenses.
    /// </summary>
    public DbSet<LivingExpense> LivingExpenses => Set<LivingExpense>();

    /// <summary>
    /// Gets the DbSet for loan details.
    /// </summary>
    public DbSet<LoanDetail> LoanDetails => Set<LoanDetail>();

    /// <summary>
    /// Gets the DbSet for loan detail securities.
    /// </summary>
    public DbSet<LoanDetailSecurity> LoanDetailSecurities => Set<LoanDetailSecurity>();

    /// <summary>
    /// Gets the DbSet for loan purposes.
    /// </summary>
    public DbSet<LoanPurpose> LoanPurposes => Set<LoanPurpose>();

    /// <summary>
    /// Gets the DbSet for other commitments.
    /// </summary>
    public DbSet<OtherCommitment> OtherCommitments => Set<OtherCommitment>();

    /// <summary>
    /// Gets the DbSet for overviews.
    /// </summary>
    public DbSet<LoanApplicationOverview> LoanApplicationOverviews => Set<LoanApplicationOverview>();

    /// <summary>
    /// Gets the DbSet for percent owner real estate assets.
    /// </summary>
    public DbSet<RealEstateAssetOwnershipPercentage> RealEstateAssetOwnershipPercentages => Set<RealEstateAssetOwnershipPercentage>();

    /// <summary>
    /// Gets the DbSet for real estate income shares.
    /// </summary>
    public DbSet<RealEstateIncomeShare> RealEstateIncomeShares => Set<RealEstateIncomeShare>();

    /// <summary>
    /// Gets the DbSet for regular repayments.
    /// </summary>
    public DbSet<RegularRepayment> RegularRepayments => Set<RegularRepayment>();

    /// <summary>
    /// Gets the DbSet for sales channels.
    /// </summary>
    public DbSet<SalesChannel> SalesChannels => Set<SalesChannel>();

    /// <summary>
    /// Gets the DbSet for sales channel companies.
    /// </summary>
    public DbSet<SalesChannelCompany> SalesChannelCompanies => Set<SalesChannelCompany>();

    /// <summary>
    /// Gets the DbSet for sales channel introducers.
    /// </summary>
    public DbSet<SalesChannelIntroducer> SalesChannelIntroducers => Set<SalesChannelIntroducer>();

    /// <summary>
    /// Gets the DbSet for sales channel loan writers.
    /// </summary>
    public DbSet<SalesChannelLoanWriter> SalesChannelLoanWriters => Set<SalesChannelLoanWriter>();

    /// <summary>
    /// Gets the DbSet for owners.
    /// </summary>
    public DbSet<Owner> Owners => Set<Owner>();

    /// <summary>
    /// Gets the DbSet for terms.
    /// </summary>
    public DbSet<Term> Terms => Set<Term>();

    /// <summary>
    /// Gets the DbSet for applicant retirement details.
    /// </summary>
    public DbSet<ApplicantRetirementDetail> ApplicantRetirementDetails => Set<ApplicantRetirementDetail>();

    /// <summary>
    /// Gets the DbSet for application purposes.
    /// </summary>
    public DbSet<ApplicationPurpose> ApplicationPurposes => Set<ApplicationPurpose>();

    //public DbSet<ContactAddress> ContactAddresses => Set<ContactAddress>();

    /// <summary>
    /// Gets the DbSet for interest rate details.
    /// </summary>
    public DbSet<InterestRateDetail> InterestRateDetails => Set<InterestRateDetail>();

    /// <summary>
    /// Gets the DbSet for preference repayment details.
    /// </summary>
    public DbSet<PreferenceRepaymentDetail> PreferenceRepaymentDetails => Set<PreferenceRepaymentDetail>();

    /// <summary>
    /// Gets the DbSet for funds details.
    /// </summary>
    public DbSet<FundsDetail> FundsDetails => Set<FundsDetail>();

    /// <summary>
    /// Gets the DbSet for need analyses.
    /// </summary>
    public DbSet<NeedsAnalyses> NeedsAnalyses => Set<NeedsAnalyses>();

    /// <summary>
    /// Gets the DbSet for reasons.
    /// </summary>
    public DbSet<ApprovalReason> ApprovalReasons => Set<ApprovalReason>();

    /// <summary>
    /// Gets the DbSet for refinancing consolidations.
    /// </summary>
    public DbSet<RefinancingConsolidation> RefinancingConsolidations => Set<RefinancingConsolidation>();

    /// <summary>
    /// Gets the DbSet for repayment options.
    /// </summary>
    public DbSet<RepaymentOption> RepaymentOptions => Set<RepaymentOption>();

    /// <summary>
    /// Gets the DbSet for next of kin records.
    /// </summary>
    public DbSet<NextOfKin> NextOfKins => Set<NextOfKin>();

    /// <summary>
    /// Gets the DbSet for preferences.
    /// </summary>
    public DbSet<LoanApplicationPreference> LoanApplicationPreferences => Set<LoanApplicationPreference>();

    /// <summary>
    /// Gets the DbSet for court judgements.
    /// </summary>
    public DbSet<CourtJudgement> CourtJudgements => Set<CourtJudgement>();

    /// <summary>
    /// Gets the DbSet for selected features.
    /// </summary>
    public DbSet<SelectedFeature> SelectedFeatures => Set<SelectedFeature>();

    /// <summary>
    /// Gets the DbSet for documents.
    /// </summary>
    public DbSet<Document> Documents => Set<Document>();

    /// <summary>
    /// Gets the DbSet for other incomes.
    /// </summary>
    public DbSet<OtherIncome> OtherIncomes => Set<OtherIncome>();

    /// <summary>
    /// Gets the DbSet for incomes.
    /// </summary>
    public DbSet<Income> Incomes => Set<Income>();

    /// <summary>
    /// Gets the DbSet for insurances.
    /// </summary>
    public DbSet<Insurance> Insurances => Set<Insurance>();

    /// <summary>
    /// Gets the DbSet for loan products.
    /// </summary>
    public DbSet<LoanProduct> LoanProducts => Set<LoanProduct>();

    /// <summary>
    /// Gets the DbSet for mitigants.
    /// </summary>
    public DbSet<Mitigant> Mitigants => Set<Mitigant>();

    /// <summary>
    /// Gets the DbSet for significant changes.
    /// </summary>
    public DbSet<SignificantChange> SignificantChanges => Set<SignificantChange>();

    /// <summary>
    /// Gets the DbSet for financial responsibilities.
    /// </summary>
    public DbSet<FinancialResponsible> FinancialResponsibilities => Set<FinancialResponsible>();

    /// <summary>
    /// Gets the DbSet for circumstances for applicants.
    /// </summary>
    public DbSet<CircumstancesForApplicant> CircumstancesForApplicants => Set<CircumstancesForApplicant>();

    //public DbSet<SecurityQuestion> SecurityQuestions => Set<SecurityQuestion>();

    //public DbSet<SecurityQuestionMapper> SecurityQuestionMapper => Set<SecurityQuestionMapper>();

    //public DbSet<DesiredProduct> DesiredProducts => Set<DesiredProduct>();

    //public DbSet<DesiredProductRoleCompanyMapper> DesiredProductRoleCompanyMapper => Set<DesiredProductRoleCompanyMapper>();

    /// <summary>
    /// Gets the DbSet for units and apartments.
    /// </summary>
    public DbSet<UnitsAndApartment> UnitsAndApartments => Set<UnitsAndApartment>();

    /// <summary>
    /// Gets the DbSet for annual depreciation records.
    /// </summary>
    public DbSet<AnnualDepreciation> AnnualDepreciations => Set<AnnualDepreciation>();

    /// <summary>
    /// Gets the DbSet for valuation feedbacks.
    /// </summary>
    public DbSet<ValuationFeedback> ValuationFeedbacks => Set<ValuationFeedback>();

    /// <summary>
    /// Gets the DbSet for cashouts.
    /// </summary>
    public DbSet<Cashout> Cashouts => Set<Cashout>();

    /// <summary>
    /// Gets the DbSet for default listed entities.
    /// </summary>
    public DbSet<DefaultListing> DefaultListings => Set<DefaultListing>();

    /// <summary>
    /// Gets the DbSet for construction bank account signatory details.
    /// </summary>
    public DbSet<ConstructionBankAccountSignatoryDetail> ConstructionBankAccountSignatoryDetails => Set<ConstructionBankAccountSignatoryDetail>();

    /// <summary>
    /// Gets the DbSet for company incomes.
    /// </summary>
    public DbSet<CompanyIncome> CompanyIncomes => Set<CompanyIncome>();

    /// <summary>
    /// Gets the DbSet for percent owner non-real estate assets.
    /// </summary>
    public DbSet<NonRealEstateAssetOwnershipPercentage> NonRealEstateAssetOwnershipPercentages => Set<NonRealEstateAssetOwnershipPercentage>();

    /// <summary>
    /// Gets the DbSet for percent owner liabilities.
    /// </summary>
    public DbSet<OwnerLiabilityPercentage> OwnerLiabilityPercentages => Set<OwnerLiabilityPercentage>();

    /// <summary>
    /// Gets the DbSet for customer loan declarations.
    /// </summary>
    public DbSet<CustomerLoanDeclaration> CustomerLoanDeclarations => Set<CustomerLoanDeclaration>();

    /// <summary>
    /// Gets the DbSet for retirement financial declarations.
    /// </summary>
    public DbSet<RetirementFinancialDeclaration> RetirementFinancialDeclarations => Set<RetirementFinancialDeclaration>();

    /// <summary>
    /// Gets the DbSet for percent owner households.
    /// </summary>
    public DbSet<HouseholdOwnershipPercentage> HouseholdOwnershipPercentages => Set<HouseholdOwnershipPercentage>();

    /// <summary>
    /// Gets the DbSet for consumer estimate details.
    /// </summary>
    public DbSet<ConsumerEstimateDetail> ConsumerEstimateDetails => Set<ConsumerEstimateDetail>();

    /// <summary>
    /// Gets the DbSet for local school details.
    /// </summary>
    public DbSet<LocalSchoolDetail> LocalSchoolDetails => Set<LocalSchoolDetail>();

    /// <summary>
    /// Gets the DbSet for property details.
    /// </summary>
    public DbSet<PropertyDetail> PropertyDetails => Set<PropertyDetail>();

    /// <summary>
    /// Gets the DbSet for property sale history details.
    /// </summary>
    public DbSet<PropertySaleHistoryDetail> PropertySaleHistoryDetails => Set<PropertySaleHistoryDetail>();

    /// <summary>
    /// Gets the DbSet for sale comparable details.
    /// </summary>
    public DbSet<SaleComparableDetail> SaleComparableDetails => Set<SaleComparableDetail>();

    /// <summary>
    /// Gets the DbSet for suburb details.
    /// </summary>
    public DbSet<SuburbDetail> SuburbDetails => Set<SuburbDetail>();

    /// <summary>
    /// Gets the DbSet for suburb valuation details.
    /// </summary>
    public DbSet<SuburbValuationDetail> SuburbValuationDetails => Set<SuburbValuationDetail>();

    /// <summary>
    /// Gets the DbSet for suburb monthly details.
    /// </summary>
    public DbSet<SuburbMonthlyDetail> SuburbMonthlyDetails => Set<SuburbMonthlyDetail>();

    /// <summary>
    /// Gets the DbSet for funds to complete must balances.
    /// </summary>
    public DbSet<FundsToCompleteMustBalance> FundsToCompleteMustBalances => Set<FundsToCompleteMustBalance>();

    /// <summary>
    /// Gets the DbSet for funds for purchase, refinance, and equity splits.
    /// </summary>
    public DbSet<FundsForPurchaseRefinanceEquitySplit> FundsForPurchaseRefinanceEquitySplits => Set<FundsForPurchaseRefinanceEquitySplit>();

    /// <summary>
    /// Gets the DbSet for Australian business number details.
    /// </summary>
    public DbSet<AustralianBusinessNumberDetail> AustralianBusinessNumberDetails => Set<AustralianBusinessNumberDetail>();

    /// <summary>
    /// Gets the DbSet for company addresses.
    /// </summary>
    public DbSet<CompanyAddress> CompanyAddresses => Set<CompanyAddress>();

    /// <summary>
    /// Gets the DbSet for company beneficial ownerships.
    /// </summary>
    public DbSet<CompanyBeneficialOwnership> CompanyBeneficialOwnerships => Set<CompanyBeneficialOwnership>();

    /// <summary>
    /// Gets the DbSet for company business proprietorships.
    /// </summary>
    public DbSet<CompanyBusinessProprietorship> CompanyBusinessProprietorships => Set<CompanyBusinessProprietorship>();

    /// <summary>
    /// Gets the DbSet for company credit enquiries.
    /// </summary>
    public DbSet<CompanyCreditEnquiry> CompanyCreditEnquiries => Set<CompanyCreditEnquiry>();

    /// <summary>
    /// Gets the DbSet for company current secretaries.
    /// </summary>
    public DbSet<CompanyCurrentSecretary> CompanyCurrentSecretaries => Set<CompanyCurrentSecretary>();

    /// <summary>
    /// Gets the DbSet for company current shareholders.
    /// </summary>
    public DbSet<CompanyCurrentShareholder> CompanyCurrentShareholders => Set<CompanyCurrentShareholder>();

    /// <summary>
    /// Gets the DbSet for company directors.
    /// </summary>
    public DbSet<CompanyDirector> CompanyDirectors => Set<CompanyDirector>();

    //public DbSet<CompanyDocumentListing> CompanyDocumentListings => Set<CompanyDocumentListing>();

    /// <summary>
    /// Gets the DbSet for company identities.
    /// </summary>
    public DbSet<CompanyIdentity> CompanyIdentities => Set<CompanyIdentity>();

    /// <summary>
    /// Gets the DbSet for company summaries.
    /// </summary>
    public DbSet<CompanySummary> CompanySummaries => Set<CompanySummary>();

    //public DbSet<CreditHistorySnapshot> CreditHistorySnapshots => Set<CreditHistorySnapshot>();

    //public DbSet<FileMessage> FileMessages => Set<FileMessage>();

    /// <summary>
    /// Gets the DbSet for public record information.
    /// </summary>
    public DbSet<PublicRecordInformation> PublicRecordInformation => Set<PublicRecordInformation>();

    //public DbSet<TradePayment> TradePayments => Set<TradePayment>();

    /// <summary>
    /// Gets the DbSet for customer retirement strategies.
    /// </summary>
    public DbSet<CustomerRetirementStrategy> CustomerRetirementStrategies => Set<CustomerRetirementStrategy>();

    //public DbSet<FamilyRelation> FamilyRelations => Set<FamilyRelation>();

    /// <summary>
    /// Gets the DbSet for employer details.
    /// </summary>
    public DbSet<EmployerDetail> EmployerDetails => Set<EmployerDetail>();

    /// <summary>
    /// Gets the DbSet for driver licenses.
    /// </summary>
    public DbSet<DriverLicense> DriverLicenses => Set<DriverLicense>();

    /// <summary>
    /// Gets the DbSet for circumstances for responsible lending.
    /// </summary>
    public DbSet<CircumstancesForResponsibleLending> CircumstancesForResponsibleLending => Set<CircumstancesForResponsibleLending>();

    //public DbSet<LoanApplicationWithdrawnStatus> LoanApplicationWithdrawnStatuses => Set<LoanApplicationWithdrawnStatus>();

    /// <summary>
    /// Gets the DbSet for loan application stages.
    /// </summary>
    public DbSet<LoanApplicationStage> LoanApplicationStages => Set<LoanApplicationStage>();

    /// <summary>
    /// Gets the DbSet for percent owner mortgages.
    /// </summary>
    public DbSet<MortgageOwnershipPercentage> MortgageOwnershipPercentages => Set<MortgageOwnershipPercentage>();

    /// <summary>
    /// Gets the DbSet for activity logs.
    /// </summary>
    public DbSet<ActivityLog> ActivityLogs => Set<ActivityLog>();

    /// <summary>
    /// Gets the DbSet for user sign-in logs.
    /// </summary>
    public DbSet<UserSignInLog> UserSignInLogs => Set<UserSignInLog>();

    /// <summary>
    /// Gets the DbSet for user modules.
    /// </summary>
    public DbSet<Bidirectional.DomainCore.BidOnboard.Entities.Modules.UserModule> UserModules => Set<Bidirectional.DomainCore.BidOnboard.Entities.Modules.UserModule>();

    /// <summary>
    /// Gets the DbSet for employment status details.
    /// </summary>
    public DbSet<EmploymentStatusDetail> EmploymentIncomeDetails => Set<EmploymentStatusDetail>();

    //public DbSet<Employee> Employees => Set<Employee>();

    /// <summary>
    /// Gets the DbSet for API exception logs.
    /// </summary>
    public DbSet<ApiExceptionLog> ApiExceptionLogs => Set<ApiExceptionLog>();

    /// <summary>
    /// Gets the DbSet for financial considerations.
    /// </summary>
    public DbSet<FinancialConsideration> FinancialConsiderations => Set<FinancialConsideration>();

    /// <summary>
    /// Gets the DbSet for notifications.
    /// </summary>
    public DbSet<Notification> Notifications => Set<Notification>();

    /// <summary>
    /// Gets the DbSet for rule-based notification event catalogue entries.
    /// </summary>
    public DbSet<NotificationEvent> RuleNotificationEvents => Set<NotificationEvent>();

    /// <summary>
    /// Gets the DbSet for rule-based notification configurations.
    /// </summary>
    public DbSet<NotificationConfiguration> RuleNotificationConfigurations => Set<NotificationConfiguration>();

    /// <summary>
    /// Gets the DbSet for rule-based notification recipient rows.
    /// </summary>
    public DbSet<NotificationRecipient> RuleNotificationRecipients => Set<NotificationRecipient>();

    /// <summary>
    /// Gets the DbSet for rule-based notification templates.
    /// </summary>
    public DbSet<NotificationTemplate> RuleNotificationTemplates => Set<NotificationTemplate>();

    /// <summary>
    /// Gets the DbSet for rule-based per-user in-app notifications.
    /// </summary>
    public DbSet<UserNotification> RuleEngineUserNotifications => Set<UserNotification>();

    /// <summary>
    /// Gets the DbSet for business units.
    /// </summary>
    public DbSet<BusinessUnit> BusinessUnits => Set<BusinessUnit>();

    /// <summary>
    /// Gets the DbSet for module scopes.
    /// </summary>
    public DbSet<ModuleScope> ModuleScopes => Set<ModuleScope>();

    /// <summary>
    /// Gets the DbSet for entity access policies.
    /// </summary>
    public DbSet<EntityAccessPolicy> EntityAccessPolicies => Set<EntityAccessPolicy>();

    /// <summary>
    /// Gets the DbSet for entity access policy group mappers.
    /// </summary>
    public DbSet<EntityAccessPolicyGroupMapper> EntityAccessPolicyGroupMapper => Set<EntityAccessPolicyGroupMapper>();

    /// <summary>
    /// Gets the DbSet for default entity access policies.
    /// </summary>
    public DbSet<DefaultEntityAccessPolicy> DefaultEntityAccessPolicies => Set<DefaultEntityAccessPolicy>();

    public DbSet<OrganizationBusinessUnitGroupMapper> OrganizationBusinessUnitGroupMappers => Set<OrganizationBusinessUnitGroupMapper>();

    public DbSet<OrganizationBusinessUnitGroupUserMapper> OrganizationBusinessUnitGroupUserMappers => Set<OrganizationBusinessUnitGroupUserMapper>();

    /// <summary>
    /// Gets the DbSet for leads.
    /// </summary>
    public DbSet<Lead> Leads => Set<Lead>();

    /// <summary>
    /// Gets the DbSet for loan application assignments.
    /// </summary>
    public DbSet<LoanApplicationAssignment> LoanApplicationAssignments => Set<LoanApplicationAssignment>();

    /// <summary>
    /// Gets the DbSet for loan application user open events.
    /// </summary>
    public DbSet<LoanApplicationUserOpen> LoanApplicationUserOpens => Set<LoanApplicationUserOpen>();

    /// <summary>
    /// Gets the DbSet for user groups.
    /// </summary>
    public DbSet<UserGroup> UserGroups => Set<UserGroup>();

    /// <summary>
    /// Gets the DbSet for loan application histories.
    /// </summary>
    public DbSet<LoanApplicationHistory> LoanApplicationHistories => Set<LoanApplicationHistory>();

    /// <summary>
    /// Gets the DbSet for loan application hierarchy types.
    /// </summary>
    public DbSet<LoanApplicationHierarchyType> LoanApplicationHierarchyTypes => Set<LoanApplicationHierarchyType>();

    /// <summary>
    /// Gets the DbSet for loan application hierarchy levels.
    /// </summary>
    public DbSet<LoanApplicationHierarchyLevel> LoanApplicationHierarchyLevels => Set<LoanApplicationHierarchyLevel>();

    /// <summary>
    /// Gets the DbSet for email notification hierarchy level mappers.
    /// </summary>
    public DbSet<EmailNotificationHierarchyLevelMapper> EmailNotificationHierarchyLevelMappers => Set<EmailNotificationHierarchyLevelMapper>();

    /// <summary>
    /// Gets the DbSet for loan application approver workflows.
    /// </summary>
    public DbSet<LoanApplicationApproverWorkflow> LoanApplicationApproverWorkflows => Set<LoanApplicationApproverWorkflow>();

    /// <summary>
    /// Gets the DbSet for loan application approver stage mappers.
    /// </summary>
    public DbSet<LoanApplicationApproverStageMapper> LoanApplicationApproverStageMappers => Set<LoanApplicationApproverStageMapper>();

    /// <summary>
    /// Gets the DbSet for encumbered assets.
    /// </summary>
    public DbSet<EncumberedAsset> EncumberedAssets => Set<EncumberedAsset>();

    /// <summary>
    /// Gets the DbSet for email details.
    /// </summary>
    public DbSet<EmailDetail> EmailDetails => Set<EmailDetail>();

    /// <summary>
    /// Gets the DbSet for core product settings.
    /// </summary>
    public DbSet<CoreProductSetting> CoreProductSettings => Set<CoreProductSetting>();

    /// <summary>
    /// Gets the DbSet for assigned products.
    /// </summary>
    public DbSet<AssignedProduct> AssignedProducts => Set<AssignedProduct>();

    /// <summary>
    /// Gets the DbSet for data sync message logs.
    /// </summary>
    public DbSet<DataSyncMessageLog> DataSyncMessageLogs => Set<DataSyncMessageLog>();

    /// <summary>
    /// Gets the DbSet for loan splits.
    /// </summary>
    public DbSet<LoanSplit> LoanSplits => Set<LoanSplit>();

    /// <summary>
    /// Gets the DbSet for loan purpose details.
    /// </summary>
    public DbSet<LoanPurposeDetail> LoanPurposeDetails => Set<LoanPurposeDetail>();

    /// <summary>
    /// Gets the DbSet for applied discount details.
    /// </summary>
    public DbSet<AppliedDiscountDetail> AppliedDiscountDetails => Set<AppliedDiscountDetail>();

    /// <summary>
    /// Gets the DbSet for borrower rates.
    /// </summary>
    public DbSet<BorrowerRate> BorrowerRates => Set<BorrowerRate>();

    /// <summary>
    /// Gets the DbSet for borrower rate fees.
    /// </summary>
    public DbSet<BorrowerRateFee> BorrowerRateFees => Set<BorrowerRateFee>();

    /// <summary>
    /// Gets the DbSet for calculated fees.
    /// </summary>
    public DbSet<CalculatedFee> CalculatedFees => Set<CalculatedFee>();

    /// <summary>
    /// Gets the DbSet for comparison rate fees.
    /// </summary>
    public DbSet<ComparisonRateFee> ComparisonRateFees => Set<ComparisonRateFee>();

    /// <summary>
    /// Gets the DbSet for fee reductions.
    /// </summary>
    public DbSet<FeeReduction> FeeReductions => Set<FeeReduction>();

    /// <summary>
    /// Gets the DbSet for interest rates.
    /// </summary>
    public DbSet<InterestRate> InterestRates => Set<InterestRate>();

    /// <summary>
    /// Gets the DbSet for loan application fees.
    /// </summary>
    public DbSet<LoanApplicationFee> LoanApplicationFees => Set<LoanApplicationFee>();

    /// <summary>
    /// Gets the DbSet for loan application fee audits.
    /// </summary>
    public DbSet<LoanApplicationFeeAudit> LoanApplicationFeeAudits => Set<LoanApplicationFeeAudit>();

    /// <summary>
    /// Gets the DbSet for approval requests.
    /// </summary>
    public DbSet<ApprovalRequest> ApprovalRequests => Set<ApprovalRequest>();

    /// <summary>
    /// Gets the DbSet for directors.
    /// </summary>
    public DbSet<Director> Directors => Set<Director>();

    /// <summary>
    /// Gets the DbSet for purchases.
    /// </summary>
    public DbSet<Purchase> Purchases => Set<Purchase>();

    /// <summary>
    /// Gets the DbSet for relocations.
    /// </summary>
    public DbSet<Relocation> Relocations => Set<Relocation>();

    /// <summary>
    /// Gets the collection of exam template entities representing the structure of assessment templates.
    /// </summary>
    public DbSet<ExamTemplate> ExamTemplates => Set<ExamTemplate>();

    /// <summary>
    /// Gets the collection of exam template assignment entities representing assignments of exam templates to users.
    /// </summary>
    public DbSet<ExamTemplateAssignment> ExamTemplateAssignments => Set<ExamTemplateAssignment>();

    /// <summary>
    /// Gets the collection of section template entities representing template definitions for different exam sections.
    /// </summary>
    public DbSet<SectionTemplate> SectionTemplates => Set<SectionTemplate>();

    /// <summary>
    /// Gets the collection of question template entities containing template information for exam questions.
    /// </summary>
    public DbSet<QuestionTemplate> QuestionTemplates => Set<QuestionTemplate>();

    /// <summary>
    /// Gets the collection of option template entities representing possible options for exam questions.
    /// </summary>
    public DbSet<OptionTemplate> OptionTemplates => Set<OptionTemplate>();

    /// <summary>
    /// Gets the collection of exam attempt entities representing user attempts on assigned exams.
    /// </summary>
    public DbSet<ExamAttempt> ExamAttempts => Set<ExamAttempt>();

    /// <summary>
    /// Gets the collection of attempt section entities representing individual sections within an exam attempt.
    /// </summary>
    public DbSet<AttemptSection> AttemptSections => Set<AttemptSection>();

    /// <summary>
    /// Gets the collection of attempt question entities representing specific questions within an exam attempt.
    /// </summary>
    public DbSet<AttemptQuestion> AttemptQuestions => Set<AttemptQuestion>();

    /// <summary>
    /// Gets the collection of attempt option entities representing chosen options for attempted questions.
    /// </summary>
    public DbSet<AttemptOption> AttemptOptions => Set<AttemptOption>();

    /// <summary>
    /// Gets the collection of attempt answer entities storing the answers submitted for exam questions.
    /// </summary>
    public DbSet<AttemptAnswer> AttemptAnswers => Set<AttemptAnswer>();

    /// <summary>
    /// Gets the collection of repayment history entities for tracking repayments.
    /// </summary>
    public DbSet<RepaymentHistory> RepaymentHistories => Set<RepaymentHistory>();

    public DbSet<DefaultSetting> DefaultSettings => Set<DefaultSetting>();

    /// <summary>
    /// Gets the collection of business identifier entities used for business or organizational identification within assessments.
    /// </summary>
    public DbSet<BusinessIdentifier> BusinessIdentifiers => Set<BusinessIdentifier>();

    /// <summary>
    /// Gets the collection of business identifier entities used for business or organizational identification within assessments.
    /// </summary>
    public DbSet<FamilyRelation> FamilyRelations => Set<FamilyRelation>();

    /// <summary>
    /// Gets the collection of business identifier entities used for business or organizational identification within assessments.
    /// </summary>
    public DbSet<ApplicantRelationshipDetail> ApplicantRelationshipDetails => Set<ApplicantRelationshipDetail>();

    /// <summary>
    /// Gets the collection of responsibility percentage entities representing the percentage responsibility associated with a loan application's other commitments or other income, and the related owners.
    /// </summary>
    public DbSet<ResponsibilityPercentage> ResponsibilityPercentages => Set<ResponsibilityPercentage>();

    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

    public DbSet<Bidirectional.DomainCore.BidOnboard.Entities.Generals.Countries.Postcode> Postcodes => Set<Bidirectional.DomainCore.BidOnboard.Entities.Generals.Countries.Postcode>();

    #endregion

    #region Methods

    /// <summary>
    /// Retrieves the table name for the given entity type.
    /// </summary>
    /// <param name="entityType">The entity's .NET type to get the table name for.</param>
    /// <returns>The name of the table associated with the specified entity type.</returns>
    public string GetTableName(Type entityType)
    {
        return Model.FindEntityType(entityType)?.GetTableName() ?? entityType.Name;
    }

    /// <summary>
    /// Retrieves all temporal records for the specified entity type.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <returns>An <see cref="IQueryable{T}"/> representing all records including temporal data.</returns>
    public IQueryable<TEntity> GetTemporalAll<TEntity>() where TEntity : class
    {
        return Set<TEntity>().TemporalAll();
    }

    public IQueryable<TEntity> GetTemporalAsOf<TEntity>(DateTime pointInTime) where TEntity : class
    {
        return Set<TEntity>().TemporalAsOf(pointInTime);
    }

    public IQueryable<TEntity> GetTemporalBetween<TEntity>(DateTime from, DateTime to) where TEntity : class
    {
        return Set<TEntity>().TemporalBetween(from, to);
    }

    /// <summary>
    /// Retrieves approved request base data mapped to the appropriate DTO using the provided unique ID.
    /// </summary>
    /// <param name="uniqueID">The unique identifier for the approval request.</param>
    /// <returns>An object representing the mapped DTO with base data request information.</returns>
    public async Task<object> GetApprovedRequestBaseData(string uniqueID)
    {
        List<ApprovalRequest> approvalRequests = await ApprovalRequests
                                        .AsNoTracking()
                                        .Where(x => (x.ApprovalStatus == ApprovalStatus.Pending) && (x.UniqueID == uniqueID))
                                        .ToListAsync();

        ApprovalRequest approvalRequest = approvalRequests.FirstOrDefault(x => x.UniqueID == uniqueID)
            ?? throw new KeyNotFoundException($"Approval request not found for UniqueID: {uniqueID}");

        List<BaseDataRequestDto> approvalRequestsDto = _mapper.Map<List<BaseDataRequestDto>>(approvalRequests);

        string tableName = approvalRequest.TableName ?? string.Empty;

        PropertyInfo dbSetProperty = typeof(PlatformDbContext)
        .GetProperties()
        .FirstOrDefault(p =>
            p.PropertyType.IsGenericType &&
            p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>) &&
            p.Name.Equals(tableName, StringComparison.OrdinalIgnoreCase))
        ?? throw new Exception($"Table not found in DbContext: {tableName}");

        Type entityType = dbSetProperty.PropertyType.GetGenericArguments()[0];
        IQueryable? dbSet = dbSetProperty.GetValue(this) as IQueryable;

        if (dbSet == null)
            throw new Exception($"DbSet not found for table: {tableName}");

        // 2. Build Where(x => x.UniqueID == approvalRequest.RecordUniqueID)
        ParameterExpression parameter = Expression.Parameter(entityType, "x");
        LambdaExpression predicate = Expression.Lambda(
            Expression.Equal(
                Expression.PropertyOrField(parameter, "UniqueID"),
                Expression.Constant(approvalRequest.RecordUniqueID)
            ),
            parameter
        );

        MethodInfo whereMethod = typeof(Queryable)
            .GetMethods()
            .First(m => m.Name == "Where" && m.GetParameters().Length == 2)
            .MakeGenericMethod(entityType);

        object? whereCall = whereMethod.Invoke(null, new object[] { dbSet, predicate });

        // 3. Execute ToListAsync
        MethodInfo firstOrDefaultMethod = typeof(EntityFrameworkQueryableExtensions)
            .GetMethods()
            .First(m => m.Name == "FirstOrDefaultAsync" && m.GetParameters().Length == 2)
            .MakeGenericMethod(entityType);

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment.
        Task? task = (Task)firstOrDefaultMethod.Invoke(null, new object[] { whereCall, CancellationToken.None });
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        await task.ConfigureAwait(false);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        object? singleResult = task.GetType().GetProperty("Result")!.GetValue(task);

        // 4. Map result to DTOs
        object? entityList = singleResult;

        // =??? Define tableName -> DTO Type mapping
        Dictionary<string, Type> tableToDtoMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            { "CoreProductSettings", typeof(ProductResponseDto) },
        };

        if (entityList is null)
            throw new Exception($"No data found for table: {tableName}");

        if (!tableToDtoMap.TryGetValue(tableName, out Type? dtoType))
            throw new Exception($"No DTO mapping found for table: {tableName}");

        object mappedDto = _mapper.Map(singleResult, singleResult?.GetType(), dtoType);

        //await GetAdditionalFieldValue(tableName, singleResult, mappedDto);

        PropertyInfo propertyInfo = (mappedDto?.GetType().GetProperty("BaseDataRequestDto")) ?? throw new Exception("Property 'BaseDataRequestDto' not found on DTO");

        propertyInfo.SetValue(mappedDto, approvalRequestsDto);

        return mappedDto ?? new();
    }

    /// <summary>
    /// Updates approved table data for the specified entity type using a list of approval requests.
    /// </summary>
    /// <typeparam name="T">The entity type to be updated.</typeparam>
    /// <param name="approvalRequest">List of <see cref="ApprovalRequest"/> objects with update information.</param>
    /// <returns>A <see cref="Result"/> indicating the outcome of the update operation.</returns>
    public async Task<Result> UpdateApprovedTableData<T>(List<ApprovalRequest> approvalRequest) where T : class
    {
        List<string?> recordIds = approvalRequest
            .Select(x => x.RecordUniqueID)
            .Distinct()
            .ToList();

        DbSet<T> dbSet = base.Set<T>();

        List<T> entities = await dbSet.Where(x => x != null &&
                                              EF.Property<string>(x, "UniqueID") != null &&
                                              recordIds.Contains(EF.Property<string>(x, "UniqueID")))
                                  .ToListAsync();

        foreach (ApprovalRequest request in approvalRequest)
        {
            string? tableName = request.TableName;
            string? recordId = request.RecordUniqueID;
            string? fieldName = request.FieldName;

            IEntityType entityType = base.Model.GetEntityTypes()
                   .FirstOrDefault(e => e.GetTableName() == tableName) ?? throw new Exception($"Table {tableName} not found.");

            Type clrType = entityType.ClrType;

            T entity = entities.FirstOrDefault(x => x != null &&
                                 (x.GetType().GetProperty("UniqueID")?.GetValue(x) as string) == recordId)
                                    ?? throw new Exception($"Record {recordId} not found in {tableName}.");

            PropertyInfo property = clrType.GetProperty(fieldName ?? string.Empty)
                ?? throw new Exception($"Column {fieldName} not found in {tableName}.");

            Type targetType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

            if ((request.ApprovalStatus == ApprovalStatus.Approved || request.ApprovalStatus == ApprovalStatus.RolledBack) && request.NewValue != null)
            {
                string newValue = request.NewValue;

                object convertedValue = Convert.ChangeType(newValue, targetType);

                property.SetValue(entity, convertedValue);
            }
        }

        await base.SaveChangesAsync();

        return Result.Success();
    }

    /// <summary>
    /// Loads a related collection navigation property for a given entity.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    /// <typeparam name="TProperty">The collection property type.</typeparam>
    /// <param name="entity">The entity whose collection navigation should be loaded.</param>
    /// <param name="navigation">An expression specifying the navigation property.</param>
    /// <returns>A task that represents the asynchronous load operation.</returns>
    public async Task LoadCollectionAsync<TEntity, TProperty>(
       TEntity entity,
       Expression<Func<TEntity, IEnumerable<TProperty>>> navigation)
       where TEntity : class
       where TProperty : class
    {
        await Entry(entity).Collection(navigation).LoadAsync();
    }

    /// <summary>
    /// Retrieves the current user's business unit hierarchy as a list of DTOs.
    /// </summary>
    /// <param name="userID">The ID of the user.</param>
    /// <returns>A list of <see cref="UserBasedHierarchyDto"/> representing the hierarchy for the user.</returns>
    public async Task<List<UserBasedHierarchyDto>> GetCurrentUserBasedHierarchy(int userID)
    {
        List<UserBasedHierarchyDto> result = await Database.SqlQuery<UserBasedHierarchyDto>(HierarchyQueries.BuildUserBasedBusinessUnitHierarchyQuery(userID)).ToListAsync();
        return result;
    }

    /// <summary>
    /// Retrieves the lender ID associated with the specified user ID.
    /// </summary>
    /// <param name="userID">The ID of the user.</param>
    /// <returns>The lender ID related to the user.</returns>
    public virtual async Task<int> GetCurrentUserLenderID(int userID)
    {
        int result = await Database.SqlQuery<int>(HierarchyQueries.GetLenderIDWithUserIDQuery(userID)).FirstOrDefaultAsync();
        return result;
    }

    /// <summary>
    /// Configures the entity model, including encryption, temporal tables, string conventions, and entity-specific setups.
    /// </summary>
    /// <param name="builder">The <see cref="ModelBuilder"/> used to configure the model for the context.</param>
    protected async override void OnModelCreating(ModelBuilder builder)
    {
        EncryptionBuilder(builder);

        builder.ApplyTemporalTableConfiguration();

        BidRelationshipConfiguration.Configure(builder);

        builder.Entity<Organization>()
    .HasEnumStringConversion(b => b.OrganizationType);

        builder.Entity<BusinessUnit>()
            .HasEnumStringConversion(b => b.BusinessType);

        builder.Entity<LoanApplicationApproverWorkflow>()
            .HasEnumStringConversion(b => b.ApproverEntityType);

        builder.Entity<LoanApplicationHierarchyLevel>()
            .HasEnumStringConversion(b => b.EntityType);

        builder.Entity<LoanApplicationStage>()
            .HasEnumStringConversion(b => b.StageName);

        builder.Entity<LoanApplicationStage>()
            .HasEnumStringConversion(b => b.LoanApplicationStatus);

        builder.Entity<MotorVehicle>()
            .HasEnumStringConversion(b => b.AssetSecurityStatus);

        builder.Entity<MotorVehicle>()
            .HasEnumStringConversion(b => b.AssetOrigin);

        builder.Entity<MotorVehicle>()
            .HasEnumStringConversion(b => b.RefinancingStatus);

        builder.Entity<RealEstateAsset>()
            .HasEnumStringConversion(b => b.PropertyStatus);

        builder.Entity<RealEstateAsset>()
            .HasEnumStringConversion(b => b.AssetOrigin);

        builder.Entity<RealEstateAsset>()
            .HasEnumStringConversion(b => b.RefinancingStatus);

        builder.Entity<OtherAsset>()
            .HasEnumStringConversion(b => b.AssetSecurityStatus);

        builder.Entity<OtherAsset>()
            .HasEnumStringConversion(b => b.AssetOrigin);

        builder.Entity<OtherAsset>()
            .HasEnumStringConversion(b => b.RefinancingStatus);

        builder.Entity<LoanApplication>()
            .HasEnumStringConversion(b => b.ProcessStage);

        builder.Entity<ExamTemplate>()
            .HasEnumStringConversion(b => b.Type);

        builder.Entity<SectionTemplate>()
            .HasEnumStringConversion(b => b.Type);

        builder.Entity<ExamAttempt>()
            .HasEnumStringConversion(b => b.Status);

        builder.Entity<AttemptSection>()
            .HasEnumStringConversion(b => b.Type);

        builder.Entity<CardDetail>()
            .HasEnumStringConversion(b => b.RefinancingStatus);

        builder.Entity<CardDetail>()
            .HasOne(card => card.CardDetail_CompanyApplicant)
            .WithMany()
            .HasForeignKey(card => card.CardDetail_CompanyApplicantID);

        builder.Entity<CardDetail>()
            .HasOne(card => card.CardDetail_Trust)
            .WithMany()
            .HasForeignKey(card => card.CardDetail_TrustID);

        builder.Entity<NonRealEstateAssetOwnershipPercentage>()
            .HasOne(x => x.NonRealEstateAssetOwnershipPercentage_Trust)
            .WithMany()
            .HasForeignKey(x => x.NonRealEstateAssetOwnershipPercentage_TrustID);

        builder.Entity<ApplicantRelationshipDetail>()
            .HasOne(x => x.ApplicantRelationshipDetail_Applicant)
            .WithOne(x => x.ApplicantRelationshipDetail)
            .HasForeignKey<ApplicantRelationshipDetail>(x => x.ApplicantRelationshipDetail_ApplicantID);

        builder.Entity<ApplicantRelationshipDetail>()
            .HasOne(x => x.RelatedToApplicant)
            .WithMany()
            .HasForeignKey(x => x.RelatedToApplicantID);

        builder.Entity<LoansOtherThanMortgage>()
            .HasEnumStringConversion(b => b.RefinancingStatus);

        builder.Entity<PrivacyPolicy>()
            .HasEnumStringConversion(b => b.TargetEntityType);

        builder.Entity<LoanApplicationFee>()
          .HasEnumStringConversion(b => b.Status);

        OnboardingRelationshipConfiguration.Configure(builder);

        builder.Entity<OnboardingEntityWorkflow>()
               .HasEnumStringConversion(b => b.Entity);

        builder.Entity<OnboardingEntityWorkflow>()
               .HasEnumStringConversion(b => b.ParentEntity);

        builder.Entity<OnboardingWorkflowStep>()
               .HasEnumStringConversion(b => b.EntityType);

        builder.Entity<Organization>()
               .HasEnumStringConversion(b => b.OrganizationType);

        builder.Entity<BusinessUnit>()
               .HasEnumStringConversion(b => b.BusinessType);

        builder.Entity<PrivacyPolicy>()
               .HasEnumStringConversion(b => b.TargetEntityType);

        builder.Entity<PrivacyPolicyEntityTypeGroupMapper>()
               .HasEnumStringConversion(b => b.TargetEntityType);

        builder.Entity<PrivacyPolicyEntityTypeGroupMapper>()
               .HasEnumStringConversion(b => b.PolicySourceType);

        builder.Entity<UserRepresentativeReference>()
               .HasEnumStringConversion(b => b.ReferenceStatus);

        builder.Entity<DefaultGroup>()
               .HasEnumStringConversion(b => b.EntityType);

        builder.Entity<AcceptedAgreementDetail>()
               .HasEnumStringConversion(b => b.TargetEntityType);

        builder.Entity<OnboardingWorkflowStep>()
          .Property(b => b.EnrollmentType)
          .HasMaxLength(50)
          .HasConversion<string>();

        builder.Entity<OnboardingNotificationSetting>()
               .HasEnumStringConversion(b => b.NotificationSetting);

        builder.Entity<EntityUserGroupMapping>()
               .HasEnumStringConversion(b => b.DomainEntityType);

        builder.Entity<EntityUserGroupMapping>()
               .HasEnumStringConversion(b => b.TargetEntityType);


        // To auto-generate LoanAccountNumber like identity (seed 710000001, increment 1)
        builder.HasSequence<long>(nameof(LoanApplication.LoanAccountNumber))
            .StartsAt(710000001L)
            .IncrementsBy(1);

        builder.Entity<LoanApplication>()
            .Property(x => x.LoanAccountNumber)
            .HasDefaultValueSql($"NEXT VALUE FOR {nameof(LoanApplication.LoanAccountNumber)}")
            .ValueGeneratedOnAdd();

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        CascadeDeleteHelper.OnModelCreating(builder);

        EntitySchemaConvention.Apply(builder);

        ModelBuilderStringConvention.ApplyStringPolicies(builder);

        ModelBuilderStringConvention.ValidateNoNVarCharMax(builder);

        base.OnModelCreating(builder);
    }

    /// <summary>
    /// Returns the <see cref="EntityEntry{TEntity}"/> for the given entity.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    /// <param name="entity">The entity instance.</param>
    /// <returns>The <see cref="EntityEntry{TEntity}"/> for the specified entity.</returns>
    public new EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class => base.Entry(entity);

    /// <summary>
    /// Configures the context, including interceptors for auditing.
    /// </summary>
    /// <param name="optionsBuilder">A builder for configuring context options.</param>
    /// <summary>
    /// Gets all string properties for the specified entity entry, with caching for performance.
    /// </summary>
    /// <param name="entry">The entity entry to inspect.</param>
    /// <returns>An array of string property metadata.</returns>
    private static IProperty[] GetStringProperties(EntityEntry entry)
    {
        return StringPropsCache.GetOrAdd(
            entry.Metadata,
            m => m.GetProperties()
                  .Where(p => p.ClrType == typeof(string) && p.PropertyInfo != null)
                  .ToArray());
    }

    /// <summary>
    /// Validates text policy compliance for string properties and logs possible violations.
    /// </summary>
    /// <param name="entries">A collection of entity entries to check.</param>
    protected virtual void DisplayStates(IEnumerable<EntityEntry> entries)
    {
        foreach (EntityEntry entry in entries)
        {
            if (entry.State != EntityState.Added &&
                entry.State != EntityState.Modified)
                continue;

            IProperty[] stringProps = GetStringProperties(entry);

            foreach (IProperty p in stringProps)
            {
                PropertyEntry prop = entry.Property(p.Name);

                if (prop.CurrentValue is not string value || value.Length == 0)
                    continue;

                try
                {
                    (bool isValid, TextFieldClass testClass, TextPolicy policy, TextPolicyViolation? violation) policy = _textPolicyService.IsValid(p.PropertyInfo!, p.Name, value);

                    if (!policy.isValid)
                        throw new Exception(TextPolicyErrorFormatter.Build(entry.Metadata.Name, policy.testClass, policy.violation!.Value, policy.policy));
                }
                catch (Exception ex)
                {
                    _logger.LogInformation("[BYPASS] EF_INTERCEPTOR: {Message} Property={PropertyName}", ex.Message, p.Name);
                    //throw;
                }
            }
        }
    }

    /// <summary>
    /// Persists all changes to the database, running text policy validation and audit logic. 
    /// </summary>
    /// <param name="cancellationToken">A cancellation token for the async operation.</param>
    /// <returns>The number of affected state entries written to the database.</returns>
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            DisplayStates(ChangeTracker.Entries());

            //var auditEntries = OnBeforeSaveChanges();

            int result = await base.SaveChangesAsync(cancellationToken);

            //await OnAfterSaveChanges(auditEntries, cancellationToken);

            //await _mediator.DispatchDomainEvents(this);

            return result;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.InnerException?.Message ?? ex.Message, ex);
        }
    }

    //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    //{
    //    DisplayStates(ChangeTracker.Entries());

    //    var auditEntries = OnBeforeSaveChanges();

    //    var result = await base.SaveChangesAsync(cancellationToken);

    //    await OnAfterSaveChanges(auditEntries, cancellationToken);

    //    await _mediator.DispatchDomainEvents(this);

    //    return result;
    //}

    #region Context overridden to save Audit log

    /// <summary>
    /// Performs logic to gather audit entries before saving changes.
    /// </summary>
    /// <returns>A list of <see cref="AuditEntry"/> objects that have temporary properties.</returns>
    private List<AuditEntry> OnBeforeSaveChanges()
    {
        // Start overall stopwatch
        Stopwatch overallStopwatch = System.Diagnostics.Stopwatch.StartNew();

        string user = _currentUserService?.UserID ?? "default";
        string? userIPAddress = _getLocalUserIPAddress.GetLocalIPAddress();

        // Detect changes - Stopwatch #1
        Stopwatch detectChangesStopwatch = System.Diagnostics.Stopwatch.StartNew();
        ChangeTracker.DetectChanges();
        detectChangesStopwatch.Stop();
        Console.WriteLine($"DetectChanges execution time: {detectChangesStopwatch.ElapsedMilliseconds} ms");

        List<AuditEntry> auditEntries = new List<AuditEntry>();

        Stopwatch loopStopwatch = System.Diagnostics.Stopwatch.StartNew();

        AddAuditLogEntry(user, userIPAddress, auditEntries);

        Stopwatch saveStopwatch = System.Diagnostics.Stopwatch.StartNew();
        foreach (AuditEntry? auditEntry in auditEntries.Where(a => !a.HasTemporaryProperties))
        {
            AuditLogs.Add(auditEntry.ToAudit());
        }
        saveStopwatch.Stop();
        Console.WriteLine($"Saving audit entries execution time: {saveStopwatch.ElapsedMilliseconds} ms");

        // Return entries with temporary properties for later processing - Stopwatch #5
        Stopwatch temporaryEntriesStopwatch = System.Diagnostics.Stopwatch.StartNew();
        List<AuditEntry> temporaryEntries = auditEntries.Where(a => a.HasTemporaryProperties).ToList();
        temporaryEntriesStopwatch.Stop();
        Console.WriteLine($"Temporary entries extraction time: {temporaryEntriesStopwatch.ElapsedMilliseconds} ms");

        // Stop overall stopwatch
        overallStopwatch.Stop();
        Console.WriteLine($"Overall execution time: {overallStopwatch.ElapsedMilliseconds} ms");

        return temporaryEntries;
    }

    /// <summary>
    /// Adds audit log entries to the provided list based on the current change tracker state.
    /// </summary>
    /// <param name="user">The user making the changes.</param>
    /// <param name="userIPAddress">The IP address of the user.</param>
    /// <param name="auditEntries">The list of audit entries to populate.</param>
    private void AddAuditLogEntry(string user, string? userIPAddress, List<AuditEntry> auditEntries)
    {
        foreach (EntityEntry entry in ChangeTracker.Entries())
        {
            if (entry.Entity is AuditLog || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                continue;

            AuditEntry auditEntry = new AuditEntry(entry)
            {
                AffectedTableName = entry.Metadata.GetTableName(),
                User = user,
                UserIPAddress = userIPAddress
            };

            auditEntries.Add(auditEntry);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new DefaultContractResolver
                {
                    IgnoreSerializableAttribute = true
                }
            };

            if (entry.State == EntityState.Added)
            {
                auditEntry.CurrentValues = JsonConvert.SerializeObject(entry.Entity, settings);
                auditEntry.Action = EntityState.Added.ToString();
            }
            else if (entry.State == EntityState.Deleted)
            {
                auditEntry.PreviousValues = JsonConvert.SerializeObject(entry.GetDatabaseValues()?.ToObject(), settings);
                auditEntry.Action = EntityState.Deleted.ToString();
            }
            else if (entry.State == EntityState.Modified)
            {
                var modifiedProperties = entry.Properties
                    .Where(p => p.IsModified && !Equals(p.OriginalValue, p.CurrentValue))
                    .Select(p => new
                    {
                        PropertyName = p.Metadata.Name,
                        OriginalValue = p.OriginalValue,
                        CurrentValue = p.CurrentValue
                    }).ToList();

                if (modifiedProperties.Any())
                {
                    auditEntry.PreviousValues = JsonConvert.SerializeObject(modifiedProperties.Select(p => new
                    {
                        p.PropertyName,
                        p.OriginalValue
                    }), settings);

                    auditEntry.CurrentValues = JsonConvert.SerializeObject(modifiedProperties.Select(p => new
                    {
                        p.PropertyName,
                        p.CurrentValue
                    }), settings);

                    auditEntry.Action = EntityState.Modified.ToString();
                }
                else
                {
                    auditEntries.Remove(auditEntry);
                }
            }

        }
    }

    /// <summary>
    /// Completes the audit log process after saving changes, including temporary property updates.
    /// </summary>
    /// <param name="auditEntries">The list of audit entries with temporary properties.</param>
    /// <param name="cancellationToken">A cancellation token used for async operations.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    private async Task OnAfterSaveChanges(List<AuditEntry> auditEntries, CancellationToken cancellationToken)
    {
        if (auditEntries is null || auditEntries.Count == 0) return;

        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        foreach (AuditEntry auditEntry in auditEntries)
        {
            // Update audit entries with temporary properties
            foreach (PropertyEntry prop in auditEntry.TemporaryProperties)
            {
                if (prop.Metadata.IsPrimaryKey())
                {
                    auditEntry.ChangedKeyValues[prop.Metadata.Name] = prop?.CurrentValue ?? "";
                }
                else
                {
                    auditEntry.CurrentValues = SerializeEntity(prop.CurrentValue!, settings);
                }
            }

            // Save the audit entry
            AuditLogs.Add(auditEntry.ToAudit());
        }

        await base.SaveChangesAsync(cancellationToken);
    }

    /// <summary>
    /// Serializes the supplied entity or property value using the provided serializer settings.
    /// </summary>
    /// <param name="entity">Object or property value to serialize.</param>
    /// <param name="settings">JSON serializer settings.</param>
    /// <returns>A string containing the serialized entity or property, or empty if value is null.</returns>
    private string SerializeEntity(object entity, JsonSerializerSettings settings)
    {
        if (entity == null) return string.Empty;

        return JsonConvert.SerializeObject(entity, settings);
    }

    /// <summary>
    /// Executes a stored procedure asynchronously and maps the result set to a strongly-typed list.
    /// </summary>
    /// <typeparam name="T">The type to map the result set to.</typeparam>
    /// <param name="procName">The stored procedure name.</param>
    /// <param name="parameters">Parameters for the procedure.</param>
    /// <returns>A list of results mapped to the type <typeparamref name="T"/>.</returns>
    public async Task<List<T>> ExecuteStoredProcAsync<T>(string procName, params SqlParameter[] parameters) where T : class
    {
        using DbCommand cmd = Database.GetDbConnection().CreateCommand();
        cmd.CommandText = procName;
        cmd.CommandType = CommandType.StoredProcedure;

        foreach (SqlParameter p in parameters)
            cmd.Parameters.Add(p);

        await Database.OpenConnectionAsync();

        using DbDataReader reader = await cmd.ExecuteReaderAsync();

        PropertyInfo[] props = typeof(T).GetProperties();
        HashSet<string> columns = Enumerable.Range(0, reader.FieldCount)
                                .Select(i => reader.GetName(i))
                                .ToHashSet(StringComparer.OrdinalIgnoreCase);

        List<T> list = new List<T>();

        while (await reader.ReadAsync())
        {
            T obj = Activator.CreateInstance<T>();

            foreach (PropertyInfo prop in props)
            {
                if (!columns.Contains(prop.Name))
                    continue;

                object val = reader[prop.Name];

                if (val == DBNull.Value)
                {
                    prop.SetValue(obj, null);
                    continue;
                }

                Type targetType = Nullable.GetUnderlyingType(prop.PropertyType)
                                 ?? prop.PropertyType;

                object safeValue = Convert.ChangeType(val, targetType);
                prop.SetValue(obj, safeValue);
            }

            list.Add(obj);
        }

        return list;
    }

    /// <summary>
    /// Executes a stored procedure that returns multiple result sets and loads them into a <see cref="DataSet"/>.
    /// </summary>
    /// <param name="storedProcedureName">The name of the stored procedure to execute.</param>
    /// <param name="parameters">The array of stored procedure parameters.</param>
    /// <returns>A <see cref="DataSet"/> containing the results from all result sets.</returns>
    public async Task<DataSet> ExecuteRawSqlWithMultipleResultsAsync(string storedProcedureName, StoredProcedureParameter[] parameters)
    {
        using (DbCommand command = Database.GetDbConnection().CreateCommand())
        {
            command.CommandText = storedProcedureName;
            command.CommandType = CommandType.StoredProcedure;

            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            for (int i = 0; i < parameters.Count(); i++)
            {
                SqlParameter parameter = new SqlParameter(parameters[i].ParameterName, SqlDbType.NVarChar) { Value = parameters[i].ParameterValue };
                sqlParameters.Add(parameter);
            }

            if (sqlParameters != null && sqlParameters.ToArray().Length > 0)
            {
                command.Parameters.AddRange(sqlParameters.ToArray());
            }

            await Database.OpenConnectionAsync();

            using (DbDataReader dataReader = await command.ExecuteReaderAsync())
            {
                DataSet dataSet = new DataSet();
                do
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataSet.Tables.Add(dataTable);
                } while (!dataReader.IsClosed);
                return dataSet;
            }
        }
    }

    /// <summary>
    /// Represents an internal audit log entry, including properties for tracking changes to entities.
    /// </summary>
    public class AuditEntry
    {
        #region  Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntry"/> class for the specified entity entry.
        /// </summary>
        /// <param name="entry">Entity entry to attach to this audit entry.</param>
        public AuditEntry(EntityEntry entry)
        {
            Entry = entry;
        }

        #endregion

        #region Fields

        /// <summary>
        /// Gets the associated <see cref="EntityEntry"/>.
        /// </summary>
        public EntityEntry Entry { get; }

        /// <summary>
        /// Gets or sets the name of the affected table.
        /// </summary>
        public string? AffectedTableName { get; set; }

        /// <summary>
        /// Gets or sets the action that was performed, such as "Added", "Deleted", or "Modified".
        /// </summary>
        public string? Action { get; set; }

        /// <summary>
        /// Gets a dictionary of changed key values for the audited entry.
        /// </summary>
        public Dictionary<string, object> ChangedKeyValues { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Gets or sets the previous values as a serialized JSON string.
        /// </summary>
        public string? PreviousValues { get; set; }

        /// <summary>
        /// Gets or sets the current values as a serialized JSON string.
        /// </summary>
        public string? CurrentValues { get; set; }

        /// <summary>
        /// Gets the list of temporary property entries for the audited entity.
        /// </summary>
        public List<PropertyEntry> TemporaryProperties { get; } = new List<PropertyEntry>();

        /// <summary>
        /// Gets or sets the user responsible for the change.
        /// </summary>
        public string? User { get; set; }

        /// <summary>
        /// Gets or sets the user's IP address.
        /// </summary>
        public string? UserIPAddress { get; set; }

        /// <summary>
        /// Gets a value indicating whether this audit entry has temporary properties.
        /// </summary>
        public bool HasTemporaryProperties => TemporaryProperties.Any();

        #endregion

        #region Methods

        /// <summary>
        /// Converts this audit entry into an <see cref="BidAuditLog"/> entity for persistence.
        /// </summary>
        /// <returns>An <see cref="AuditLog"/> populated with audit entry information.</returns>
        public AuditLog ToAudit()
        {
            AuditLog audit = new AuditLog
            {
                AffectedTableName = AffectedTableName,
                Action = Action,
                CreatedUtc = DateTime.UtcNow, //Save datetime in UTC
                UserIPAddress = UserIPAddress,
                ChangedKeyValues = JsonConvert.SerializeObject(ChangedKeyValues),
                PreviousValues = PreviousValues,
                CurrentValues = CurrentValues,
                UserID = User,
                AccessedUrl = "",
                BrowserInfo = ""
            };

            return audit;
        }

        #endregion
    }

    #endregion

    /// <summary>
    /// Applies encryption configuration and loads encryption keys from configuration and Key Vault.
    /// </summary>
    /// <param name="builder">The model builder to apply encryption configuration to.</param>
    private void EncryptionBuilder(ModelBuilder builder)
    {
        if (Database.IsInMemory())
            return;

        builder.UseEncryption();

        // EF migrations / design-time: factory uses lightweight ctor — no Key Vault; converters are still configured.
        if (EF.IsDesignTime || _azureKeyVaultService is null)
            return;

        string publicKey = _azureKeyVaultService
                .GetAsync(_configurationSection["KeyVault:DatabaseEncryption:PublicKey"] ?? string.Empty)
                .GetAwaiter().GetResult();

        string privateKey = _azureKeyVaultService
            .GetAsync(_configurationSection["KeyVault:DatabaseEncryption:PrivateKey"] ?? string.Empty)
            .GetAwaiter().GetResult();

        Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.Common.ECCIESHelper.LoadKeysFromBase64(publicKey, privateKey);
    }

    #endregion

    #endregion
}
