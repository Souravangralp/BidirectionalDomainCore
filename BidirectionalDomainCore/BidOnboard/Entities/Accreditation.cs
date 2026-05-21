namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class Accreditation : BaseAuditableEntity
{
    public int? Accreditation_UserID { get; set; }

    public int? AccreditationType_CoreDB_GeneralLookUpID { get; set; }

    public int? LenderType_CoreDB_GeneralLookUpID { get; set; }

    public string? OtherLenderType { get; set; }

    public bool? ISAggregator { get; set; }

    public string? OtherThanAggregatorAndDirectDetails { get; set; }

    public string? BrokerID { get; set; }

    public string? RelationshipManager { get; set; }

    public User? Accreditation_User { get; set; }
}
