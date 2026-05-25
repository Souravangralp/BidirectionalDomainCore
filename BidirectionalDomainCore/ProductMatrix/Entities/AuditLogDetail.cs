namespace Bidirectional.DomainCore.ProductMatrix.Entities;

/// <summary>
/// Represents the detailed information of an audit log entry, including property changes and their old and new values.
/// </summary>
public class AuditLogDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the associated audit log entry's identifier.
    /// </summary>
    public int? AuditLogDetail_AuditLogID { get; set; }

    /// <summary>
    /// Gets or sets the value before the change occurred, as JSON payload.
    /// </summary>
    [TextClass(TextFieldClass.JsonPayload)]
    public string? OldValue { get; set; }

    /// <summary>
    /// Gets or sets the value after the change occurred, as JSON payload.
    /// </summary>
    [TextClass(TextFieldClass.JsonPayload)]
    public string? NewValue { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the associated audit log entry.
    /// </summary>
    public AuditLog? AuditLogDetail_AuditLog { get; set; }
}
