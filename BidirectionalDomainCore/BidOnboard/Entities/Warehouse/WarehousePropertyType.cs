namespace Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;

public class WarehousePropertyType : BaseAuditableEntity
{
    public int? WarehousePropertyType_WarehouseFacilityID { get; set; }

    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    public WarehouseFacility? WarehousePropertyType_WarehouseFacility { get; set; } = null!;
}
