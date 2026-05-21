namespace Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;

public class HpLeaseLiability : BaseLiability
{
    public int HpLeaseLiability_UserID { get; set; }

    public string? LenderName { get; set; }

    public string? DescriptionOfAsset { get; set; }

    public double OriginalAmount { get; set; }

    public DateOnly? StartDate { get; set; }

    public float InterestRate { get; set; }

    public int DurationMonths { get; set; }

    public double MonthlyPayment { get; set; }

    public User? HpLeaseLiability_User { get; set; }
}
