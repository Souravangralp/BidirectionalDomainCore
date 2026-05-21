namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the financial declaration of a customer's retirement strategy,
/// including key financial values and references to related entities.
/// </summary>
public class RetirementFinancialDeclaration : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related customer retirement strategy.
    /// </summary>
    public int? RetirementFinancialDeclaration_CustomerRetirementStrategyID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the current amount type from the general lookup in CoreDB.
    /// </summary>
    public int? RetirementStrategyCurrentAmountType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the current value associated with the retirement strategy.
    /// </summary>
    public double? CurrentValue { get; set; }

    /// <summary>
    /// Gets or sets the projected value of the retirement strategy at retirement.
    /// </summary>
    public double? ProjectedValue { get; set; }

    /// <summary>
    /// Gets or sets the expected annual growth rate for the retirement strategy.
    /// </summary>
    public double? AnnualGrowth { get; set; }

    /// <summary>
    /// Gets or sets the related <see cref="CustomerRetirementStrategy"/> entity for this declaration.
    /// </summary>
    public CustomerRetirementStrategy? RetirementFinancialDeclaration_CustomerRetirementStrategy { get; set; }
}
