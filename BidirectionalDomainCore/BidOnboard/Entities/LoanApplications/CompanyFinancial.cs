namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the financial information of a company applicant for a loan application,
/// including profit and loss statement and financial period dates.
/// </summary>
public class CompanyFinancial : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the associated company applicant.
    /// </summary>
    public int? CompanyFinancial_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the profit and loss statement value for the company.
    /// </summary>
    public double? ProfitAndLossStatement { get; set; }

    /// <summary>
    /// Gets or sets the start date of the financial period in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? FinancialPeriodStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the end date of the financial period in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? FinancialPeriodEndDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity.
    /// </summary>
    public CompanyApplicant? CompanyFinancial_CompanyApplicant { get; set; }
}
