namespace Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;

public class WarehouseFundingType : BaseAuditableEntity
{
    public int? WarehouseFundingType_WarehouseFacilityID { get; set; }

    public int? FundingType_CoreDB_GeneralLookUpID { get; set; }

    public WarehouseFacility? WarehouseFundingType_WarehouseFacility { get; set; } = null!;
}
