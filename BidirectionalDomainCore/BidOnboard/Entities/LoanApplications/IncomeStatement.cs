namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an income statement containing key financial details for a loan application,
/// including business turnover, expenses, profits, other income, and add-backs.
/// </summary>
public class IncomeStatement : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the foreign key to the related CompanyIncome entity.
    /// </summary>
    public int? IncomeStatement_CompanyIncomeID { get; set; }

    /// <summary>
    /// Gets or sets the foreign key to the related SelfEmployed entity.
    /// </summary>
    public int? IncomeStatement_SelfEmploymentDetailID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this income statement is for the current year.
    /// </summary>
    public bool ISCurrentYear { get; set; }

    /// <summary>
    /// Gets or sets the total gross business turnover amount.
    /// </summary>
    public double? GrossBusinessTurnover { get; set; }

    /// <summary>
    /// Gets or sets the total amount of business expenses.
    /// </summary>
    public double? TotalBusinessExpensesAmount { get; set; }

    /// <summary>
    /// Gets or sets the net profit amount.
    /// </summary>
    public double? NetProfitAmount { get; set; }

    /// <summary>
    /// Gets or sets the amount earned from asset sales, representing other income from non-primary business activities.
    /// </summary>
    [Comment("Other income from sources other than from the primary business activities?")]
    public double? AssetSaleAmount { get; set; }

    /// <summary>
    /// Gets or sets the capital gain amount, representing other income from non-primary business activities.
    /// </summary>
    [Comment("Other income from sources other than from the primary business activities?")]
    public double? CapitalGainAmount { get; set; }

    /// <summary>
    /// Gets or sets other income amounts from sources outside of primary business activities.
    /// </summary>
    [Comment("Other income from sources other than from the primary business activities?")]
    public double? OtherIncomeAmount { get; set; }

    #region AddBacks

    /// <summary>
    /// Gets or sets the yearly depreciation amount to be added back for calculation purposes.
    /// </summary>
    public double? DepreciationAmount { get; set; }

    /// <summary>
    /// Gets or sets the interest expense amount to be added back.
    /// </summary>
    public double? InterestExpenseAmount { get; set; }

    /// <summary>
    /// Gets or sets the wages expense amount to be added back.
    /// </summary>
    public double? WagesExpenseAmount { get; set; }

    /// <summary>
    /// Gets or sets the write-offs amount to be added back.
    /// </summary>
    public double? WriteOffsAmount { get; set; }

    /// <summary>
    /// Gets or sets the start-up advertising costs considered for add-back.
    /// </summary>
    public double? StartUpAdvertisingCosts { get; set; }

    /// <summary>
    /// Gets or sets initial non-recurring expenses to be added back.
    /// </summary>
    public double? InitialNonRecurringExpenses { get; set; }

    /// <summary>
    /// Gets or sets the abnormal items expense to be added back.
    /// </summary>
    public double? AbnormalItemsExpense { get; set; }

    /// <summary>
    /// Gets or sets the amount of director fees considered as an add-back.
    /// </summary>
    public double? DirectorFeesAmount { get; set; }

    /// <summary>
    /// Gets or sets the amount of dividend payments to be added back.
    /// </summary>
    public double? DividendPaymentsAmount { get; set; }

    /// <summary>
    /// Gets or sets other non-recurring expenses to be added back.
    /// </summary>
    public double? OtherNonRecurringExpenses { get; set; }

    #endregion

    /// <summary>
    /// Gets or sets the associated CompanyIncome navigation property.
    /// </summary>
    public CompanyIncome? IncomeStatement_CompanyIncome { get; set; }

    /// <summary>
    /// Gets or sets the associated SelfEmployed navigation property.
    /// </summary>
    public SelfEmploymentDetail? IncomeStatement_SelfEmploymentDetail { get; set; }
}
