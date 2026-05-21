namespace Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;

/// <summary>
/// In-app notification row created by the rule-based engine for a specific user. Separate from the legacy <c>Notifications</c> entity.
/// </summary>
public class UserNotification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the recipient user identifier.
    /// </summary>
    public int UserID { get; set; }

    /// <summary>
    /// Gets or sets the recipient user navigation property.
    /// </summary>
    public User? User { get; set; }

    /// <summary>
    /// Gets or sets the optional event code for filtering and analytics.
    /// </summary>
    public string? EventCode { get; set; }

    /// <summary>
    /// Gets or sets the title shown in the notification centre.
    /// </summary>
    [TextClass(TextFieldClass.FreeTextNarrative)]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the message body shown in the notification centre.
    /// </summary>
    [TextClass(TextFieldClass.FreeTextNarrative)]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the user has read the notification.
    /// </summary>
    public bool ISRead { get; set; }
}
