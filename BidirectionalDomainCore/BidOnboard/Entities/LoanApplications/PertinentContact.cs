namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a pertinent contact associated with a loan application, including both primary and secondary contact details.
/// </summary>
public class PertinentContact : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the loan application this contact is linked to.
    /// </summary>
    [Comment("We Are not sure about this class how will this be link to loan application ")]
    public int? PertinentContact_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the contact type identifier from the general lookup table.
    /// </summary>
    [Comment("We will be getting this from general lookUp table.")]
    public int? PertinentContactType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the name of the primary contact person.
    /// </summary>
    public string? PrimaryContact { get; set; }

    /// <summary>
    /// Gets or sets the relationship of the primary contact person.
    /// </summary>
    public string? PrimaryRelationship { get; set; }

    /// <summary>
    /// Gets or sets the mobile number of the primary contact person.
    /// </summary>
    public string? PrimaryMobileNumber { get; set; }

    /// <summary>
    /// Gets or sets the email address of the primary contact person.
    /// </summary>
    public string? PrimaryEmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the name of the secondary contact person.
    /// </summary>
    public string? SecondaryContact { get; set; }

    /// <summary>
    /// Gets or sets the relationship of the secondary contact person.
    /// </summary>
    public string? SecondaryRelationship { get; set; }

    /// <summary>
    /// Gets or sets the mobile number of the secondary contact person.
    /// </summary>
    public string? SecondaryMobileNumber { get; set; }

    /// <summary>
    /// Gets or sets the email address of the secondary contact person.
    /// </summary>
    public string? SecondaryEmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the business address associated with the contact.
    /// </summary>
    public string? BusinessAddress { get; set; }

    /// <summary>
    /// Gets or sets the loan application entity associated with this contact.
    /// </summary>
    public LoanApplication? PertinentContact_LoanApplication { get; set; }
}
