namespace Bidirectional.DomainCore.BidOnboard.Permission;

/// <summary>
/// Represents the scope settings for a module, including its unique identifier, type, and associated module.
/// </summary>
public class ModuleScope : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the module, if available.
    /// </summary>
    public int? ModuleID { get; set; }

    /// <summary>
    /// Gets or sets the type of the scope for the module.
    /// </summary>
    public int ScopeType { get; set; }

    /// <summary>
    /// Gets or sets the associated module entity.
    /// </summary>
    public Module? Module { get; set; }
}
