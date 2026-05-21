using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents employer-related details for a loan application, including industry, occupation information, identifiers, registration and business details.
/// </summary>
public class EmployerDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the PAYG identifier for the employer detail.
    /// </summary>
    public int? EmployerDetail_PaygID { get; set; }

    /// <summary>
    /// Gets or sets the industry identifier.
    /// </summary>
    public int? IndustryID { get; set; }

    /// <summary>
    /// Gets or sets the employment end date.
    /// </summary>
    public DateOnly? EmploymentEndDate { get; set; }

    /// <summary>
    /// Gets or sets the reason for leaving the employment.
    /// </summary>
    public string? ReasonForLeaving { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employer has an ABN.
    /// </summary>
    public bool? HasABN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN).
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the year the ABN was registered.
    /// </summary>
    public int? ABNRegisteredYear { get; set; }

    /// <summary>
    /// Gets or sets the month the ABN was registered.
    /// </summary>
    public int? ABNRegisteredMonth { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employer is registered for GST.
    /// </summary>
    public bool? HasGST { get; set; }

    /// <summary>
    /// Gets or sets the GST registration number.
    /// </summary>
    public string? GSTNumber { get; set; }

    /// <summary>
    /// Gets or sets the year GST registration occurred.
    /// </summary>
    public int? GSTRegisteredYear { get; set; }

    /// <summary>
    /// Gets or sets the month GST registration occurred.
    /// </summary>
    public int? GSTRegisteredMonth { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employer has an ACN.
    /// </summary>
    public bool? HasACN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Company Number (ACN).
    /// </summary>
    public string? ACN { get; set; }

    /// <summary>
    /// Gets or sets the country where the company is registered.
    /// </summary>
    public string? RegisteredInCountry { get; set; }

    /// <summary>
    /// Gets or sets the name of the company.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Gets or sets the business or trading name of the employer.
    /// </summary>
    public string? BusinessNameORTradingName { get; set; }

    /// <summary>
    /// Gets or sets the UTC date that the business began operation.
    /// </summary>
    public DateTime? BusinessStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the office phone number of the employer.
    /// </summary>
    public string? OfficePhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the country code for the office phone number.
    /// </summary>
    public string? OfficePhoneNumberCountryCode { get; set; }

    /// <summary>
    /// Gets or sets the address of the employer.
    /// </summary>
    public Address? Address { get; set; }

    #region Remove Fields

    /// <summary>
    /// Gets or sets the ABS Occupation Code, referring to the classification code used by the Australian Bureau of Statistics.
    /// </summary>
    [Comment("In Australia, the 'ABS Occupation Code' refers to the occupation classification codes used by the Australian Bureau of Statistics (ABS) to categorize various occupations ")]
    public string? ABSOccupationCode { get; set; }

    /// <summary>
    /// Gets or sets the ANZSCO Industry Code, as defined in the Australian and New Zealand Standard Classification of Occupations system.
    /// </summary>
    [Comment("The 'ANZSCO Industry Code' refers to the industry classification codes used in the Australian and New Zealand Standard Classification of Occupations (ANZSCO) system")]
    public string? ANZSCOIndustryCode { get; set; }

    /// <summary>
    /// Gets or sets the complete address of the employer.
    /// </summary>
    public string? CompleteAddress { get; set; }

    /// <summary>
    /// Gets or sets the PAYG entity associated with this employer detail.
    /// </summary>
    public Payg? EmployerDetail_Payg { get; set; }

    #endregion
}
