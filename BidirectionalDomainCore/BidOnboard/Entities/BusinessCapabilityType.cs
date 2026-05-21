namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessCapabilityType : BaseAuditableEntity
{
    public int? BusinessCapabilityType_CoreDB_GeneralLookUpID { get; set; }

    public string? CapabilityDescription { get; set; }

    public ICollection<BusinessCapability> BusinessCapabilities { get; set; } = [];
}
