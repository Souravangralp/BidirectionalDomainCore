namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the proportion of liability assigned to owners within a loan application,
/// including associations to various related entities such as applicants, liabilities, loans, and companies.
/// </summary>
public class OwnerLiabilityPercentage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the applicant associated with this ownership percentage.
    /// </summary>
    public int? OwnerLiabilityPercentage_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related Higher Education Loan Program.
    /// </summary>
    public int? OwnerLiabilityPercentage_HigherEducationLoanProgramID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for loans other than mortgages associated with this ownership liability.
    /// </summary>
    public int? OwnerLiabilityPercentage_LoansOtherThanMortgageID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related liability entry.
    /// </summary>
    public int? OwnerLiabilityPercentage_LiabilityID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related company applicant.
    /// </summary>
    public int? OwnerLiabilityPercentage_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the textual representation of the owner's proportion of liability.
    /// </summary>
    public string? Proportion { get; set; }

    /// <summary>
    /// Gets or sets the percentage value indicating the owner's share of the liability.
    /// </summary>
    public double? PercentShared { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the party involved in the liability.
    /// </summary>
    public string? PartyUniqueID { get; set; }

    /// <summary>
    /// Gets or sets an extra field for storing additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets a second extra field for supplementary information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets a third extra field for extended information needs.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the company applicant entity associated with this ownership liability.
    /// </summary>
    public CompanyApplicant? OwnerLiabilityPercentage_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the loans other than mortgage entity related to this liability.
    /// </summary>
    public LoansOtherThanMortgage? OwnerLiabilityPercentage_LoansOtherThanMortgage { get; set; }

    /// <summary>
    /// Gets or sets the higher education loan program entity related to this liability.
    /// </summary>
    public HigherEducationLoanProgram? OwnerLiabilityPercentage_HigherEducationLoanProgram { get; set; }

    /// <summary>
    /// Gets or sets the liability entity associated with this ownership liability.
    /// </summary>
    public Liability? OwnerLiabilityPercentage_Liability { get; set; }

    /// <summary>
    /// Gets or sets the applicant entity associated with this ownership liability.
    /// </summary>
    public Applicant? OwnerLiabilityPercentage_Applicant { get; set; }
}
