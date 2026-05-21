namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class GeneralLookUpValue : BaseAuditableEntity
{
    public int? GeneralLookUpValue_GeneralLookUpTypeID { get; set; }

    public string? Values { get; set; }

    public GeneralLookUpType? GeneralLookUpValue_GeneralLookUpType { get; set; }
}
