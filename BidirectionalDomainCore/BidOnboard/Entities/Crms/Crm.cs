namespace Bidirectional.DomainCore.BidOnboard.Entities.Crms;

/// <summary>
/// Represents a Customer Relationship Management (CRM) entity with related metadata.
/// </summary>
public class Crm
{
    /// <summary>
    /// Gets or sets the unique identifier for the CRM entity.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the CRM.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the display name of the application for the CRM.
    /// </summary>
    public string? AppDisplayName { get; set; }

    /// <summary>
    /// Gets or sets the client identifier associated with the CRM.
    /// </summary>
    public string? ClientId { get; set; }

    /// <summary>
    /// Gets or sets an optional description for the CRM.
    /// </summary>
    public string? Description { get; set; }
}
