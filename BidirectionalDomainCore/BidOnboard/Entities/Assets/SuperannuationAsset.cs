namespace Bidirectional.DomainCore.BidOnboard.Entities.Assets;

public class SuperannuationAsset : BaseAsset
{
    public int SuperannuationAsset_UserID { get; set; }

    public string? FundName { get; set; }

    public string? MemberNumber { get; set; }

    public int? FundType_CoreDB_GeneralLookUpID { get; set; } // Retail, Industry, Self-managed

    public DateOnly? LastContributionDate { get; set; }

    public bool ISLockedUntilRetirement { get; set; }

    public User? SuperannuationAsset_User { get; set; }
}
