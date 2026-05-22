// Ignore Spelling: Auditable Utc

namespace Bidirectional.DomainCore.Common;

/// <summary>
/// Serves as a base class for entities that require audit information, including creation and modification metadata, and soft deletion functionality.
/// </summary>
public abstract class BaseAuditableEntity : BaseEntity, ISoftDelete
{
    /// <summary>
    /// Gets or sets the timestamp when the entity was created (onboarding persistence).
    /// </summary>
    public DateTimeOffset Created { get; set; }

    /// <summary>
    /// Gets or sets the timestamp when the entity was last modified (onboarding persistence).
    /// </summary>
    public DateTimeOffset LastModified { get; set; }

    /// <summary>
    /// Gets or sets the UTC timestamp when the entity was created.
    /// </summary>
    public DateTime? CreatedUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was created in Australian time.
    /// </summary>
    public DateTime CreatedAus { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who created the entity.
    /// </summary>
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the UTC timestamp when the entity was last modified.
    /// </summary>
    public DateTime? LastModifiedUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was last modified in Australian time.
    /// </summary>
    public DateTime? LastModifiedAus { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who last modified the entity.
    /// </summary>
    public string? LastModifiedBy { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity is soft deleted.
    /// </summary>
    public bool ISDeleted { get; set; } = false;

    public bool ISActive { get; set; } = true;

    public string? Description { get; set; }
}
