using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.OrganizationBusinessUnits;

namespace Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.Users;

public class OnboardingWorkflowStep : BaseAuditableEntity
{
    public TargetEntityTypes EntityType { get; set; } // This is the workflow that the step belongs to

    public int? OnboardingWorkflowStep_FromOnboardingStageID { get; set; }

    public int? OnboardingWorkflowStep_ToOnboardingStageID { get; set; }

    public int? OnboardingWorkflowStep_OnboardingEntityWorkflowID { get; set; }

    public int? OnboardingWorkflowStep_UserGroupID { get; set; }

    public bool ISTerminal { get; set; } // means the step is the last step in the workflow

    public string? CustomAction { get; set; } // This is the custom action that will be executed when the step is reached, like sending an email or notification save and next or user will added to bidirectional.

    public UserEnrollmentType? EnrollmentType { get; set; } // Only for users, like Onboarded or Invited

    public OnboardingStage? OnboardingWorkflowStep_FromOnboardingStage { get; set; }

    public OnboardingStage? OnboardingWorkflowStep_ToOnboardingStage { get; set; }

    public OnboardingEntityWorkflow? OnboardingWorkflowStep_OnboardingEntityWorkflow { get; set; }

    public UserGroup? OnboardingWorkflowStep_UserGroup { get; set; }
}
