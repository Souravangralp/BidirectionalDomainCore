namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a contact person associated with a loan application, including personal, identification, and role-related information.
/// </summary>
public class ContactPerson : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the related contact.
    /// </summary>
    public int? ContactPerson_ContactID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the name title type.
    /// </summary>
    public int? NameTitleType_GeneralLookUpID { get; set; } // we will get this from general lookup

    /// <summary>
    /// Gets or sets the general lookup ID for an alternative name title type.
    /// </summary>
    public int? OtherNameTitleType_GeneralLookUpID { get; set; } // we will get this from general lookup //Discussion to remove other in this field

    /// <summary>
    /// Gets or sets the first name or Christian name of the contact person.
    /// </summary>
    public string? FirstNameORChristianName { get; set; }

    /// <summary>
    /// Gets or sets the middle name of the contact person.
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or sets an alternative first name or Christian name.
    /// </summary>
    public string? OtherFirstNameORChristianName { get; set; }  //Discussion to remove other in this field

    /// <summary>
    /// Gets or sets an alternative last name, surname, or family name.
    /// </summary>
    public string? OtherLastNameORSurnameORFamilyName { get; set; }  //Discussion to remove other in this field

    /// <summary>
    /// Gets or sets the last name, surname, or family name of the contact person.
    /// </summary>
    public string? LastNameORSurnameORFamilyName { get; set; }

    /// <summary>
    /// Gets or sets the middle portion of the first name, if applicable.
    /// </summary>
    public string? MiddleFirstName { get; set; }

    /// <summary>
    /// Gets or sets the middle portion of the last name, if applicable.
    /// </summary>
    public string? MiddleLastName { get; set; }

    /// <summary>
    /// Gets or sets the preferred name or nickname of the contact person.
    /// </summary>
    public string? KnownAsORPreferredNameORNickName { get; set; }

    /// <summary>
    /// Gets or sets the role description of the contact person.
    /// </summary>
    public string? Role { get; set; }

    /// <summary>
    /// Gets or sets the previous name of the contact person, if any.
    /// </summary>
    public string? PreviousContactName { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets a second extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets a third extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the contact person.
    /// </summary>
    public string? ContactPersonUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the contact entity associated with the contact person.
    /// </summary>
    public Contact? ContactPerson_Contact { get; set; }
}
