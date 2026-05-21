using Bidirectional.DomainCore.BidOnboard.Entities.Modules;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Represents an audit log entry capturing user actions and related metadata for auditing purposes.
/// </summary>
public class AuditLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the table affected by the audited action.
    /// </summary>
    public string? AffectedTableName { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who performed the action.
    /// </summary>
    public string? UserID { get; set; }

    /// <summary>
    /// Gets or sets the type identifier of the user.
    /// </summary>
    public string? UserTypeID { get; set; }

    /// <summary>
    /// Gets or sets the type of action performed.
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the module related to the audit log.
    /// </summary>
    public int? AuditLog_ModuleID { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the user who performed the action.
    /// </summary>
    public string? UserIPAddress { get; set; }

    /// <summary>
    /// Gets or sets the changed key values in the audited action.
    /// </summary>
    public string? ChangedKeyValues { get; set; }

    /// <summary>
    /// Gets or sets the previous values before the action was performed.
    /// </summary>
    public string? PreviousValues { get; set; }

    /// <summary>
    /// Gets or sets the current values after the action was performed.
    /// </summary>
    public string? CurrentValues { get; set; }

    /// <summary>
    /// Gets or sets the URL that was accessed during the audit event.
    /// </summary>
    public string? AccessedUrl { get; set; }

    /// <summary>
    /// Gets or sets information about the user's browser.
    /// </summary>
    public string? BrowserInfo { get; set; }

    public string? OrganizationID { get; set; }

    public string? BranchID { get; set; }

    /// <summary>
    /// Gets or sets the module entity associated with the audit log.
    /// </summary>
    public UserModule? AuditLog_Module { get; set; }
}
