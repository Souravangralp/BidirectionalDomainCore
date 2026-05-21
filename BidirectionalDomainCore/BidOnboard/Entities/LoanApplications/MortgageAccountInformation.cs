namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents detailed information about a mortgage account within a mortgage, including interest rates, repayment types, account details, and related attributes.
/// </summary>
public class MortgageAccountInformation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related mortgage for this account information.
    /// </summary>
    public int? MortgageAccountInformation_MortgageID { get; set; }

    /// <summary>
    /// Gets or sets the outstanding balance on the mortgage account.
    /// </summary>
    public double? BalanceOutstanding { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the current rate is fixed (true) or variable (false).
    /// </summary>
    [Comment("if it is true then current fixed else variable rate")]
    public bool ISCurrentFixedRate { get; set; }

    /// <summary>
    /// Gets or sets the current fixed interest rate for the account, if applicable.
    /// </summary>
    public double? CurrentFixedInterestRate { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the current fixed interest rate.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? CurrentFixedRateTillUtc { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the repayment type is Principal &amp; Interest (true) or Interest Only (false).
    /// </summary>
    [Comment("Yes means P And I and No means IO")]
    public bool? ISRepaymentTypePAndI { get; set; }

    #region Remove Fields

    /// <summary>
    /// Gets or sets the general lookup ID for the mortgage account type, used when there are multiple mortgages.
    /// </summary>
    [Comment("If applicant have more then 1 mortgage than we will get This Id from general look up.")]
    public int? MortgageAccountType_GeneralLookupID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the interest is deductible for this account.
    /// </summary>
    public bool? ISDeductibleInterest { get; set; }

    /// <summary>
    /// Gets or sets the account number for the mortgage account.
    /// </summary>
    [EncryptColumn]
    public string? AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the initially approved loan amount for the mortgage account.
    /// </summary>
    public double? InitialApprovedLoanAmount { get; set; }

    /// <summary>
    /// Gets or sets the available redraw amount on the mortgage account.
    /// </summary>
    public double? AvailableRedraw { get; set; }

    /// <summary>
    /// Gets or sets the initial loan term for the mortgage account.
    /// </summary>
    public double? InitialLoanTerm { get; set; }

    /// <summary>
    /// Gets or sets the current variable interest rate, if the account is on a variable rate.
    /// </summary>
    public double? CurrentVariableInterestRate { get; set; }

    /// <summary>
    /// Gets or sets the remaining fixed term on the mortgage account, if applicable.
    /// </summary>
    public double? RemainingFixedTerm { get; set; }

    /// <summary>
    /// Gets or sets the interest rate to which the account will revert after the fixed period ends.
    /// </summary>
    public double? RevertingFromFixedToVariableRate { get; set; }

    /// <summary>
    /// Gets or sets the interest rate that will apply when reverting from Interest Only to Principal &amp; Interest.
    /// </summary>
    public double? RevertingFromIOAndPAndIRate { get; set; }

    /// <summary>
    /// Gets or sets the remaining period of Principal &amp; Interest repayments if the account is currently Interest Only.
    /// </summary>
    public double? RemainingPAndIPeriodIfIO { get; set; }

    /// <summary>
    /// Gets or sets the related mortgage entity for this account information.
    /// </summary>
    public Mortgage? MortgageAccountInformation_Mortgage { get; set; }

    #endregion
}
