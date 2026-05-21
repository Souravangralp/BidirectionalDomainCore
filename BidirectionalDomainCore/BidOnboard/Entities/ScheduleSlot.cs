namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class ScheduleSlot : BaseAuditableEntity
{
    public DateTimeOffset FromTime { get; set; }

    public DateTimeOffset ToTime { get; set; }

    public int TotalSlots { get; set; }

    public int BookedSlots { get; set; }

    public int? SlotStatusType_CoreDB_GeneralLookUpID { get; set; }
}
