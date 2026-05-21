namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the identity and key corporate information of a company associated with a loan application.
/// </summary>
public class CompanyIdentity : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related introduction to the customer.
    /// </summary>
    public int? CompanyIdentity_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the Australian Company Number (ACN) of the company.
    /// </summary>
    public string? ACN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN) of the company.
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the current status of the company.
    /// </summary>
    public string? CompanyStatus { get; set; }

    /// <summary>
    /// Gets or sets the UTC date the company was incorporated.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? CompanyIncorporationDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the Australian state or territory in which the company was incorporated.
    /// </summary>
    public string? CompanyIncorporationState { get; set; }

    /// <summary>
    /// Gets or sets the ASIC document number associated with the company.
    /// </summary>
    public string? CompanyASICDocNumber { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the current company name began.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? CompanyNameStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of the last ASIC search for this company.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? LastASICSearchDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the file number assigned to the company.
    /// </summary>
    public int? CompanyFileNumber { get; set; }

    /// <summary>
    /// Gets or sets the UTC date the company file was created.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? FileCreateDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the number of employees at the company.
    /// </summary>
    public int? EmployeeCount { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of the last ACN review.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ACNReviewDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the company's annual sales revenue, typically in thousands.
    /// </summary>
    [Comment("probably in thousands (confirm with Equifax API)")]
    public double? AnnualSalesRevenue { get; set; }

    /// <summary>
    /// Gets or sets the principal business activity of the company.
    /// </summary>
    public string? PrincipalBusinessActivity { get; set; }

    /// <summary>
    /// Gets or sets the registered office address of the company.
    /// </summary>
    public string? CompanyRegisteredOfficeAddress { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the current registered office address began.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? RegisteredOfficeStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the ASIC document number for the registered office address.
    /// </summary>
    public int? RegisteredOfficeASICDocNumber { get; set; }

    /// <summary>
    /// Gets or sets the principal place of business address of the company.
    /// </summary>
    public string? PrincipalPlaceOfBusinessAddress { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the current principal place of business began.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? PrincipalPlaceOfBusinessStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the ASIC document number for the principal place of business.
    /// </summary>
    public string? PrincipalPlaceASICDocNumber { get; set; }

    /// <summary>
    /// Gets or sets the type of company, as reported by Equifax.
    /// </summary>
    [Comment("Extra field in Equifax report")]
    public string? CompanyType { get; set; }

    /// <summary>
    /// Gets or sets the class of the company.
    /// </summary>
    public string? CompanyClass { get; set; }

    /// <summary>
    /// Gets or sets the subclass of the company.
    /// </summary>
    public string? CompanySubClass { get; set; }

    /// <summary>
    /// Gets or sets the previous company state number.
    /// </summary>
    public string? PreviousCompanyStateNumber { get; set; }

    /// <summary>
    /// Gets or sets the related IntroductionToTheCustomer entity.
    /// </summary>
    public IntroductionToTheCustomer? CompanyIdentity_IntroductionToTheCustomer { get; set; }
}
