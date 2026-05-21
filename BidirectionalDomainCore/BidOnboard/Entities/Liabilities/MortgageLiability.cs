namespace Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;

public class MortgageLiability : BaseLiability
{
    public int MortgageLiability_UserID { get; set; }

    public int? MortgageType_CoreDB_GeneralLookUpID { get; set; }

    public string? LenderName { get; set; }

    public string? PropertyAddress { get; set; }

    public double OriginalLoanAmount { get; set; }

    public DateOnly? StartDate { get; set; }

    public float InterestRate { get; set; }

    public bool ISFixedRate { get; set; }

    public int LoanTermYears { get; set; }

    public double MonthlyRepayment { get; set; }

    public bool ISInterestOnly { get; set; }

    public string? OtherMortgageType { get; set; }

    public User? MortgageLiability_User { get; set; }
}
