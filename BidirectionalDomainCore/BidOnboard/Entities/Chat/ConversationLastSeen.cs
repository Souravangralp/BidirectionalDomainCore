namespace Bidirectional.DomainCore.BidOnboard.Entities.Chat;

public class ConversationLastSeen : BaseAuditableEntity
{
    public int? ConversationLastSeen_ConversationID { get; set; }

    public int? ConversationLastSeen_UserID { get; set; }

    public int? ConversationLastSeen_LastReadMessageID { get; set; }

    public DateTime LastReadAt { get; set; }

    public Conversation? ConversationLastSeen_Conversation { get; set; }

    public User? ConversationLastSeen_User { get; set; }

    public Message? ConversationLastSeen_LastReadMessage { get; set; }
}
