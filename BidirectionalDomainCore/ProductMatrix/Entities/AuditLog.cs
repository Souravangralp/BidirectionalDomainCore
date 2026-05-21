namespace Bidirectional.DomainCore.ProductMatrix.Entities;

/// <summary>
/// Represents an audit log entry that records user actions, changes, and related metadata for auditing purposes.
/// </summary>
public class AuditLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the table involved in the audited action.
    /// </summary>
    public string? TableName { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the user who performed the action.
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
    /// Gets or sets the type of action performed (e.g., Create, Update, Delete).
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// Gets or sets the IP address from which the action was performed.
    /// </summary>
    public string? IPAddress { get; set; }

    /// <summary>
    /// Gets or sets the key values associated with the audited entity.
    /// </summary>
    public string? KeyValues { get; set; }

    /// <summary>
    /// Gets or sets the detailed information about the audited action.
    /// </summary>
    public AuditLogDetail? AuditLogDetails { get; set; }
}
