using Bidirectional.DomainCore.BidOnboard.Enums;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a contact entity containing communication details and related references for loan applications.
/// </summary>
public class Contact : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the applicant ID associated with the contact.
    /// </summary>
    public int? Contact_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the company applicant ID associated with the contact.
    /// </summary>
    public int? Contact_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the sales channel company ID associated with the contact.
    /// </summary>
    public int? Contact_SalesChannelCompanyID { get; set; }

    /// <summary>
    /// Gets or sets the sales channel loan writer ID associated with the contact.
    /// </summary>
    public int? Contact_SalesChannelLoanWriterID { get; set; }

    /// <summary>
    /// Gets or sets the mobile or landline type for the contact.
    /// </summary>
    public MobileOrLandline MobileOrlandLine { get; set; }

    /// <summary>
    /// Gets or sets the contact's primary personal email address.
    /// </summary>
    public string? PersonalEmail { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the personal email has been verified.
    /// </summary>
    public bool ISPersonalEmailVerified { get; set; }

    /// <summary>
    /// Gets or sets the contact's secondary personal email address.
    /// </summary>
    public string? PersonalEmail2 { get; set; }

    /// <summary>
    /// Gets or sets the business email address of the contact.
    /// </summary>
    public string? BusinessEmail { get; set; }

    /// <summary>
    /// Gets or sets the secondary email address used by the contact.
    /// </summary>
    public string? SecondaryEmail { get; set; }

    /// <summary>
    /// Gets or sets the WhatsApp phone number of the contact.
    /// </summary>
    public string? WhatsAppPhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the international phone number of the contact.
    /// </summary>
    public string? InternationalPhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the LinkedIn profile handle of the contact.
    /// </summary>
    [TextClass(TextFieldClass.Ignored)]
    public string? LinkedInProfileHandle { get; set; }

    [TextClass(TextFieldClass.Url)]
    /// <summary>
    /// Gets or sets the Instagram profile handle of the contact.
    /// </summary>
    public string? InstagramProfileHandle { get; set; }

    /// <summary>
    /// Gets or sets the Facebook profile handle of the contact.
    /// </summary>
    [TextClass(TextFieldClass.Ignored)]
    public string? FacebookProfileHandle { get; set; }

    /// <summary>
    /// Gets or sets the mobile phone number of the contact.
    /// </summary>
    public string? MobilePhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the mobile number is verified.
    /// </summary>
    public bool ISMobileNumberVerified { get; set; }

    /// <summary>
    /// Gets or sets the contact's home phone number.
    /// </summary>
    public string? HomePhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the contact's work phone number.
    /// </summary>
    public string? WorkPhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the contact's office fax number.
    /// </summary>
    public string? OfficeFaxNumber { get; set; }

    /// <summary>
    /// Gets or sets the contact's office phone number.
    /// </summary>
    public string? OfficePhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the type of the personal email address.
    /// </summary>
    public string? PersonalEmailType { get; set; }

    /// <summary>
    /// Gets or sets the type of the secondary personal email address.
    /// </summary>
    public string? PersonalEmail2Type { get; set; }

    /// <summary>
    /// Gets or sets the country code for the mobile phone number.
    /// </summary>
    public string? MobilePhoneCountryCode { get; set; }

    /// <summary>
    /// Gets or sets the dialing code for the mobile phone.
    /// </summary>
    public string? MobilePhoneDialingCode { get; set; }

    /// <summary>
    /// Gets or sets the country code for the office phone.
    /// </summary>
    public string? OfficePhoneCountryCode { get; set; }

    /// <summary>
    /// Gets or sets the dialing code for the office phone.
    /// </summary>
    public string? OfficePhoneDialingCode { get; set; }

    /// <summary>
    /// Gets or sets the dialing code for the office fax number.
    /// </summary>
    public string? OfficeFaxDialingCode { get; set; }

    /// <summary>
    /// Gets or sets the country code for the office fax number.
    /// </summary>
    public string? OfficeFaxCountryCode { get; set; }

    /// <summary>
    /// Gets or sets the country code for the home phone number.
    /// </summary>
    public string? HomePhoneCountryCode { get; set; }

    /// <summary>
    /// Gets or sets the dialing code for the home phone number.
    /// </summary>
    public string? HomePhoneDialingCode { get; set; }

    /// <summary>
    /// Gets or sets the preferred contact method for the contact.
    /// </summary>
    public string? PreferredContactMethod { get; set; }

    /// <summary>
    /// Gets or sets the country code for the work phone.
    /// </summary>
    public string? WorkPhoneCountryCode { get; set; }

    /// <summary>
    /// Gets or sets the distance from the work address in kilometers.
    /// </summary>
    public string? DistanceFromWorkAddressKm { get; set; } // As Client requested to have this field for calculating distance from work address

    /// <summary>
    /// Gets or sets the distance from the owner-occupied property in kilometers.
    /// </summary>
    public string? DistanceFromOwnerOccupiedPropertyKm { get; set; } // As Client requested to have this field for calculating distance from owner occupied address

    /// <summary>
    /// Gets or sets the unique ID of the address associated with the contact.
    /// </summary>
    public string? AddressUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the registered address.
    /// </summary>
    public string? RegisteredAddressUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the unique ID for the principal trading address.
    /// </summary>
    public string? PrincipalTradingAddressUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the unique ID for the mailing address.
    /// </summary>
    public string? MailingAddressUniqueID { get; set; }

    /// <summary>
    /// Gets or sets an extra field for custom data.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for custom data.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for custom data.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the contact person associated with this contact.
    /// </summary>
    public ContactPerson? ContactPerson { get; set; }

    /// <summary>
    /// Gets or sets the applicant entity associated with the contact.
    /// </summary>
    public Applicant? Contact_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the company applicant entity associated with the contact.
    /// </summary>
    public CompanyApplicant? Contact_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the sales channel company entity associated with the contact.
    /// </summary>
    public SalesChannelCompany? Contact_SalesChannelCompany { get; set; }

    /// <summary>
    /// Gets or sets the sales channel loan writer entity associated with the contact.
    /// </summary>
    public SalesChannelLoanWriter? Contact_SalesChannelLoanWriter { get; set; }
}
