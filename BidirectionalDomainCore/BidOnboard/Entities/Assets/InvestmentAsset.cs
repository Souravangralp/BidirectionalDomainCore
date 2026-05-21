namespace Bidirectional.DomainCore.BidOnboard.Entities.Assets;

public class InvestmentAsset : BaseAsset
{
    public int InvestmentAsset_UserID { get; set; }

    public int? InvestmentType_CoreDB_GeneralLookUpID { get; set; }

    //public string? InvestmentType { get; set; } // Shares, Bonds, Managed Funds, Crypto

    [EncryptColumn]
    public string? InstitutionName { get; set; } // e.g., westBank, moneyBank

    [EncryptColumn]
    public string? AccountNumber { get; set; }

    public int UnitsOwned { get; set; }

    public double UnitPrice { get; set; }

    public string? Currency { get; set; }

    public string? OtherInvestmentTypeDescription { get; set; }

    public User? InvestmentAsset_User { get; set; }
}
