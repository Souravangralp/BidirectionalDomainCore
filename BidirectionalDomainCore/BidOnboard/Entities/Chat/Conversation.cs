namespace Bidirectional.DomainCore.BidOnboard.Entities.Chat;

public class Conversation : BaseAuditableEntity
{
    public int? Conversation_UserID { get; set; }

    public bool IsGroup { get; set; }

    public string? Name { get; set; }

    public User? Conversation_User { get; set; }

    public List<ConversationMember> ConversationMembers { get; set; } = [];

    public ICollection<Message> Messages { get; set; } = new List<Message>();

    public ICollection<ConversationLastSeen> LastSeen { get; set; } = new List<ConversationLastSeen>();
}
