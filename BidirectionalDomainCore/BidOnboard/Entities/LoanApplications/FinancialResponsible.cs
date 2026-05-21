namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the entity responsible for managing the financial obligations associated with a loan application.
/// </summary>
public class FinancialResponsible : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated company applicant that is financially responsible.
    /// </summary>
    public int? FinancialResponsible_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the unique financial identifier associated with the company.
    /// </summary>
    public string? CompanyFinancialUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the company applicant entity that is financially responsible for the loan application.
    /// </summary>
    public CompanyApplicant? FinancialResponsible_CompanyApplicant { get; set; }
}
