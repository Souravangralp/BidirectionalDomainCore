namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class PreferredCommunicationDetail : BaseAuditableEntity
{
    public int? PreferredCommunicationDetail_UserID { get; set; }

    public int? PreferredCommunicationDetail_ScheduleSlotID { get; set; }

    public int? ContactType_CoreDB_GeneralLookUpID { get; set; } // General lookup ID for contact type (Teams, SMS, WhatsApp)

    public TimeOnly? PreferredTime { get; set; } // Preferred communication time

    public User? PreferredCommunicationDetail_User { get; set; }

    public ScheduleSlot? PreferredCommunicationDetail_ScheduleSlot { get; set; }
}
