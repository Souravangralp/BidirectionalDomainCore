namespace Bidirectional.DomainCore.BidOnboard.Entities.Modules;

/// <summary>
/// Represents a user module within the application, including its hierarchy, name, and active status.
/// </summary>
public class UserModule : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the parent module ID, indicating the hierarchical parent of this module.
    /// </summary>
    public int? ParentModuleID { get; set; }

    /// <summary>
    /// Gets or sets the name of the module.
    /// </summary>
    public string? Name { get; set; }
}
