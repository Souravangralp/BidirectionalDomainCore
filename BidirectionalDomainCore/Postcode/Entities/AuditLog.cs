namespace Bidirectional.DomainCore.Postcode.Entities;

/// <summary>
/// Represents an audit log entry that captures details about changes made to entities in the application, 
/// including who performed the action, what was changed, and associated metadata.
/// </summary>
public class AuditLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the table where the audited action occurred.
    /// </summary>
    public string? TableName { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who performed the action.
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// Gets or sets the name of the user who performed the action.
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// Gets or sets the type of the user who performed the action.
    /// </summary>
    public string? UserType { get; set; }

    /// <summary>
    /// Gets or sets the action performed, such as Create, Update, or Delete.
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// Gets or sets the IP address from which the action was performed.
    /// </summary>
    public string? IPAddress { get; set; }

    /// <summary>
    /// Gets or sets the key values identifying the entity affected by the action.
    /// </summary>
    public string? KeyValues { get; set; }

    /// <summary>
    /// Gets or sets the detailed information for the audit log entry.
    /// </summary>
    public AuditLogDetail? AuditLogDetails { get; set; }
}
