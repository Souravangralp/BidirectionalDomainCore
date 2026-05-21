namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the next of kin details associated with a loan application.
/// </summary>
public class NextOfKin : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the applicant who is the next of kin.
    /// </summary>
    public int? NextOfKin_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the relationship of the next of kin to the applicant.
    /// </summary>
    public string? KinRelationship { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the name title type of the next of kin.
    /// </summary>
    public int? NameTitleType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the first name or Christian name of the next of kin.
    /// </summary>
    public string? FirstNameORChristianName { get; set; }

    /// <summary>
    /// Gets or sets the middle name of the next of kin.
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or sets the middle first name of the next of kin as requested by the client.
    /// </summary>
    public string? MiddleFirstName { get; set; }

    /// <summary>
    /// Gets or sets the middle last name of the next of kin as requested by the client.
    /// </summary>
    public string? MiddleLastName { get; set; }

    /// <summary>
    /// Gets or sets the last name, surname, or family name of the next of kin.
    /// </summary>
    public string? LastNameORSurnameORFamilyName { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for an additional name title type of the next of kin.
    /// </summary>
    public int? OtherNameTitleType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the alternative name or alias the next of kin is known as.
    /// </summary>
    public string? KnownAs { get; set; }

    /// <summary>
    /// Gets or sets the complete address of the next of kin.
    /// </summary>
    public string? CompleteAddress { get; set; }

    /// <summary>
    /// Gets or sets the preferred method of contact for the next of kin.
    /// </summary>
    public string? PreferredContact { get; set; }

    /// <summary>
    /// Gets or sets the mobile number of the next of kin.
    /// </summary>
    public string? MobileNumber { get; set; }

    /// <summary>
    /// Gets or sets the country code of the next of kin's mobile number.
    /// </summary>
    public string? MobileNumberCountryCode { get; set; }

    /// <summary>
    /// Gets or sets the dialing code associated with the next of kin's mobile number.
    /// </summary>
    public string? MobileNumberDialingCode { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional next of kin information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional next of kin information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional next of kin information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the applicant entity associated as the next of kin.
    /// </summary>
    public Applicant? NextOfKin_Applicant { get; set; }
}
