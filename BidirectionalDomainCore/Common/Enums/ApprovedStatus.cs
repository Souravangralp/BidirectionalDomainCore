namespace Bidirectional.DomainCore.Common.Enums;

/// <summary>
/// Specifies the approval status options for entities or processes, including all, pending, approved, and rejected states.
/// </summary>
public enum ApprovedStatus
{
    /// <summary>
    /// Represents all possible approval statuses.
    /// </summary>
    All = 0,

    /// <summary>
    /// Indicates that the approval is pending and awaiting action.
    /// </summary>
    Pending = 1,

    /// <summary>
    /// Indicates that the approval has been granted.
    /// </summary>
    Approved = 2,

    /// <summary>
    /// Indicates that the approval has been rejected.
    /// </summary>
    Rejected = 3
}
