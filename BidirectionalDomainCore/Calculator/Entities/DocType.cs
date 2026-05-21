namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a document type entity (e.g. Full Doc, Alt Doc).
/// </summary>
public class DocType : BaseAuditableEntity
{
    /// <summary>Gets or sets the document type name.</summary>
    public required string Name { get; set; }
}
