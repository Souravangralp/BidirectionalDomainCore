using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a driver's license entity associated with a loan application, 
/// containing details such as license numbers, issue dates, and related applicant information.
/// </summary>
public class DriverLicense : BaseAuditableEntity
{
    public int? DriverLicense_UserID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated applicant for this driver's license.
    /// </summary>
    public int? DriverLicense_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant holds an Australian driving license.
    /// </summary>
    public bool HASAustralianDrivingLicense { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the state where the license was issued.
    /// </summary>
    public int? StateID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the country where the license was issued.
    /// </summary>
    public int? CountryID { get; set; }

    public int? DriverLicenseStatusType_CoreDB_GeneralLookUpID { get; set; }

    public string? Address { get; set; }

    public string? IssuingState { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? LicenseClass { get; set; } // e.g., C, LR, MR, HR, HC, MC

    public bool ISSuspended { get; set; }

    public string? Endorsements { get; set; } // e.g., restrictions, conditions

    public Applicant? DriverLicense_Applicant { get; set; }

    public User? DriverLicense_User { get; set; }

    #region Remove fields

    /// <summary>
    /// Gets or sets the card number of the driver's license. This field is encrypted.
    /// </summary>
    [EncryptColumn]
    public string? CardNumber { get; set; }

    /// <summary>
    /// Gets or sets the driving license number. This field is encrypted.
    /// </summary>
    [EncryptColumn]
    public string? DrivingLicenseNumber { get; set; }

    /// <summary>
    /// Gets or sets the license verification number. This field is encrypted.
    /// </summary>
    [EncryptColumn]
    public string? LicenseVerificationNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is a digital driver's license.
    /// </summary>
    [Comment("Is Digital Driver's license")]
    public bool ISDigitalDriverLicense { get; set; }

    /// <summary>
    /// Gets or sets the license expiry date. This field is encrypted as per client discussion.
    /// </summary>
    [Comment("This field is Encrypted as per client discussion")]
    public string? LicenseExpiryDate { get; set; }

    /// <summary>
    /// Gets or sets the UTC date and time when the driver's license was issued.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? LicenseIssueDateUtc { get; set; }

    #endregion
}
