namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the account and repayment information related to a loan application,
/// including credit history, account type, credit limits, defaults, and repayment statuses.
/// </summary>
public class AccountAndRepayment : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated credit history for financial and non-financial information.
    /// </summary>
    public int? AccountAndRepayment_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    /// <summary>
    /// Gets or sets the account type identifier from the GeneralLookUp table in the CoreDB.
    /// </summary>
    [Comment("We will get this data from GeneralLookUp Table")]
    public int? AccountType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the total number of accounts, including closed accounts.
    /// </summary>
    public double? NumberOfAccountIncludedClosed { get; set; }

    /// <summary>
    /// Gets or sets the total credit limit available across all accounts.
    /// </summary>
    public double? TotalCreditLimit { get; set; }

    /// <summary>
    /// Gets or sets the count of defaults on the account.
    /// </summary>
    public double? DefaultCount { get; set; }

    /// <summary>
    /// Gets or sets the current repayment status of the account.
    /// </summary>
    public string? CurrentRepaymentStatus { get; set; }

    /// <summary>
    /// Gets or sets the worst repayment status recorded in the last two years.
    /// </summary>
    public string? WorstRepaymentStatusLastTwoYears { get; set; }

    /// <summary>
    /// Gets or sets the worst repayment status recorded in the last month.
    /// </summary>
    public string? WorstRepaymentStatusLastMonth { get; set; }

    /// <summary>
    /// Gets or sets the associated credit history for financial and non-financial information.
    /// </summary>
    public CreditHistoryForFinancialAndNonFinancial? AccountAndRepayment_CreditHistoryForFinancialAndNonFinancial { get; set; }
}
