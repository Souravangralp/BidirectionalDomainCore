namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a court judgment record associated with a loan application, including details about the applicant and related credit history.
/// </summary>
public class CourtJudgement : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related company applicant in the court judgment.
    /// </summary>
    public int? CourtJudgement_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated financial or non-financial credit history related to the court judgment.
    /// </summary>
    public int? CourtJudgement_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier specifying the type of credit history (e.g., Financial, Telco, Utility).
    /// </summary>
    public int? CreditHistoryType_GeneralLookUpID { get; set; } // We will get this values ( Financial, Telco, Utility ) from General LookUp table

    /// <summary>
    /// Gets or sets the amount associated with the court judgment.
    /// </summary>
    public double? CourtJudgementAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the court judgment has been paid.
    /// </summary>
    public double? IsCourtJudgementPaid { get; set; }

    /// <summary>
    /// Gets or sets the company applicant entity related to the court judgment.
    /// </summary>
    public CompanyApplicant? CourtJudgement_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the credit history entity (financial or non-financial) associated with the court judgment.
    /// </summary>
    public CreditHistoryForFinancialAndNonFinancial? CourtJudgement_CreditHistoryForFinancialAndNonFinancial { get; set; }
}
