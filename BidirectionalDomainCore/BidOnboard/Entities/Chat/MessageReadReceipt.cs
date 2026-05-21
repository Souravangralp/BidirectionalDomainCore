namespace Bidirectional.DomainCore.BidOnboard.Entities.Chat;

public class MessageReadReceipt : BaseAuditableEntity
{
    public int? MessageReadReceipt_MessageID { get; set; }

    public int? MessageReadReceipt_UserID { get; set; }

    public DateTime ReadAt { get; set; }

    public Message? MessageReadReceipt_Message { get; set; }

    public User? MessageReadReceipt_User { get; set; }
}
