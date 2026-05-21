namespace Bidirectional.DomainCore.BidOnboard.Permission;

/// <summary>
/// Represents a functional module within the system, supporting hierarchical relationships, permissions, and related metadata.
/// </summary>
public class Module : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the parent module, if any.
    /// </summary>
    public int? Module_ParentID { get; set; }

    /// <summary>
    /// Gets or sets the name of the module.
    /// </summary>
    public string? ModuleName { get; set; }

    /// <summary>
    /// Gets or sets the collection of permissions associated with this module.
    /// </summary>
    public List<Permission> Permissions { get; set; } = [];

    /// <summary>
    /// Gets or sets the mapping list between modules and permissions.
    /// </summary>
    public List<ModulesPermissionsMapper> Mappings { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of scopes defined for the module.
    /// </summary>
    public List<ModuleScope> Scopes { get; set; } = [];

    /// <summary>
    /// Gets or sets the parent module object, if any.
    /// </summary>
    public Module? Module_Parent { get; set; }

    /// <summary>
    /// Gets or sets the list of child modules.
    /// </summary>
    public List<Module> Children { get; set; } = [];
}
