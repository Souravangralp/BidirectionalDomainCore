namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the income data for a company related to a loan application, including profit, income period, and associated entities.
/// </summary>
public class CompanyIncome : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated self-employed entity, if applicable.
    /// </summary>
    public int? CompanyIncome_SelfEmploymentDetailID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated company applicant entity, if applicable.
    /// </summary>
    public int? CompanyIncome_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this income is considered previous income.
    /// If false, it is considered recent income.
    /// </summary>
    [Comment("if false then we will consider it as RecentIncome")]
    public bool ISPreviousIncome { get; set; }

    /// <summary>
    /// Gets or sets the profit before tax for the company.
    /// </summary>
    public double? ProfitBeforeTax { get; set; }

    /// <summary>
    /// Gets or sets the UTC start date of the income period.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? IncomePeriodStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC end date of the income period.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? IncomePeriodEndDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the income statement associated with the company income.
    /// </summary>
    public IncomeStatement? IncomeStatement { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity.
    /// </summary>
    public CompanyApplicant? CompanyIncome_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the related self-employed entity.
    /// </summary>
    public SelfEmploymentDetail? CompanyIncome_SelfEmploymentDetail { get; set; }
}
