namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class OnboardingProcess : BaseAuditableEntity
{
    public int? OnboardingProcess_UserID { get; set; }

    public int? OnboardingProcess_BusinessUnitID { get; set; }

    public int? OnboardingProcess_OrganizationID { get; set; }

    public int? OnboardingProcess_OnboardingStageID { get; set; }

    public string? UpdateBy { get; set; } // this will hold the user name who is updating the status like 'kjs', 'Mike/Krystal','admin', 'system'

    public string? StatusMessage { get; set; }

    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

    public User? OnboardingProcess_User { get; set; }

    public BusinessUnit? OnboardingProcess_BusinessUnit { get; set; }

    public Organization? OnboardingProcess_Organization { get; set; }

    public OnboardingStage? OnboardingProcess_OnboardingStage { get; set; }
}
