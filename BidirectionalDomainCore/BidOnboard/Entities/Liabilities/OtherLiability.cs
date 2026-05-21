namespace Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;

public class OtherLiability : BaseLiability
{
    public int OtherLiability_UserID { get; set; }

    public int? OtherLiabilityType_CoreDB_GeneralLookUpID { get; set; }

    public string? LiabilityName { get; set; }

    public string? Category { get; set; } // Tax debt, Family loan, etc.

    public DateOnly? IncurredDate { get; set; }

    public double MonthlyRepayment { get; set; }

    public string? OtherLiabilityTypeDescription { get; set; } // this field is for the describing the other type of OtherLiablityType_GeneralLookUp value

    public User? OtherLiability_User { get; set; }
}
