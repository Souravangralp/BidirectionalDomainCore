namespace Bidirectional.DomainCore.BidOnboard.Entities.UserActivity;

/// <summary>
/// Represents a log entry capturing details about a user's sign-in attempt, including user information, device details, authentication method, and contextual metadata.
/// </summary>
public class UserSignInLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the request associated with the sign-in action.
    /// </summary>
    public string? RequestID { get; set; }

    /// <summary>
    /// Gets or sets the action performed during the sign-in process.
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// Gets or sets the user identifier related to the sign-in event.
    /// </summary>
    public string? User { get; set; }

    /// <summary>
    /// Gets or sets the user name of the individual attempting to sign in.
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// Gets or sets the email address of the user attempting to sign in.
    /// </summary>
    public string? UserEmail { get; set; }

    /// <summary>
    /// Gets or sets the role or roles associated with the user.
    /// </summary>
    public string? Role { get; set; }

    /// <summary>
    /// Gets or sets the type of device used for sign-in, such as mobile, desktop, or tablet.
    /// </summary>
    public string? DeviceType { get; set; }

    /// <summary>
    /// Gets or sets the application or client through which the sign-in was attempted.
    /// </summary>
    public string? Application { get; set; }

    /// <summary>
    /// Gets or sets the status of the sign-in attempt (e.g., Success, Failure).
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the IP address from which the sign-in request originated.
    /// </summary>
    public string? IPAddress { get; set; }

    /// <summary>
    /// Gets or sets the location information (e.g., city, region) at the time of sign-in.
    /// </summary>
    public string? Location { get; set; }

    /// <summary>
    /// Gets or sets the country from where the sign-in was performed.
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Gets or sets the client application details used during sign-in.
    /// </summary>
    public string? ClientApp { get; set; }

    /// <summary>
    /// Gets or sets the operating system of the device used for sign-in.
    /// </summary>
    public string? OperatingSystem { get; set; }

    /// <summary>
    /// Gets or sets the browser used by the device during sign-in.
    /// </summary>
    public string? DeviceBrowser { get; set; }

    /// <summary>
    /// Gets or sets the type of user (e.g., Admin, EndUser) attempting to sign in.
    /// </summary>
    public string? UserType { get; set; }

    /// <summary>
    /// Gets or sets the user agent string from the user's browser or client.
    /// </summary>
    public string? UserAgent { get; set; }

    /// <summary>
    /// Gets or sets the login method used, such as password, OAuth, or SSO.
    /// </summary>
    public string? LoginMethod { get; set; }
}
