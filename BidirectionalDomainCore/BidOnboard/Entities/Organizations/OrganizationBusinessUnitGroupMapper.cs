using Bidirectional.DomainCore.BidOnboard.Permission;

namespace Bidirectional.DomainCore.BidOnboard.Entities.Organizations;

/// <summary>
/// Represents a mapping between an organization, business unit, and user group,
/// including associated users, permissions, and access policies for a company branch.
/// </summary>
public class OrganizationBusinessUnitGroupMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of this group mapper, referencing the organization.
    /// </summary>
    public int? OrganizationBusinessUnitGroupMapper_OrganizationID { get; set; }

    /// <summary>
    /// Gets or sets the business unit identifier associated with this group mapper.
    /// </summary>
    public int? OrganizationBusinessUnitGroupMapper_BusinessUnitID { get; set; }

    /// <summary>
    /// Gets or sets the ID for the group type in the general lookup table (e.g., internal or external user group).
    /// </summary>
    public int? GroupType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the user group identifier from the general lookup table associated with this group mapper.
    /// </summary>
    public int? OrganizationBusinessUnitGroupMapper_UserGroupID { get; set; }

    /// <summary>
    /// Gets or sets the business unit associated with this group mapper.
    /// </summary>
    public BusinessUnit? OrganizationBusinessUnitGroupMapper_BusinessUnit { get; set; }

    /// <summary>
    /// Gets or sets the organization associated with this group mapper.
    /// </summary>
    public Organization? OrganizationBusinessUnitGroupMapper_Organization { get; set; }

    /// <summary>
    /// Gets or sets the user group associated with this group mapper.
    /// </summary>
    public UserGroup? OrganizationBusinessUnitGroupMapper_UserGroup { get; set; }

    /// <summary>
    /// Gets the collection of users associated with this group within the company branch context.
    /// </summary>
    public ICollection<OrganizationBusinessUnitGroupUserMapper> OrganizationBusinessUnitGroupUserMapper { get; set; } = [];

    /// <summary>
    /// Gets the collection of permissions associated with this group mapper.
    /// </summary>
    public ICollection<ModulesPermissionsMapper> ModulesPermissionsMappers { get; set; } = [];

    /// <summary>
    /// Gets the collection of access policies associated with this group mapper.
    /// </summary>
    public ICollection<EntityAccessPolicyGroupMapper> EntityAccessPolicyGroupMapper { get; set; } = [];
}
