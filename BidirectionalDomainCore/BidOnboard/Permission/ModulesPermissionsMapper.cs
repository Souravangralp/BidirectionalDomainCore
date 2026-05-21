using Bidirectional.DomainCore.BidOnboard.Entities.Organizations;

namespace Bidirectional.DomainCore.BidOnboard.Permission;

/// <summary>
/// Represents a mapping between modules, permissions, and organization business unit groups,
/// defining which permissions are assigned to which modules within specific organizational units.
/// </summary>
public class ModulesPermissionsMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related organization business unit group mapping.
    /// </summary>
    public int? ModulesPermissionsMapper_OrganizationBusinessUnitGroupMapperID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated permission.
    /// </summary>
    public int? ModulesPermissionsMapper_PermissionID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated module.
    /// </summary>
    public int? ModulesPermissionsMapper_ModuleID { get; set; }

    /// <summary>
    /// Gets or sets the associated permission entity.
    /// </summary>
    public Permission? ModulesPermissionsMapper_Permission { get; set; }

    /// <summary>
    /// Gets or sets the associated module entity.
    /// </summary>
    public Module? ModulesPermissionsMapper_Module { get; set; }

    /// <summary>
    /// Gets or sets the associated organization business unit group mapper entity.
    /// </summary>
    public OrganizationBusinessUnitGroupMapper? ModulesPermissionsMapper_OrganizationBusinessUnitGroupMapper { get; set; }
}
