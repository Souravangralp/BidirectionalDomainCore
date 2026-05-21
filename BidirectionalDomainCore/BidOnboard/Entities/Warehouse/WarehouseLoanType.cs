namespace Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;

public class WarehouseLoanType : BaseAuditableEntity
{
    public int WarehouseLoanType_WarehouseFacilityID { get; set; }

    public int? LoanPurposeType_CoreDB_GeneralLookUpID { get; set; }

    public WarehouseFacility? WarehouseLoanType_WarehouseFacility { get; set; }
}
