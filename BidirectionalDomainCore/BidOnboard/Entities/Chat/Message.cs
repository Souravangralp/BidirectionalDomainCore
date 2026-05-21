namespace Bidirectional.DomainCore.BidOnboard.Entities.Chat;

public class Message : BaseAuditableEntity
{
    public int? Message_ConversationID { get; set; }

    public int? Message_SenderID { get; set; }

    public string? Content { get; set; }

    public bool ISEdited { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Conversation? Message_Conversation { get; set; }

    public User? Message_Sender { get; set; }

    public ICollection<MessageReadReceipt> ReadReceipts { get; set; } = [];
}
