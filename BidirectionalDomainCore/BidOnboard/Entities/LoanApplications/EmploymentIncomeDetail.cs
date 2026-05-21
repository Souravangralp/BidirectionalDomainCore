namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents detailed information about an applicant's employment status within a loan application.
/// </summary>
public class EmploymentStatusDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related PAYG employment income detail.
    /// </summary>
    public int? EmploymentIncomeDetail_PaygID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this employment is the applicant's primary source of income.
    /// </summary>
    public bool? ISPrimary { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this employment is eligible for the selected product.
    /// </summary>
    public bool? ISEligibleForProduct { get; set; } // Added on 2-3-2026 after requirement from Ken.

    /// <summary>
    /// Gets or sets the general lookup identifier for the employment status type from the core database.
    /// </summary>
    public int? EmploymentStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a description for other types of employment not covered by predefined categories.
    /// </summary>
    public string? OtherEmploymentType { get; set; }

    /// <summary>
    /// Gets or sets the related PAYG employment income detail entity.
    /// </summary>
    public Payg? EmploymentIncomeDetail_Payg { get; set; }
}
