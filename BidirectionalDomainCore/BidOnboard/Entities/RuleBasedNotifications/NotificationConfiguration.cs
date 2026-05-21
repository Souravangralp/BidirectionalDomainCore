namespace Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;

/// <summary>
/// Admin-defined rule for which channels to use when a <see cref="NotificationEvent"/> fires, and which recipient rows apply.
/// </summary>
public class NotificationConfiguration : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the <see cref="NotificationEvent"/> that triggers this configuration.
    /// </summary>
    public int NotificationEventID { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for the trigger event.
    /// </summary>
    public NotificationEvent? NotificationEvent { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether email dispatch is enabled for this configuration.
    /// </summary>
    public bool EmailEnabled { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether in-app (and SignalR) dispatch is enabled for this configuration.
    /// </summary>
    public bool InAppEnabled { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether SMS dispatch is enabled for this configuration.
    /// </summary>
    public bool SMSEnabled { get; set; }

    /// <summary>
    /// Gets or sets the recipient rows for this configuration.
    /// </summary>
    public ICollection<NotificationRecipient> NotificationRecipients { get; set; } = [];
}
