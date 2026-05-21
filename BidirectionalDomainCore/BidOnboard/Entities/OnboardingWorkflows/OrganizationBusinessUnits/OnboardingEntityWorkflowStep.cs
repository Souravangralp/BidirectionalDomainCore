namespace Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.OrganizationBusinessUnits;

public class OnboardingEntityWorkflowStep : BaseAuditableEntity
{
    public int? OnboardingEntityWorkflowStep_OnboardingWorkflowID { get; set; } // This is the workflow that the step belongs to

    public int? OnboardingEntityWorkflowStep_FromOnboardingStageID { get; set; }

    public int? OnboardingEntityWorkflowStep_ToOnboardingStageID { get; set; }

    public bool ISTerminal { get; set; } // means the step is the last step in the workflow

    public string? CustomAction { get; set; } // This is the custom action that will be executed when the step is reached, like sending an email or notification save and next or user will added to bidirectional.

    public OnboardingStage? OnboardingEntityWorkflowStep_FromOnboardingStage { get; set; }

    public OnboardingStage? OnboardingEntityWorkflowStep_ToOnboardingStage { get; set; }

    public OnboardingEntityWorkflow? OnboardingEntityWorkflowStep_OnboardingWorkflow { get; set; }
}
