using Bidirectional.DomainCore.BidOnboard.Entities.Leads;
using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities.Valocity;
using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Represents a physical, mailing, or related address with various identification and location-related properties for loan applications.
/// </summary>
public class Address : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the associated real estate asset identifier.
    /// </summary>
    public int? Address_RealEstateAssetID { get; set; }

    /// <summary>
    /// Gets or sets the associated applicant identifier.
    /// </summary>
    public int? Address_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the associated employer detail identifier.
    /// </summary>
    public int? Address_EmployerDetailID { get; set; }

    /// <summary>
    /// Gets or sets the associated feedback and indication identifier.
    /// </summary>
    public int? Address_FeedbackAndIndicationID { get; set; }

    /// <summary>
    /// Gets or sets the associated loan security identifier.
    /// </summary>
    public int? Address_LoanSecurityID { get; set; }

    /// <summary>
    /// Gets or sets the associated lead identifier.
    /// </summary>
    public int? Address_LeadID { get; set; }

    /// <summary>
    /// Gets or sets the associated cash out identifier.
    /// </summary>
    public int? Address_CashoutID { get; set; }

    /// <summary>
    /// Gets or sets the associated Trust identifier.
    /// </summary>
    public int? Address_TrustID { get; set; }

    /// <summary>
    /// Gets or sets the associated Trust identifier.
    /// </summary>
    public int? Address_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the associated relocation identifier.
    /// </summary>
    public int? Address_RelocationID { get; set; }

    /// <summary>
    /// Gets or sets the associated purchase identifier.
    /// </summary>
    public int? Address_PurchaseID { get; set; }

    /// <summary>
    /// Gets or sets the residential type identifier from the general lookup.
    /// </summary>
    public int? ResidentialType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the PO Box type identifier from the general lookup.
    /// </summary>
    public int? POBoxType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the contact address type identifier from the general lookup.
    /// </summary>
    public int? ContactAddressType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this address is the same as the current address.
    /// </summary>
    [Comment("We have used this field for displaying same address")]
    public bool IsSameAsCurrentAddress { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is a mailing address.
    /// </summary>
    public bool ISMailingAddress { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is a residential address.
    /// </summary>
    public bool ISResidentialAddress { get; set; }

    /// <summary>
    /// Gets or sets the street name of the address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    [MaxLength(255)]
    public string? StreetName { get; set; }

    /// <summary>
    /// Gets or sets the street number of the address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    [MaxLength(255)]
    public string? StreetNumber { get; set; }

    /// <summary>
    /// Gets or sets the street type of the address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    [MaxLength(255)]
    public string? StreetType { get; set; }

    /// <summary>
    /// Gets or sets the building name of the address.
    /// </summary>
    public string? BuildingName { get; set; }

    /// <summary>
    /// Gets or sets the lot number of the address.
    /// </summary>
    public string? LotNumber { get; set; }

    /// <summary>
    /// Gets or sets the unit number of the address.
    /// </summary>
    public string? UnitNumber { get; set; }

    /// <summary>
    /// Gets or sets the postal code of the address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    [MaxLength(255)]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the state of the address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    [MaxLength(255)]
    public string? State { get; set; }

    public int? StateType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the city of the address.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets the country of the address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    [MaxLength(255)]
    public string? Country { get; set; }

    /// <summary>
    /// Gets or sets the Standard & Poor's value identifier from the general lookup.
    /// </summary>
    public int? StandardAndPoor_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the property category type identifier from the general lookup.
    /// </summary>
    public int? PCCategoryType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the location is Metro Plus.
    /// </summary>
    public bool? ISMetroPlus { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the location is high density.
    /// </summary>
    public bool? ISHighDensity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the location is a selected non-metro area.
    /// </summary>
    public bool? ISSelectedNonMetro { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the location is on an island.
    /// </summary>
    public bool? ISAnIsland { get; set; }

    /// <summary>
    /// Gets or sets the latitude of the address.
    /// </summary>
    public double? Latitude { get; set; } // As Client requested to have this field

    /// <summary>
    /// Gets or sets the longitude of the address.
    /// </summary>
    public double? Longitude { get; set; } // As Client requested to have this field

    /// <summary>
    /// Gets or sets the suburb name of the address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    [MaxLength(255)]
    public string? SuburbName { get; set; }

    /// <summary>
    /// Gets or sets the offshore address.
    /// </summary>
    public string? OffshoreAddress { get; set; }

    /// <summary>
    /// Gets or sets the offshore latitude.
    /// </summary>
    public string? OffshoreLatitude { get; set; }

    /// <summary>
    /// Gets or sets the offshore longitude.
    /// </summary>
    public string? OffshoreLongitude { get; set; }

    /// <summary>
    /// Gets or sets the previous residential address.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    public string? PreviousResidentialAddress { get; set; }

    //public string? VisaSubclassRefNumber { get; set; }

    /// <summary>
    /// Gets or sets the PO Box number.
    /// </summary>
    public string? POBoxNumber { get; set; }

    /// <summary>
    /// Gets or sets the overseas PO Box.
    /// </summary>
    public string? OverseasPOBox { get; set; }

    /// <summary>
    /// Gets or sets the overseas longitude.
    /// </summary>
    public string? OverseasLongitude { get; set; }

    /// <summary>
    /// Gets or sets the overseas latitude.
    /// </summary>
    public string? OverseasLatitude { get; set; }

    /// <summary>
    /// Gets or sets the overseas postal code.
    /// </summary>
    public string? OverseasPostCode { get; set; }

    /// <summary>
    /// Gets or sets the overseas state.
    /// </summary>
    public string? OverseasState { get; set; }

    /// <summary>
    /// Gets or sets the full address as a single string.
    /// </summary>
    [TextClass(TextFieldClass.AddressAllowed)]
    public string? FullAddress { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property address has been verified using AddressFinder.
    /// </summary>
    [Comment("This field is used to check if the property address is verified or not")]
    public bool? ISVerifiedByAddressFinder { get; set; }

    /// <summary>
    /// Gets or sets a flag or code indicating if the property was verified by Valocity.
    /// </summary>
    public string? ISPropertyValocityVerified { get; set; }

    /// <summary>
    /// Gets or sets the number of times property details have been checked.
    /// </summary>
    [Comment("this field will contain how many times the Property Details is being checked")]
    public int PropertyDetailsCheckCount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether an email has been sent due to missing property details from Valocity.
    /// </summary>
    [Comment("in case we are keep getting not found from valocity, we will sent email and make this property true")]
    public bool IsEmailSentForMissingPropertyDetails { get; set; }

    /// <summary>
    /// Gets or sets the date and time the property details were last checked (UTC).
    /// </summary>
    public DateTime? PropertyDetailsCheckedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the housing status.
    /// </summary>
    public string? HousingStatus { get; set; }

    /// <summary>
    /// Gets or sets the start date of residence (UTC).
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the end date of residence (UTC).
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? EndDateUtc { get; set; }

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
    /// Gets or sets the URL associated with the address, if any.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets the number of months at this address.
    /// </summary>
    [Comment("How long have you been at this address in month?")]
    public double? MonthsAtAddress { get; set; }

    /// <summary>
    /// Gets or sets the number of years at this address.
    /// </summary>
    [Comment("How long have you been at this address in year?")]
    public double? YearsAtAddress { get; set; }

    /// <summary>
    /// Gets or sets the address status type identifier from the general lookup.
    /// </summary>
    public int? AddressStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the list of associated property details for this address.
    /// </summary>
    public IList<PropertyDetail> PropertyDetails { get; set; } = new List<PropertyDetail>();

    /// <summary>
    /// Gets or sets the related real estate asset entity.
    /// </summary>
    public RealEstateAsset? Address_RealEstateAsset { get; set; }

    /// <summary>
    /// Gets or sets the related employer detail entity.
    /// </summary>
    public EmployerDetail? Address_EmployerDetail { get; set; }

    /// <summary>
    /// Gets or sets the related applicant entity.
    /// </summary>
    public Applicant? Address_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the related feedback and indication entity.
    /// </summary>
    public FeedbackAndIndication? Address_FeedbackAndIndication { get; set; }

    /// <summary>
    /// Gets or sets the related loan security entity.
    /// </summary>
    public LoanSecurity? Address_LoanSecurity { get; set; }

    /// <summary>
    /// Gets or sets the related cash out entity.
    /// </summary>
    public Cashout? Address_Cashout { get; set; }

    /// <summary>
    /// Gets or sets the related lead entity.
    /// </summary>
    public Lead? Address_Lead { get; set; }

    /// <summary>
    /// Gets or sets the related relocation entity.
    /// </summary>
    public Relocation? Address_Relocation { get; set; }

    /// <summary>
    /// Gets or sets the related purchase entity.
    /// </summary>
    public Purchase? Address_Purchase { get; set; }

    /// <summary>
    /// Gets or sets the related Trust entity.
    /// </summary>
    public Trust? Address_Trust { get; set; }

    /// <summary>
    /// Gets or sets the related Company entity.
    /// </summary>
    public CompanyApplicant? Address_CompanyApplicant { get; set; }

    public int? AddressType_CoreDB_GeneralLookUpID { get; set; } // Address type (e.g., 'Home', 'Work')

    public int? AddressStatus_CoreDB_GeneralLookUpID { get; set; } // E.g., 'Current', 'Permanent', 'Temporary', 'Previous'

    public int? Address_UserID { get; set; }

    public int? Address_BusinessDetailID { get; set; }

    public int? Address_BusinessUnitID { get; set; }

    public int? Address_OrganizationID { get; set; }

    public int? Address_RefereeID { get; set; }

    public int? Address_BranchEnquiryID { get; set; }

    [TextClass(TextFieldClass.Ignored)]
    public string? StreetAddress { get; set; } // Street address or name

    [TextClass(TextFieldClass.Ignored)]
    public string? Suburb { get; set; }

    public bool ISAddressValidated { get; set; } // Whether the address is validated

    public bool ISPrimary { get; set; } // Whether this address is the primary address

    public string? AddressNotes { get; set; } // Additional notes about the address

    public string? LastUpdatedBy { get; set; } // Who last updated the address

    public bool ISVerified { get; set; } // Whether the address has been verified

    [TextClass(TextFieldClass.Ignored)]
    public string? VerifiedBy { get; set; }

    public DateTime? VerifiedAt { get; set; } // Date of address verification

    public User? Address_User { get; set; }

    public BusinessDetail? Address_BusinessDetail { get; set; }

    public BusinessUnit? Address_BusinessUnit { get; set; }

    public Organization? Address_Organization { get; set; }

    public Referee? Address_Referee { get; set; }
}
