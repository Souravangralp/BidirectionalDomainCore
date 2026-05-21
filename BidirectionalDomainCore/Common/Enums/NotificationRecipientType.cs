namespace Bidirectional.DomainCore.Common.Enums
{
    /// <summary>
    /// Defines how a notification recipient row is resolved at dispatch time.
    /// Hierarchy-related values (<c>*ScopedGroup</c>) combine <strong>this row's</strong> <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/>
    /// with organisation or business unit context from trusted domain data — the group is configurable (for example, “managers”, “credit admins”, “operations”); the engine only resolves membership and scope.
    /// </summary>
    /// <remarks>
    /// Typical hierarchy: root <see cref="Entities.Companies.Organization"/> (no parent) → child organisations
    /// (<see cref="Entities.Companies.Organization.ParentOrganizationID"/>) → <see cref="Entities.Branches.BusinessUnit"/> under an organisation → users.
    /// </remarks>
    public enum NotificationRecipientType
    {
        /// <summary>
        /// The user who created the subject entity (for example, the loan creator).
        /// </summary>
        Creator = 1,

        /// <summary>
        /// The user currently assigned to the workflow item.
        /// </summary>
        AssignedUser = 2,

        /// <summary>
        /// A fixed user identified by the recipient row's user foreign key.
        /// </summary>
        SpecificUser = 3,

        /// <summary>
        /// All users in the group identified by <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/> (global expansion, no hierarchy filter unless your resolver adds one).
        /// </summary>
        Group = 4,

        /// <summary>
        /// Users who are members of <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/> <strong>and</strong> fall under the <see cref="Entities.Branches.BusinessUnit"/> in dispatch context (for example, the unit linked to the acting user or application). <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/> is required.
        /// </summary>
        BusinessUnitScopedGroup = 5,

        /// <summary>
        /// Users with an administrative role, resolved by the engine (not from client input).
        /// </summary>
        Admin = 6,

        /// <summary>
        /// The previous actor in the workflow (for example, the last person who moved the application).
        /// </summary>
        PreviousActor = 7,

        /// <summary>
        /// Users who are members of <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/> <strong>and</strong> are in scope of the <strong>owning</strong> organisation for the business unit in context
        /// (see <see cref="Entities.Branches.BusinessUnit.BusinessUnit_OrganizationID"/> — often the child organisation under an enterprise root). <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/> is required.
        /// </summary>
        OwningOrganizationScopedGroup = 8,

        /// <summary>
        /// Users who are members of <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/> <strong>and</strong> are in scope of the <strong>root</strong> organisation (walk <see cref="Entities.Companies.Organization.ParentOrganizationID"/> until null). <see cref="Entities.RuleBasedNotifications.NotificationRecipient.UserGroupID"/> is required.
        /// </summary>
        RootOrganizationScopedGroup = 9,
    }

}
