namespace Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;

/// <summary>
/// Catalogue entry for a workflow notification trigger (stable <see cref="EventCode"/> and display name).
/// This is separate from the legacy in-app <c>Notifications</c> feature.
/// </summary>
public class NotificationEvent : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the stable machine code for the trigger (for example, LOAN_SUBMITTED).
    /// </summary>
    public string EventCode { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the human-readable name shown in admin screens.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the rule configurations that react to this event.
    /// </summary>
    public ICollection<NotificationConfiguration> NotificationConfigurations { get; set; } = [];

    /// <summary>
    /// Gets or sets the templates associated with this event.
    /// </summary>
    public ICollection<NotificationTemplate> NotificationTemplates { get; set; } = [];
}
