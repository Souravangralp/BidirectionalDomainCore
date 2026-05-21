using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Permission;

/// <summary>
/// Represents the default permission configuration for an entity, including associations to user groups, organizations, business units, permissions, and modules.
/// </summary>
public class DefaultPermission : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the user group associated with the default permission.
    /// </summary>
    public int? DefaultPermission_UserGroupID { get; set; }

    /// <summary>
    /// Gets or sets the type of entity to which the default permission applies.
    /// </summary>
    public DomainEntityTypes EntityType { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the organization associated with the default permission.
    /// </summary>
    public int? DefaultPermission_OrganizationID { get; set; } // In this company will assign default permission to branches and users

    /// <summary>
    /// Gets or sets the identifier of the business unit associated with the default permission.
    /// </summary>
    public int? DefaultPermission_BusinessUnitID { get; set; } // In this branch will assign default permission to users

    /// <summary>
    /// Gets or sets the identifier of the permission associated with the default permission.
    /// </summary>
    public int? DefaultPermission_PermissionID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the module associated with the default permission.
    /// </summary>
    public int? DefaultPermission_ModuleID { get; set; }

    /// <summary>
    /// Gets or sets the permission linked to the default permission record.
    /// </summary>
    public Permission? DefaultPermission_Permission { get; set; }

    /// <summary>
    /// Gets or sets the module linked to the default permission record.
    /// </summary>
    public Module? DefaultPermission_Module { get; set; }

    /// <summary>
    /// Gets or sets the organization linked to the default permission record.
    /// </summary>
    public Organization? DefaultPermission_Organization { get; set; }

    /// <summary>
    /// Gets or sets the business unit linked to the default permission record.
    /// </summary>
    public BusinessUnit? DefaultPermission_BusinessUnit { get; set; }

    /// <summary>
    /// Gets or sets the user group linked to the default permission record.
    /// </summary>
    public UserGroup? DefaultPermission_UserGroup { get; set; }
}
