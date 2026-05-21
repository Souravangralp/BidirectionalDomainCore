using Bidirectional.DomainCore.BidOnboard.Entities.Modules;

namespace Bidirectional.DomainCore.BidOnboard.Entities.UserActivity;

/// <summary>
/// Represents a log record of user activity, capturing user information, device details, event metadata, and context for auditing purposes.
/// </summary>
public class ActivityLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the user performing the activity.
    /// </summary>
    [Comment("User ID")]
    public string? UserID { get; set; }

    /// <summary>
    /// Gets or sets the type or role of the user performing the activity.
    /// </summary>
    [Comment("User Type")]
    public string? UserType { get; set; }

    /// <summary>
    /// Gets or sets the name of the user performing the activity.
    /// </summary>
    [Comment("User Name")]
    public string? UserName { get; set; }

    /// <summary>
    /// Gets or sets the email address of the user performing the activity.
    /// </summary>
    [Comment("User Email")]
    public string? UserEmail { get; set; }

    /// <summary>
    /// Gets or sets the session identifier associated with the user's activity.
    /// </summary>
    [Comment("Session ID")]
    public string? SessionID { get; set; }

    /// <summary>
    /// Gets or sets the type of device used to perform the activity.
    /// </summary>
    [Comment("Which type of device is use")]
    public string? DeviceCategory { get; set; }

    /// <summary>
    /// Gets or sets the browser name used to perform the activity.
    /// </summary>
    [Comment("Which BrowserName is use")]
    public string? BrowserName { get; set; }

    /// <summary>
    /// Gets or sets the category or type of event or action being performed.
    /// </summary>
    [Comment("Which type of action or event is being performed")]
    public string? EventCategory { get; set; }

    /// <summary>
    /// Gets or sets the name of the service involved in the activity.
    /// </summary>
    [Comment("ServiceName")]
    public string? ServiceName { get; set; }

    /// <summary>
    /// Gets or sets the IP address information from which the activity originated.
    /// </summary>
    [Comment("Contains IPAddress information")]
    public string? IPAddress { get; set; }

    /// <summary>
    /// Gets or sets the name of the country from which the request was made.
    /// </summary>
    [Comment("Request is from which CountryName")]
    public string? CountryName { get; set; }

    /// <summary>
    /// Gets or sets the name of the region from which the request was made.
    /// </summary>
    [Comment("Request is from which RegionName")]
    public string? RegionName { get; set; }

    /// <summary>
    /// Gets or sets the name of the city from which the request was made.
    /// </summary>
    [Comment("Request is from which city")]
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets the URL related to the activity.
    /// </summary>
    [Comment("Information regarding Url")]
    public string? Url { get; set; }

    /// <summary>
    /// Gets or sets detailed metadata information related to the event.
    /// </summary>
    [Comment("Descripted meta data information details in it.")]
    public string? EventMetaData { get; set; }

    /// <summary>
    /// Gets or sets the name of the internet service provider used.
    /// </summary>
    [Comment("Internet ServiceName Provider")]
    public string? InternetServiceProvider { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the module where the activity occurred.
    /// </summary>
    [Comment("Current moduleID")]
    public int? ActivityLog_ModuleID { get; set; }

    /// <summary>
    /// Gets or sets the operating system used during the activity.
    /// </summary>
    [Comment("Operating System")]
    public string? OperatingSystemName { get; set; }

    /// <summary>
    /// Gets or sets the version number of the operating system used.
    /// </summary>
    [Comment("Operating System Version")]
    public string? OperatingSystemVersionNumber { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for a loan application, if applicable.
    /// </summary>
    [Comment("Loan Application Unique Id")]
    public string? LoanApplicationUniqueId { get; set; }

    /// <summary>
    /// Gets or sets the number of mouse clicks performed during the activity.
    /// </summary>
    [Comment("Number of Mouse clicks")]
    public int? MouseClickCount { get; set; }

    /// <summary>
    /// Gets or sets the number of keystrokes recorded during the activity.
    /// </summary>
    [Comment("Number of Key press")]
    public int? KeystrokeCount { get; set; }

    /// <summary>
    /// Gets or sets the module entity associated with the activity log.
    /// </summary>
    public UserModule? ActivityLog_Module { get; set; }
}
