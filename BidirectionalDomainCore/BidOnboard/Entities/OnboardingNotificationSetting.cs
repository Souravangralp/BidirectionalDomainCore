using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.OrganizationBusinessUnits;
using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.Users;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class OnboardingNotificationSetting : BaseAuditableEntity
{
    public int? OnboardingNotificationSetting_UserGroupID { get; set; }

    public int? OnboardingNotificationSetting_OnboardingEntityWorkflowStepID { get; set; } // this is for entity specific steps

    public int? OnboardingNotificationSetting_OnboardingWorkflowStepID { get; set; } // this is for user workflow steps

    public int? OnboardingNotificationSetting_OnboardingStageID { get; set; } // this is for user workflow steps

    public NotificationSetting NotificationSetting { get; set; } // this is used to get the parent self and same level notification settings

    public int? OnboardingNotificationSetting_EmailTemplateID { get; set; }

    public bool ISReversionNotification { get; set; }

    public EmailTemplate? OnboardingNotificationSetting_EmailTemplate { get; set; }

    public OnboardingEntityWorkflowStep? OnboardingNotificationSetting_OnboardingEntityWorkflowStep { get; set; }

    public OnboardingWorkflowStep? OnboardingNotificationSetting_OnboardingWorkflowStep { get; set; }

    public OnboardingStage? OnboardingNotificationSetting_OnboardingStage { get; set; }

    public UserGroup? OnboardingNotificationSetting_UserGroup { get; set; }
}
