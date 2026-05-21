namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessObjective : BaseAuditableEntity
{
    public int? BusinessObjective_BusinessDetailID { get; set; }

    public int? PrimaryBusinessObjectiveType_CoreDB_GeneralLookUpID { get; set; }

    public BusinessDetail? BusinessObjective_BusinessDetail { get; set; }
}
