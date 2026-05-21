namespace Bidirectional.DomainCore.BidOnboard.Enums;

/// <summary>
/// Represents the status of a reference requested for a representative, indicating whether it is pending, approved, or rejected.
/// </summary>
public enum RepresentativeReferenceStatus
{
    /// <summary>
    /// The reference is awaiting review or action.
    /// </summary>
    Pending = 1,

    /// <summary>
    /// The reference has been approved.
    /// </summary>
    Approved = 2,

    /// <summary>
    /// The reference has been rejected.
    /// </summary>
    Rejected = 3,
}
