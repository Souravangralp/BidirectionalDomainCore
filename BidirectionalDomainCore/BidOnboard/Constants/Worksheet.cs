namespace Bidirectional.DomainCore.BidOnboard.Constants;

public record Worksheet
{
    public record GeneralLookUps
    {
        public const string GeneralLookUp = "GeneralLookUps";

        public const string GeneralLookUpCategory = "GeneralLookupCategory";
    }

    public record PermissionData
    {
        public const string Module = "Module";

        public const string Permission = "Permission";

        public const string DefaultPermission = "DefaultPermissions";

        public const string UserGroup = "UserGroup";

        public const string DefaultGroup = "DefaultGroup";
    }

    public record PrivacyPolicyStaticData
    {
        public const string PrivacyPolicyType = "PrivacyPolicyType";

        public const string PrivacyPolicyEntityTypeGroup = "PrivacyPolicyEntityTypeGroup";

        public const string PrivacyPolicy = "PrivacyPolicyBase";

        public const string PrivacyPolicyAcceptance = "PrivacyPolicyAcceptance";
    }

    public record BSBDirectoryData
    {
        public const string BSBDirectory = "BSBDirectory";
    }

    public record Workflow
    {
        public const string EmailTemplate = "EmailTemplate";

        public const string OnboardingStages = "OnboardingStage";

        public const string OnboardingNotificationSetting = "OnboardingNotificationSetting";

        public const string OnboardingEntityWorkflow = "OnboardingEntityWorkflow";

        public const string OnboardingEntityWorkflowStep = "OnboardingEntityWorkflowStep";

        public const string WorkflowAgreementAssignment = "WorkflowAgreementAssignment";

        public const string OnboardingWorkflowStep = "OnboardingWorkflowStep";
    }

    public record Agreements
    {
        public const string DefaultAgreements = "DefaultAgreement";

        public const string EntityUserGroupMapping = "EntityUserGroupMapping";

        public const string MappedEntityRequiredDocument = "MappedEntityRequiredDocument";
    }
}
