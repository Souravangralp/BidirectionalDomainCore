namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents an application version record with optional entity name and state for change tracking.
/// </summary>
public class ApplicationVersion : BaseAuditableEntity
{
    /// <summary>Gets or sets the version name.</summary>
    public required string VersionName { get; set; }

    /// <summary>Gets or sets the optional entity name.</summary>
    public string? EntityName { get; set; }

    /// <summary>Gets or sets the optional entity state.</summary>
    public string? EntityState { get; set; }

    /// <summary>Gets or sets the change version time.</summary>
    public DateTime ChangeVersionTime { get; set; }
}
