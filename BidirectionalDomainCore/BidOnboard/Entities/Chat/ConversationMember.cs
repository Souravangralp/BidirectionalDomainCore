namespace Bidirectional.DomainCore.BidOnboard.Entities.Chat;

public class ConversationMember : BaseAuditableEntity
{
    public int? ConversationMember_ConversationID { get; set; }

    public int? ConversationMember_UserID { get; set; }

    public bool ISAdmin { get; set; }

    public DateTime JoinedAt { get; set; }

    public Conversation? ConversationMember_Conversation { get; set; }

    public User? ConversationMember_User { get; set; }
}
