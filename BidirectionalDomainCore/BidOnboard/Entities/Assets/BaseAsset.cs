namespace Bidirectional.DomainCore.BidOnboard.Entities.Assets;

public abstract class BaseAsset : BaseAuditableEntity
{
    public double Value { get; set; }
}
