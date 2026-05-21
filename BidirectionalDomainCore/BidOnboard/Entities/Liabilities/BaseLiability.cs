namespace Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;

public abstract class BaseLiability : BaseAuditableEntity
{
    public double Value { get; set; }
}
