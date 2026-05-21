namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the available options for loan repayment related to a borrower's retirement planning.
/// </summary>
public class RepaymentOption : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated applicant retirement detail.
    /// </summary>
    public int? RepaymentOption_ApplicantRetirementDetailID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether downsizing home is selected as a repayment option.
    /// </summary>
    public bool ISDownsizingHome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether co-applicant income is a source for repayment.
    /// </summary>
    public bool ISCoApplicantIncome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether income from other investments is a repayment source.
    /// </summary>
    public bool HASIncomeFromOtherInvestment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is recurring income from superannuation.
    /// </summary>
    public bool HASRecurringIncomeFromSuperannuation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan repayment is planned prior to retirement.
    /// </summary>
    public bool HASRepaymentOfLoanPriorToRetirement { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether sale of assets is planned for loan repayment.
    /// </summary>
    public bool HASSaleOfAssets { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether savings will be used as a repayment source.
    /// </summary>
    public bool HASSavings { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a superannuation lump sum will be used at retirement for repayment.
    /// </summary>
    public bool ISSuperannuationLumpSumRetirement { get; set; }

    /// <summary>
    /// Gets or sets other information about the repayment option not covered by the specific properties.
    /// </summary>
    public string? Other { get; set; }

    /// <summary>
    /// Gets or sets the related applicant retirement detail entity.
    /// </summary>
    public ApplicantRetirementDetail? RepaymentOption_ApplicantRetirementDetail { get; set; }
}
