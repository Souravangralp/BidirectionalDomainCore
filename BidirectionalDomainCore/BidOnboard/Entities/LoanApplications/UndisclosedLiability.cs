namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an undisclosed liability associated with a loan application, capturing information about the liability's lender, type, balance, and repayment details.
/// </summary>
public class UndisclosedLiability : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related credit history for financial and non-financial entities.
    /// </summary>
    public int? UndisclosedLiability_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the liability type from the GeneralLookUp in the core database.
    /// </summary>
    public int? LiabilityType_GeneralLookUpID { get; set; } // We will get this value from GeneralLookUp

    /// <summary>
    /// Gets or sets the name of the lender associated with the liability.
    /// </summary>
    public string? Lender { get; set; }

    /// <summary>
    /// Gets or sets the current balance of the liability.
    /// </summary>
    public double? CurrentBalance { get; set; }

    /// <summary>
    /// Gets or sets the credit limit or maximum amount associated with the liability.
    /// </summary>
    public double? Limit { get; set; }

    /// <summary>
    /// Gets or sets the repayment amount for the liability.
    /// </summary>
    public double? Repayment { get; set; }

    /// <summary>
    /// Gets or sets the associated credit history for financial and non-financial entities.
    /// </summary>
    public CreditHistoryForFinancialAndNonFinancial? UndisclosedLiability_CreditHistoryForFinancialAndNonFinancial { get; set; }
}
