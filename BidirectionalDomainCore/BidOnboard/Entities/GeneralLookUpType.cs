namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class GeneralLookUpType : BaseAuditableEntity
{
    public string? DisplayName { get; set; }

    public string? Type { get; set; }

    public ICollection<GeneralLookUpValue> GeneralLookUpValues { get; set; } = [];
}
