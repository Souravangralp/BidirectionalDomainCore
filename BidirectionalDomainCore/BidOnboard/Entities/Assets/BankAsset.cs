namespace Bidirectional.DomainCore.BidOnboard.Entities.Assets;

public class BankAsset : BaseAsset
{
    public int BankAsset_UserID { get; set; }

    public int? AccountType_CoreDB_GeneralLookUpID { get; set; } // Savings, Checking, Term Deposit

    [EncryptColumn]
    public string? BSB { get; set; }

    [EncryptColumn]
    public string? BankName { get; set; }

    public string? OtherAccountType { get; set; }

    [EncryptColumn]
    public string? AccountNumber { get; set; }

    public string? Currency { get; set; }

    public bool ISJointAccount { get; set; }

    public User? BankAsset_User { get; set; }
}
