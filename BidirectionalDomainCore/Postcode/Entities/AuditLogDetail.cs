namespace Bidirectional.DomainCore.Postcode.Entities;

/// <summary>
/// Represents details of changes captured in an audit log, including previous and new values for tracked changes.
/// </summary>
public class AuditLogDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related audit log.
    /// </summary>
    public int? AuditLogDetail_AuditLogID { get; set; }

    /// <summary>
    /// Gets or sets the value prior to the change.
    /// </summary>
    public string? OldValue { get; set; }

    /// <summary>
    /// Gets or sets the value after the change.
    /// </summary>
    public string? NewValue { get; set; }

    /// <summary>
    /// Gets or sets the associated audit log entity.
    /// </summary>
    public AuditLog? AuditLogDetail_AuditLog { get; set; }
}
