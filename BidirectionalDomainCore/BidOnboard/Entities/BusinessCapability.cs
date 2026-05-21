namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessCapability : BaseAuditableEntity
{
    public int? BusinessCapability_BusinessCapabilityTypeID { get; set; }

    public int? CapabilityItem_CoreDB_GeneralLookUpID { get; set; } // Lookup: e.g., "Referral System", "Advertising", "CRM", "Core Banking"

    public string? OtherCapabilityItem { get; set; } // Free text if not in lookup

    public BusinessCapabilityType? BusinessCapability_BusinessCapabilityType { get; set; }
}
