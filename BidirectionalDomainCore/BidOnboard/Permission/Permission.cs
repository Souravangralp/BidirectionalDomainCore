namespace Bidirectional.DomainCore.BidOnboard.Permission;

/// <summary>
/// Represents a permission that defines access rights, menu visibility, and related metadata within the application.
/// </summary>
public class Permission : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated module for this permission.
    /// </summary>
    public int? Permission_ModuleID { get; set; }

    /// <summary>
    /// Gets or sets the name of the permission.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this permission represents a menu item.
    /// </summary>
    public bool ISMenuItem { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this permission should be shown in the menu.
    /// </summary>
    public bool ShowInMenu { get; set; }

    /// <summary>
    /// Gets or sets the menu title displayed in the user interface.
    /// </summary>
    public string? MenuTitle { get; set; }

    /// <summary>
    /// Gets or sets the menu path, such as a URL or route, associated with this permission.
    /// </summary>
    public string? MenuPath { get; set; }

    /// <summary>
    /// Gets or sets the icon associated with this permission.
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Gets or sets the name of the controller related to this permission.
    /// </summary>
    public string? ControllerName { get; set; }

    /// <summary>
    /// Gets or sets the name of the action related to this permission.
    /// </summary>
    public string? ActionName { get; set; }

    /// <summary>
    /// Gets or sets the name of the policy associated with this permission.
    /// </summary>
    public string? PolicyName { get; set; }

    /// <summary>
    /// Gets or sets the associated module entity for this permission.
    /// </summary>
    public Module? Permission_Module { get; set; }

    /// <summary>
    /// Gets or sets the list of mappings to module permissions.
    /// </summary>
    public List<ModulesPermissionsMapper> Mappings { get; set; } = [];
}
