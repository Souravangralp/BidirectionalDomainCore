namespace Bidirectional.DomainCore.BidOnboard.Enums;

/// <summary>
/// Specifies the different notification recipient options within the application.
/// </summary>
public enum NotificationSetting
{
    /// <summary>
    /// Send notifications to the user themselves.
    /// </summary>
    Self = 1,

    /// <summary>
    /// Send notifications to users belonging to the same entity.
    /// </summary>
    SameEntity = 2,

    /// <summary>
    /// Send notifications to users belonging to the parent entity.
    /// </summary>
    ParentEntity = 3,
}
