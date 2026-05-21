namespace Bidirectional.DomainCore.Common;

/// <summary>
/// Represents the various approval statuses for an entity or process.
/// </summary>
public enum ApprovalStatus
{
    /// <summary>
    /// Indicates that the approval is pending and awaiting review.
    /// </summary>
    Pending = 1,

    /// <summary>
    /// Indicates that the approval has been granted.
    /// </summary>
    Approved = 2,

    /// <summary>
    /// Indicates that the approval has been rejected.
    /// </summary>
    Rejected = 3,

    /// <summary>
    /// Indicates that the approval has been rolled back to a previous state.
    /// </summary>
    RolledBack = 4
}
