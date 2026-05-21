namespace Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;

/// <summary>
/// Content templates for a <see cref="NotificationEvent"/> (subject/body per channel). Merge fields are applied by the rule engine at dispatch time.
/// </summary>
public class NotificationTemplate : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the event this template belongs to.
    /// </summary>
    public int NotificationEventID { get; set; }

    /// <summary>
    /// Gets or sets the event navigation property.
    /// </summary>
    public NotificationEvent? NotificationEvent { get; set; }

    /// <summary>
    /// Gets or sets the event code (denormalised for reporting and queries; must match <see cref="NotificationEvent.EventCode"/>).
    /// </summary>
    public string EventCode { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email or in-app notification subject line (may contain merge tokens).
    /// </summary>
    [TextClass(TextFieldClass.FreeTextNarrative)]
    public string? Subject { get; set; }

    /// <summary>
    /// Gets or sets the email or rich in-app body (may contain merge tokens). Sanitise on render for XSS; stored content is admin-controlled.
    /// </summary>
    [TextClass(TextFieldClass.ImportedText)]
    public string? Body { get; set; }

    /// <summary>
    /// Gets or sets the SMS body when SMS is enabled (plain text; keep short).
    /// </summary>
    [TextClass(TextFieldClass.FreeTextNarrative)]
    public string? SmsBody { get; set; }
}
