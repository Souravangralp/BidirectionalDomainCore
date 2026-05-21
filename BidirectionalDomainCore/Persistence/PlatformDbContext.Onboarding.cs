using Bidirectional.DomainCore.BidOnboard.Permission;
using Bidirectional.DomainCore.BidOnboard.Application.Common.Models;
using Bidirectional.DomainCore.BidOnboard.Entities.Agreement;
using Bidirectional.DomainCore.BidOnboard.Entities.Assets;
using Bidirectional.DomainCore.BidOnboard.Entities.Chat;
using Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;
using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.OrganizationBusinessUnits;
using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.Users;
using Bidirectional.DomainCore.BidOnboard.Entities.Permissions;
using Bidirectional.DomainCore.BidOnboard.Entities.Privacy;
using Bidirectional.DomainCore.BidOnboard.Entities.ResponsibilityQuestions;
using Bidirectional.DomainCore.BidOnboard.Entities.UserRepresentative;
using Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;
using Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.Helpers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;

namespace Bidirectional.DomainCore.Persistence;

public partial class PlatformDbContext
{
    public DbSet<OnboardingNotificationSetting> OnboardingNotificationSettings => Set<OnboardingNotificationSetting>();

    public DbSet<OnboardingProcess> OnboardingProcess => Set<OnboardingProcess>();

    public DbSet<BirthCertificate> BirthCertificates => Set<BirthCertificate>();

    public DbSet<BusinessDetail> BusinessDetails => Set<BusinessDetail>();

    public DbSet<BusinessLender> BusinessLenders => Set<BusinessLender>();

    public DbSet<BusinessObjective> BusinessObjectives => Set<BusinessObjective>();

    public DbSet<DocumentDetail> DocumentDetails => Set<DocumentDetail>();

    public DbSet<EmailTemplate> EmailTemplates => Set<EmailTemplate>();

    //public DbSet<GeneralLookUpType> GeneralLookUpTypes => Set<GeneralLookUpType>();

    //public DbSet<GeneralLookUpValue> GeneralLookUpValues => Set<GeneralLookUpValue>();

    public DbSet<PhoneDetail> PhoneDetails => Set<PhoneDetail>();

    public DbSet<PreferredCommunicationDetail> PreferredCommunicationDetails => Set<PreferredCommunicationDetail>();

    public DbSet<ScheduleSlot> ScheduleSlots => Set<ScheduleSlot>();

    public DbSet<UserHierarchy> UserHierarchies => Set<UserHierarchy>();

    public DbSet<OnboardingStage> OnboardingStages => Set<OnboardingStage>();

    public DbSet<OnboardingWorkflowStep> OnboardingWorkflowSteps => Set<OnboardingWorkflowStep>();

    //public DbSet<OnboardingWorkflowStepGroup> OnboardingWorkflowStepGroups => Set<OnboardingWorkflowStepGroup>();

    public DbSet<BankAsset> BankAssets => Set<BankAsset>();

    public DbSet<FurnitureAndPersonalAsset> FurnitureAndPersonalAssets => Set<FurnitureAndPersonalAsset>();

    public DbSet<InvestmentAsset> InvestmentAssets => Set<InvestmentAsset>();

    public DbSet<MotorVehicleAsset> MotorVehicleAssets => Set<MotorVehicleAsset>();

    public DbSet<SuperannuationAsset> SuperannuationAssets => Set<SuperannuationAsset>();

    public DbSet<CreditCardLiability> CreditCardLiabilities => Set<CreditCardLiability>();

    public DbSet<HpLeaseLiability> HpLeaseLiabilities => Set<HpLeaseLiability>();

    public DbSet<MortgageLiability> MortgageLiabilities => Set<MortgageLiability>();

    public DbSet<OtherLiability> OtherLiabilities => Set<OtherLiability>();

    public DbSet<PersonalLoanLiability> PersonalLoanLiabilities => Set<PersonalLoanLiability>();

    public DbSet<IndustryExperience> IndustryExperiences => Set<IndustryExperience>();

    public DbSet<Language> Languages => Set<Language>();

    public DbSet<Referee> Referees => Set<Referee>();

    public DbSet<Accreditation> Accreditations => Set<Accreditation>();

    public DbSet<DefaultAgreement> DefaultAgreements => Set<DefaultAgreement>();

