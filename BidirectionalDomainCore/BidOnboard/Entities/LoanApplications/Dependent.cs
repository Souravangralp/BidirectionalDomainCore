using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a dependent associated with a loan application, including applicant details and identifying information.
/// </summary>
public class Dependent : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the Applicant ID associated with this dependent.
    /// </summary>
    public int? Dependent_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the Company Applicant ID associated with this dependent.
    /// </summary>
    public int? Dependent_CompanyApplicantID { get; set; } // we are not sure if Company Applicants can have dependent, but we are keeping an provisional fields for now.

    public int? Dependent_UserID { get; set; }

    public int? DependentType_CoreDB_GeneralLookUpID { get; set; } // this will hold the information means that type of dependent at which stage of who has taken of the user

    /// <summary>
    /// Gets or sets a value indicating whether the dependent is financially independent.
    /// </summary>
    public bool ISFinancialIndependent { get; set; }

    /// <summary>
    /// Gets or sets the age of the dependent in years.
    /// </summary>
    public int? AgeInYears { get; set; }

    /// <summary>
    /// Gets or sets the date of birth of the dependent.
    /// </summary>
    public DateOnly? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the financial provider for the dependent.
    /// </summary>
    public string? FinancialProviderUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the first name or Christian name of the dependent.
    /// </summary>
    public string? FirstNameORChristianName { get; set; }

    /// <summary>
    /// Gets or sets the last name, surname, or family name of the dependent.
    /// </summary>
    public string? LastNameORSurnameORFamilyName { get; set; }

    /// <summary>
    /// Gets or sets an extra custom field 1 for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra custom field 2 for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra custom field 3 for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the applicant's relationship type ID from the general lookup.
    /// </summary>
    public int? RelationshipType_GeneralLookUpID { get; set; }

    public string? OtherRelationshipType { get; set; }

    /// <summary>
    /// Gets or sets the associated applicant entity for this dependent.
    /// </summary>
    public Applicant? Dependent_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the associated company applicant entity for this dependent.
    /// </summary>
    public CompanyApplicant? Dependent_CompanyApplicant { get; set; }

    public User? Dependent_User { get; set; }
}
