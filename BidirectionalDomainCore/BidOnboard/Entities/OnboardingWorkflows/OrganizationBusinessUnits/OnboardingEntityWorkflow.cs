using Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.Users;

namespace Bidirectional.DomainCore.BidOnboard.Entities.OnboardingWorkflows.OrganizationBusinessUnits;

public class OnboardingEntityWorkflow : BaseAuditableEntity
{
    public DomainEntityTypes Entity { get; set; }

    public DomainEntityTypes ParentEntity { get; set; }

    public ICollection<OnboardingEntityWorkflowStep> OnboardingEntityWorkflowSteps { get; set; } = [];

    public ICollection<OnboardingWorkflowStep> OnboardingWorkflowSteps { get; set; } = [];
}
