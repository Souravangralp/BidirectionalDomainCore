namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a self-employed entity involved in a loan application, including business details, registration information, and related financial statements.
/// </summary>
public class SelfEmploymentDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the associated PAYG identifier for the self-employed applicant.
    /// </summary>
    public int? SelfEmploymentDetail_PaygID { get; set; }

    /// <summary>
    /// Gets or sets the basis type, referencing the General Lookup table.
    /// </summary>
    [Comment("We will get this from General Lookup")]
    public int? BasisType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the status type, referencing the General Lookup table.
    /// </summary>
    [Comment("We will get this from General Lookup")]
    public int? StatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the company is taxed.
    /// </summary>
    public bool ISTaxedCompany { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the company is an onshore company.
    /// </summary>
    public bool ISOnshoreCompany { get; set; }

    /// <summary>
    /// Gets or sets the industry identifier associated with the self-employed business.
    /// </summary>
    public int? IndustryID { get; set; }

    /// <summary>
    /// Gets or sets the duration, in years, of self-employment.
    /// </summary>
    public decimal? SelfEmployedYear { get; set; }

    /// <summary>
    /// Gets or sets the additional months of self-employment beyond the years.
    /// </summary>
    public decimal? SelfEmployedMonth { get; set; }

    /// <summary>
    /// Gets or sets the financial year relevant to the application.
    /// </summary>
    public int? FinancialYear { get; set; }

    /// <summary>
    /// Gets or sets the financial month relevant to the application.
    /// </summary>
    public double? FinancialMonth { get; set; }

    /// <summary>
    /// Gets or sets the average number of hours worked per week.
    /// </summary>
    public double? AverageHoursPerWeek { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the employer entity.
    /// </summary>
    public string? EmployerUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the number of available financial statement months.
    /// </summary>
    public int? AvailableFinancialStatementMonths { get; set; }

    /// <summary>
    /// Gets or sets the year of the most recent financial statement.
    /// </summary>
    public int? RecentFinancialStatementYear { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the business has an Australian Business Number (ABN).
    /// </summary>
    public bool? HasABN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN) of the business.
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the year when the ABN was registered.
    /// </summary>
    public int? ABNRegisteredYear { get; set; }

    /// <summary>
    /// Gets or sets the month when the ABN was registered.
    /// </summary>
    public int? ABNRegisteredMonth { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the business is registered for GST.
    /// </summary>
    public bool? HasGST { get; set; }

    /// <summary>
    /// Gets or sets the GST number for the business.
    /// </summary>
    public string? GSTNumber { get; set; }

    /// <summary>
    /// Gets or sets the year when GST registration occurred.
    /// </summary>
    public int? GSTRegisteredYear { get; set; }

    /// <summary>
    /// Gets or sets the month when GST registration occurred.
    /// </summary>
    public int? GSTRegisteredMonth { get; set; }

    /// <summary>
    /// Gets or sets the Annual Revenue when user is self employed.
    /// </summary>
    public decimal? AnnualRevenue { get; set; }

    /// <summary>
    /// Gets or sets the year in which ACN registration was completed.
    /// </summary>
    public int? ACNRegisteredYear { get; set; }

    /// <summary>
    /// Gets or sets the month in which ACN registration was completed.
    /// </summary>
    public int? ACNRegisteredMonth { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the business has an Australian Company Number (ACN).
    /// </summary>
    public bool? HasACN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Company Number (ACN) of the business.
    /// </summary>
    public string? ACN { get; set; }

    /// <summary>
    /// Gets or sets the registered company name.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Gets or sets the business or trading name of the company.
    /// </summary>
    public string? BusinessNameORTradingName { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets another extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets a third extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the collection of directors associated with the business.
    /// </summary>
    public ICollection<Director> Directors { get; set; } = new List<Director>();

    /// <summary>
    /// Gets or sets the employer details related to the self-employed entity.
    /// </summary>
    public EmployerDetail? EmployerDetails { get; set; }

    /// <summary>
    /// Gets or sets the PAYG entity linked to the self-employed applicant.
    /// </summary>
    public Payg? SelfEmploymentDetail_Payg { get; set; }

    #region Remove Fields

    /// <summary>
    /// Gets or sets the self-employed type, referencing the General Lookup table.
    /// </summary>
    [Comment("We will get this from General Lookup")]
    public int? SelfEmployedType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the document type, referencing the General Lookup table.
    /// </summary>
    [Comment("we will get this Data from General look up table")]
    public int? DocType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the business profile type (e.g., sole trader, partnership, company, trust), referencing the General Lookup table.
    /// </summary>
    [Comment("Sole trader, Partnership, Company, Trust etc.")]
    public int? BusinessProfileType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the loan repayment strategy type, referencing the General Lookup table.
    /// </summary>
    [Comment("We will get this value from GeneralLookUp Table")]
    public int? LoanRepaymentStrategyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the credit risk exception type, referencing the General Lookup table.
    /// </summary>
    [Comment("We will get this value from GeneralLookUp Table  Request for credit risk exceptions (for Super prime & Premium above 60% LVR only, not required for Optimax range)")]
    public int? CreditRiskExceptionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the type for applications involving a purchase, referencing the General Lookup table.
    /// </summary>
    [Comment("We will get this value from GeneralLookUp Table  Request for credit risk exceptions (for Super prime & Premium above 60% LVR only, not required for Optimax range)")]
    public int? ApplicationThatInvolveAPurchaseType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is deemed not unsuitable.
    /// </summary>
    public bool ISLoanNotUnsuitable { get; set; }

    /// <summary>
    /// Gets or sets the list of previous company incomes for the self-employed applicant.
    /// </summary>
    public IList<CompanyIncome> CompanyPreviousIncomes { get; set; } = new List<CompanyIncome>();

    /// <summary>
    /// Gets or sets the list of income statements for the self-employed entity.
    /// </summary>
    public IList<IncomeStatement> IncomeStatements { get; set; } = new List<IncomeStatement>();

    #endregion
}
