namespace Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;

public class WarehouseGeographicCoverage : BaseAuditableEntity
{
    public int? WarehouseGeographicCoverage_WarehouseFacilityID { get; set; }

    public int? StateID { get; set; }

    public int? CountryID { get; set; }

    public WarehouseFacility? WarehouseGeographicCoverage_WarehouseFacility { get; set; }
}
