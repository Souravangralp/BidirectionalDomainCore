namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

public class RepaymentHistory : BaseAuditableEntity
{
    public int? RepaymentHistory_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    public int? LoanAccountType_GeneralLookUpID { get; set; }

    public int? LoanEquifaxStatusType_GeneralLookUpID { get; set; }

    public string? OtherLoanAccountType { get; set; }

    public int? LateRepaymentCountInLast24Months { get; set; }

    public CreditHistoryForFinancialAndNonFinancial? RepaymentHistory_CreditHistoryForFinancialAndNonFinancial { get; set; }
}
