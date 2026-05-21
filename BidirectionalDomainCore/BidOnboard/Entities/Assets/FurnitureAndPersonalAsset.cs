namespace Bidirectional.DomainCore.BidOnboard.Entities.Assets;

public class FurnitureAndPersonalAsset : BaseAsset
{
    public int FurnitureAndPersonalAsset_UserID { get; set; }

    public int? FurnitureAndPersonalAssetType_CoreDB_GeneralLookUpID { get; set; }

    public int? FurnitureAndPersonalAssetConditionType_CoreDB_GeneralLookUpID { get; set; }

    public string? ItemCategory { get; set; } // Furniture, Electronics, Jewelry

    public string? Address { get; set; }

    public string? OtherFurnitureAndPersonalAssetType { get; set; }

    public string? OtherFurnitureAndPersonalAssetConditionType { get; set; }

    public DateOnly? EstimatedValuationDate { get; set; }

    public User? FurnitureAndPersonalAsset_User { get; set; }
}
