namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a condition that determines when a fee applies, based on a type and numeric range.
/// </summary>
public class FeeCondition : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional condition type.</summary>
    public string? Type { get; set; }

    /// <summary>Gets or sets the minimum value.</summary>
    public double Minimum { get; set; }

    /// <summary>Gets or sets the maximum value.</summary>
    public double Maximum { get; set; }

    /// <summary>Gets or sets the optional value.</summary>
    public string? Value { get; set; } = string.Empty;

    /// <summary>Gets or sets a value indicating whether the condition is directly comparable.</summary>
    public bool ISDirectlyComparable { get; set; }
}
