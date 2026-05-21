namespace Bidirectional.DomainCore.BidOnboard.Permission;

/// <summary>
/// Represents the default access policy assigned to a user group within the system.
/// </summary>
public class DefaultEntityAccessPolicy : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated entity access policy.
    /// </summary>
    public int? DefaultEntityAccessPolicy_EntityAccessPolicyID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the user group to which this policy applies.
    /// </summary>
    public int? DefaultEntityAccessPolicy_UserGroupID { get; set; }

    /// <summary>
    /// Gets or sets the user group associated with this default entity access policy.
    /// </summary>
    public UserGroup? DefaultEntityAccessPolicy_UserGroup { get; set; }

    /// <summary>
    /// Gets or sets the entity access policy associated with this default entity access policy.
    /// </summary>
    public EntityAccessPolicy? DefaultEntityAccessPolicy_EntityAccessPolicy { get; set; }
}
