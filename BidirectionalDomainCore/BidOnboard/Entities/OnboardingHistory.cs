namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class OnboardingHistory : BaseAuditableEntity
{
    public int? OnboardingHistory_OrganizationID { get; set; }

    public int? OnboardingHistory_BusinessUnitID { get; set; }

    public int? OnboardingHistory_OnboardingStageID { get; set; }

    public int? OnboardingHistory_UserID { get; set; }

    public string? Comments { get; set; }

    public string? UpdatedBy { get; set; }

    public bool ISRevertedStatus { get; set; }

    public string? RevertedReason { get; set; }

    public string? RevertedBy { get; set; }

    public DateTime? RevertedDate { get; set; }

    public User? OnboardingHistory_User { get; set; }

    public Organization? OnboardingHistory_Organization { get; set; }

    public BusinessUnit? OnboardingHistory_BusinessUnit { get; set; }

    public OnboardingStage? OnboardingHistory_OnboardingStage { get; set; }
}
