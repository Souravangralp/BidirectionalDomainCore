namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a general look-up entry with type and value.
/// </summary>
public class GeneralLookUp : BaseAuditableEntity
{
    /// <summary>Gets or sets the look-up type.</summary>
    public required string Type { get; set; }

    /// <summary>Gets or sets the look-up value.</summary>
    public required string Value { get; set; }
}
