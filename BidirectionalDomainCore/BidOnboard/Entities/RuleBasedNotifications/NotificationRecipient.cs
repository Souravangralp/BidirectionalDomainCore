namespace Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;

/// <summary>
/// One recipient policy row under a <see cref="NotificationConfiguration"/> (who should be notified and how that user is resolved).
/// </summary>
/// <remarks>
/// <para>
/// For organisation hierarchy (root organisation → child organisations → business units → users), add one row per tier you need.
/// For hierarchy-scoped <strong>groups</strong> (<see cref="Enums.RuleBasedNotifications.NotificationRecipientType.BusinessUnitScopedGroup"/>,
/// <see cref="Enums.RuleBasedNotifications.NotificationRecipientType.OwningOrganizationScopedGroup"/>,
/// <see cref="Enums.RuleBasedNotifications.NotificationRecipientType.RootOrganizationScopedGroup"/>), set <see cref="UserGroupID"/> to whichever
/// <see cref="UserGroup"/> the admin chose (for example, a “managers” group, a “credit” group, or any other); the rule engine resolves members at runtime by intersecting group membership with the correct BU or organisation scope from trusted context.
/// </para>
/// <para>
/// Resolution must use domain data only (for example <see cref="Organization.ParentOrganizationID"/>,
/// <see cref="Branches.BusinessUnit.BusinessUnit_OrganizationID"/>), not ad hoc organisation or business unit identifiers from the client.
/// </para>
/// </remarks>
public class NotificationRecipient : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the parent configuration.
    /// </summary>
    public int NotificationConfigurationID { get; set; }

    /// <summary>
    /// Gets or sets the parent configuration.
    /// </summary>
    public NotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>
    /// Gets or sets how the engine resolves this row to concrete users.
    /// </summary>
    public NotificationRecipientType RecipientType { get; set; }

    /// <summary>
    /// Gets or sets the user group when <see cref="RecipientType"/> is <see cref="NotificationRecipientType.Group"/>,
    /// or the group whose members are filtered by hierarchy when <see cref="RecipientType"/> is
    /// <see cref="NotificationRecipientType.BusinessUnitScopedGroup"/>, <see cref="NotificationRecipientType.OwningOrganizationScopedGroup"/>,
    /// or <see cref="NotificationRecipientType.RootOrganizationScopedGroup"/> (required for those types).
    /// </summary>
    public int? UserGroupID { get; set; }

    /// <summary>
    /// Gets or sets the user group navigation when <see cref="UserGroupID"/> is set.
    /// </summary>
    public UserGroup? UserGroup { get; set; }

    /// <summary>
    /// Gets or sets the user when <see cref="RecipientType"/> is <see cref="NotificationRecipientType.SpecificUser"/>.
    /// </summary>
    public int? UserID { get; set; }

    /// <summary>
    /// Gets or sets the user navigation when <see cref="UserID"/> is set.
    /// </summary>
    public User? User { get; set; }
}
