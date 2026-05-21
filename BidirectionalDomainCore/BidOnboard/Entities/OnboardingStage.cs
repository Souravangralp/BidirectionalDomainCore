namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class OnboardingStage : BaseAuditableEntity
{
    public string? Type { get; set; } // branch and user

    public string? DisplayStatusName { get; set; } // In this we will have some display for user readability

    public string? Status { get; set; } // In this we will have status all status of user and branch
}
