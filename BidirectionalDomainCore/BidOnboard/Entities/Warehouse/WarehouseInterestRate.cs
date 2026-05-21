namespace Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;

public class WarehouseInterestRate : BaseAuditableEntity
{
    public int? WarehouseInterestRate_WarehouseFacilityID { get; set; }

    public int? InterestType_CoreDB_GeneralLookUpID { get; set; }

    public string Benchmark { get; set; } = string.Empty;

    public WarehouseFacility? WarehouseInterestRate_WarehouseFacility { get; set; }
}
