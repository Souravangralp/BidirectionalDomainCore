namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessCostDetail : BaseAuditableEntity
{
    public int? BusinessCostDetail_OrganizationID { get; set; }

    public int? BusinessCostNatureType_CoreDB_GeneralLookUpID { get; set; }

    public int? BusinessCostType_CoreDB_GeneralLookUpID { get; set; }

    public string? OtherCostType { get; set; }

    public double? CostAmount { get; set; }

    public string? CostDescription { get; set; }

    public Organization? BusinessCostDetail_Organization { get; set; }
}
