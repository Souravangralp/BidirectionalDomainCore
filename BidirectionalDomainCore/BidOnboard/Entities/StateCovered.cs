namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class StateCovered : BaseAuditableEntity
{
    public int? StateCovered_UserID { get; set; }

    public int? StateID { get; set; }

    public User? StateCovered_User { get; set; }
}
