namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class AreaOfExpertise : BaseAuditableEntity
{
    public int? AreaOfExpertise_UserID { get; set; }

    public int? ExpertiseType_GeneralLookUpID { get; set; }

    public User? AreaOfExpertise_User { get; set; }
}
