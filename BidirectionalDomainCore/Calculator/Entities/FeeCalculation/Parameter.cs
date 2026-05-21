namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a named parameter that can be used within fee formulas.
/// </summary>
public class Parameter : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional base value ID.</summary>
    public int? Parameter_BaseValueID { get; set; }

    /// <summary>Gets or sets the parameter name.</summary>
    public string ParameterName { get; set; } = string.Empty;

    /// <summary>Gets or sets the optional base value.</summary>
    public BaseValue? Parameter_BaseValue { get; set; }

    /// <summary>Gets or sets the optional formula parameter mapper.</summary>
    public FormulaParameterMapper? Parameter_FormulaParameterMapper { get; set; }
}
