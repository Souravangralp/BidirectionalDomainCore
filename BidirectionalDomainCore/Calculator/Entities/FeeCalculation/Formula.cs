using TextFieldClass = Bidirectional.DomainCore.Common.Enums.TextFieldClass;

namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a formula expression used to calculate fees.
/// </summary>
public class Formula : BaseAuditableEntity
{
    /// <summary>Gets or sets the formula expression value.</summary>
    [TextClass(TextFieldClass.FormulaExpression)]
    public string Value { get; set; } = string.Empty;
}
