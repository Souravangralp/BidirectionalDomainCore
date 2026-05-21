namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents the mapping between a formula and a parameter used within that formula.
/// </summary>
public class FormulaParameterMapper : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional formula ID.</summary>
    public int? FormulaParameterMapper_FormulaID { get; set; }

    /// <summary>Gets or sets the optional formula.</summary>
    public Formula? FormulaParameterMapper_Formula { get; set; }

    /// <summary>Gets or sets the optional parameter ID.</summary>
    public int? FormulaParameterMapper_ParameterID { get; set; }

    /// <summary>Gets or sets the optional parameter.</summary>
    public Parameter? FormulaParameterMapper_Parameter { get; set; }
}
