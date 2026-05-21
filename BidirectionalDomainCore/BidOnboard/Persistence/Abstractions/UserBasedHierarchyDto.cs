namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Provides a data transfer object for representing user-based hierarchy relationships, 
    /// including entity identification, type information, user group association, and basic user details.
    /// </summary>
    public class UserBasedHierarchyDto
    {
        /// <summary>
        /// Gets or sets the type of entity, such as "BusinessUnit" or "Organization".
        /// </summary>
        public string EntityType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier of the entity (e.g., Business Unit or Organization ID).
        /// </summary>
        public int EntityId { get; set; }

        /// <summary>
        /// Gets or sets the type related to the hierarchy, for example "Lender" or "Branch".
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity within the hierarchy.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the relation type to the hierarchy, specifying whether the entity is the current node or its parent.
        /// Possible values are "Current" or "Parent".
        /// </summary>
        public string ParentOrCurrent { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the identifier for the associated user group, if applicable.
        /// </summary>
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name of the associated user group.
        /// </summary>
        public string? UserGroupName { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the user, if available.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the unique user identifier as defined in the system.
        /// </summary>
        public string? UserUniqueID { get; set; }

        /// <summary>
        /// Gets or sets the full name of the user, typically combining first and last names.
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Gets or sets the email address associated with the user.
        /// </summary>
        public string? Email { get; set; }
    }

}
