namespace Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;

public class PersonalLoanLiability : BaseLiability
{
    public int PersonalLoanLiability_UserID { get; set; }

    public int? PersonalLoanType_CoreDB_GeneralLookUpID { get; set; }

    public string? LenderName { get; set; }

    public double OriginalLoanAmount { get; set; }

    public DateOnly? StartDate { get; set; }

    public float InterestRate { get; set; }

    public int TermInMonths { get; set; }

    public double MonthlyRepayment { get; set; }

    public string? Purpose { get; set; } // Car, Medical, Education, etc.

    public string? OtherPersonalLoanType { get; set; }

    public User? PersonalLoanLiability_User { get; set; }
}
