namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a base numeric value used as an input into fee calculations.
/// </summary>
public class BaseValue : BaseAuditableEntity
{
    /// <summary>Gets or sets the value.</summary>
    public double Value { get; set; }

    /// <summary>Gets or sets the optional fee name.</summary>
    public string? FeeName { get; set; }

    /// <summary>Gets or sets the value unit.</summary>
    public ValueUnit ValueUnit { get; set; }

    /// <summary>Gets or sets the optional immutable name.</summary>
    public string? ImmutableName { get; set; }
}
