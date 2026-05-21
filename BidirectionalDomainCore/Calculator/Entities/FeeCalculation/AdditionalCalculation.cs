namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents an additional fee calculation that links a fee detail to a specific formula.
/// </summary>
public class AdditionalCalculation : BaseAuditableEntity
{
    /// <summary>Gets or sets the fee detail ID.</summary>
    public int AdditionalCalculation_FeeDetailID { get; set; }

    /// <summary>Gets or sets the formula ID.</summary>
    public int AdditionalCalculation_FormulaID { get; set; }

    /// <summary>Gets or sets the optional formula.</summary>
    public Formula? AdditionalCalculation_Formula { get; set; }

    /// <summary>Gets or sets the optional fee detail.</summary>
    public FeeDetail? AdditionalCalculation_FeeDetail { get; set; }
}