    public DbSet<OrganizationBusinessUnitAgreement> OrganizationBusinessUnitAgreements => Set<OrganizationBusinessUnitAgreement>();

    public DbSet<AgreementComment> AgreementComments => Set<AgreementComment>();

    public DbSet<PolicyAgreementAcceptanceGroup> PrivacyPolicyAcceptanceGroups => Set<PolicyAgreementAcceptanceGroup>();

    public DbSet<PrivacyPolicyAssignment> PrivacyPolicyAssignments => Set<PrivacyPolicyAssignment>();

    public DbSet<PrivacyPolicyCorrectionRequest> PrivacyPolicyCorrectionRequests => Set<PrivacyPolicyCorrectionRequest>();

    public DbSet<PrivacyPolicyAssignedUser> PrivacyPolicyAssignedUsers => Set<PrivacyPolicyAssignedUser>();

    public DbSet<PrivacyPolicyType> PrivacyPolicyTypes => Set<PrivacyPolicyType>();

    public DbSet<PrivacyPolicyEntityTypeGroupMapper> PrivacyPolicyEntityTypeGroupMapper => Set<PrivacyPolicyEntityTypeGroupMapper>();

    public DbSet<AcceptedAgreementDetail> AcceptedAgreementDetails => Set<AcceptedAgreementDetail>();

    public DbSet<ExternalUser> ExternalUsers => Set<ExternalUser>();

    public DbSet<EnvelopeUser> EnvelopeUsers => Set<EnvelopeUser>();

    public DbSet<BankDetail> BankDetails => Set<BankDetail>();

    public DbSet<CreditLicense> CreditLicenses => Set<CreditLicense>();

    public DbSet<OnboardingEntityWorkflow> OnboardingEntityWorkflows => Set<OnboardingEntityWorkflow>();

    public DbSet<OnboardingEntityWorkflowStep> OnboardingEntityWorkflowSteps => Set<OnboardingEntityWorkflowStep>();

    public DbSet<WorkflowAgreementAssignment> WorkflowAgreementAssignments => Set<WorkflowAgreementAssignment>();

    public DbSet<StaffDistribution> StaffDistributions => Set<StaffDistribution>();

    public DbSet<BusinessCostDetail> BusinessCostDetails => Set<BusinessCostDetail>();

    public DbSet<BusinessCapabilityType> BusinessCapabilityTypes => Set<BusinessCapabilityType>();

    public DbSet<BusinessCapability> BusinessCapabilities => Set<BusinessCapability>();

    public DbSet<BusinessPanelFinancialInstitution> BusinessPanelFinancialInstitutions => Set<BusinessPanelFinancialInstitution>();

    public DbSet<OrganizationAward> OrganizationAwards => Set<OrganizationAward>();

    public DbSet<BusinessPartnerDetail> BusinessPartnerDetails => Set<BusinessPartnerDetail>();

    public DbSet<OnboardingHistory> OnboardingHistories => Set<OnboardingHistory>();

    public DbSet<UserRepresentativeReference> UserRepresentativeReferences => Set<UserRepresentativeReference>();

    public DbSet<UserComplianceAuditDetail> UserComplianceAuditDetails => Set<UserComplianceAuditDetail>();

    public DbSet<BSBDirectory> BSBDirectory => Set<BSBDirectory>();

    public DbSet<DocuSignRequest> DocuSignRequests => Set<DocuSignRequest>();

    public DbSet<FormEntry> FormEntries => Set<FormEntry>();

    public DbSet<BookingBusiness> BookingBusinesses => Set<BookingBusiness>();

    public DbSet<EntityUserGroupMapping> EntityUserGroupMapping => Set<EntityUserGroupMapping>();

    public DbSet<OnboardingRequiredDocument> OnboardingRequiredDocuments => Set<OnboardingRequiredDocument>();

    public DbSet<WarehouseFacility> WarehouseFacilities => Set<WarehouseFacility>();

    public DbSet<WarehouseFundingType> WarehouseFundingTypes => Set<WarehouseFundingType>();

    public DbSet<WarehouseLoanType> WarehouseLoanTypes => Set<WarehouseLoanType>();

    public DbSet<WarehouseInterestRate> WarehouseInterestRates => Set<WarehouseInterestRate>();

    public DbSet<WarehousePropertyType> WarehousePropertyTypes => Set<WarehousePropertyType>();

    public DbSet<WarehouseGeographicCoverage> WarehouseGeographicCoverage => Set<WarehouseGeographicCoverage>();

