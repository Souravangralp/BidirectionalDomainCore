using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Represents a user notification with display and metadata properties for in-application messages.
/// </summary>
public class Notification : BaseAuditableEntity
{
    public int Notification_UserID { get; set; }

    public int? Notification_AccreditationProcessID { get; set; }

    public int? ContactType_CoreDB_GeneralLookUpID { get; set; } // General lookup ID for contact type (Teams, SMS, WhatsApp)

    /// <summary>
    /// Gets or sets the title of the notification.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the scenario details associated with the notification, as JSON payload.
    /// </summary>
    [TextClass(TextFieldClass.JsonPayload)]
    public string? Scenario { get; set; }

    /// <summary>
    /// Gets or sets the HTML message content of the notification.
    /// </summary>
    [TextClass(TextFieldClass.HtmlContent)]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the type of notification, such as "Info", "Warning", "Success", or "Error".
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the recipient user.
    /// </summary>
    public string? ReceiverID { get; set; }

    /// <summary>
    /// Gets or sets the name of the recipient user.
    /// </summary>
    public string? ReceiverName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the notification has been read.
    /// </summary>
    public bool ISRead { get; set; }

    /// <summary>
    /// Gets or sets the timestamp when the notification was read.
    /// </summary>
    public DateTime? ReadAt { get; set; }

    /// <summary>
    /// Gets or sets the optional expiration timestamp for the notification.
    /// </summary>
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the URL for actions associated with the notification.
    /// </summary>
    public string? ActionUrl { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the sender, if applicable.
    /// </summary>
    public string? SenderID { get; set; }

    /// <summary>
    /// Gets or sets the name of the sender.
    /// </summary>
    public string? SenderName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the notification is archived (soft archive).
    /// </summary>
    public bool ISArchived { get; set; }

    /// <summary>
    /// Gets or sets the icon name or URL for displaying a visual cue.
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Gets or sets the priority of the notification, such as "Low", "Medium", or "High".
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Gets or sets the group key for grouping similar notifications (e.g., "Invoice", "Reminder").
    /// </summary>
    public string? GroupKey { get; set; }

    public User? Notification_User { get; set; }

    public OnboardingProcess? Notification_AccreditationProcess { get; set; }
}
