namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Constants for borrower base rate types used in rate calculation and comparison.
/// These values identify the source or category of base rates (e.g. WBC swap, peer RMBS, perpetual).
/// </summary>
public record BorrowerBaseRateConstant
{
    /// <summary>WBC swap base rate identifier.</summary>
    public const string BaseWBCRate = "WBC swap";

    /// <summary>Most recent comparable peer RMBS term deal base rate.</summary>
    public const string MostRecentComparablePeerRMBSTermDeal = "Most recent comparable peer RMBS term deal";

    /// <summary>Perpetual system and trust base rate.</summary>
    public const string Perpetual = "Perpetual system and trust";

    /// <summary>Cash to bills historic base rate.</summary>
    public const string CashToBills = "Cash to bills historic";

    /// <summary>ASFL margin base rate.</summary>
    public const string ASFLMargin = "ASFL margin";
}