    public DbSet<ResponsibilityQuestion> ResponsibilityQuestions => Set<ResponsibilityQuestion>();

    public DbSet<ResponsibilityQuestionUserGroupMapper> ResponsibilityQuestionUserGroupMapper => Set<ResponsibilityQuestionUserGroupMapper>();

    public DbSet<ResponsibilityQuestionAssignedUserGroupMapper> ResponsibilityQuestionAssignedUserGroupMapper => Set<ResponsibilityQuestionAssignedUserGroupMapper>();

    public DbSet<ResponsibilityQuestionUserMapper> ResponsibilityQuestionUserMapper => Set<ResponsibilityQuestionUserMapper>();

    public DbSet<AssignedQuestion> AssignedQuestions => Set<AssignedQuestion>();

    public DbSet<AreaOfExpertise> AreaOfExpertise => Set<AreaOfExpertise>();

    public DbSet<StateCovered> StateCovered => Set<StateCovered>();

    #region Permissions

    public DbSet<Permission> Permissions => Set<Permission>();

    public DbSet<Module> Modules => Set<Module>();

    public DbSet<DefaultPermission> DefaultPermissions => Set<DefaultPermission>();

    public DbSet<DefaultGroup> DefaultGroups => Set<DefaultGroup>();

    public DbSet<ModulesPermissionsMapper> ModulesPermissionsMapper => Set<ModulesPermissionsMapper>();

    #endregion

    #region Chats

    public DbSet<Conversation> Conversations => Set<Conversation>();

    public DbSet<ConversationLastSeen> ConversationLastSeens => Set<ConversationLastSeen>();

    public DbSet<ConversationMember> ConversationMembers => Set<ConversationMember>();

    public DbSet<Message> Messages => Set<Message>();

    public DbSet<MessageReadReceipt> MessageReadReceipts => Set<MessageReadReceipt>();

    #endregion

    public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken) =>
        await Database.BeginTransactionAsync(cancellationToken);

    public async Task<List<InactiveHierarchyDto>> CheckExistingOrganizationHierarchyISActive(int organizationID)
    {
        List<InactiveHierarchyDto> result = await Database.SqlQuery<InactiveHierarchyDto>(HierarchyQueries.BuildOrganizationHierarchyIsActiveQuery(organizationID))
                            .ToListAsync();

        return result;
    }

    public async Task<List<InactiveHierarchyDto>> CheckExistingBusinessUnitHierarchyISActive(int businessUnitID)
    {
        List<InactiveHierarchyDto> result = await Database.SqlQuery<InactiveHierarchyDto>(
                                HierarchyQueries.BuildBusinessUnitHierarchyIsActiveQuery(businessUnitID))
                            .ToListAsync();

        return result;
    }

    public async Task<List<GetEntityNotificationDto>> GetEntityNotificationDetailsAsync(SqlParameter[] sqlParameters)
    {
        List<GetEntityNotificationDto> result = await Database.SqlQueryRaw<GetEntityNotificationDto>(
            @"EXEC uspGetNotificationSettings 
          @OrganizationID,
          @BusinessUnitID,
          @OnboardingEntityWorkflowStepID,
          @OnboardingWorkflowStepID, 
          @UserID,
          @ISReversionNotification", sqlParameters).ToListAsync();

        return result;
    }

    public static void ConfigureTemporalTables(
        ModelBuilder modelBuilder,
        IEnumerable<Type> temporalEntities,
        string periodStart = "SysStartTime",
        string periodEnd = "SysEndTime")
    {
        foreach (Type clrType in temporalEntities)
        {
            // Ensure entity is part of model
            modelBuilder.Entity(clrType);

            IMutableEntityType entityType = modelBuilder.Model.FindEntityType(clrType)
                ?? throw new InvalidOperationException($"Entity not found: {clrType.Name}");

            string tableName = entityType.GetTableName()
                ?? throw new InvalidOperationException($"Table name not found for {clrType.Name}");

            string historyTableName = $"{tableName}History";

            modelBuilder.Entity(clrType)
                .ToTable(tableName, tableBuilder =>
                {
                    tableBuilder.IsTemporal(t =>
                    {
                        t.HasPeriodStart(periodStart);
                        t.HasPeriodEnd(periodEnd);
                        t.UseHistoryTable(historyTableName);
                    });
                });
        }
    }

}
