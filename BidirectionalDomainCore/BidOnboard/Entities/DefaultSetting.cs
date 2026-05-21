namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class DefaultSetting : BaseAuditableEntity
{
    public int? DefaultSettingType_GeneralLookUpID { get; set; }

    public decimal? MaxLimit { get; set; }
}
