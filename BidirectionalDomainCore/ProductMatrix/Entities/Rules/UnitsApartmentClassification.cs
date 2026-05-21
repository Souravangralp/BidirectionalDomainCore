namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of apartment units based on living area and associated properties for rule evaluations.
/// </summary>
public class UnitsApartmentClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the CoreDB General Lookup ID for the loan type associated with this apartment classification.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum living area (inclusive) for this apartment classification, in square units.
    /// </summary>
    public required double LivingAreaFrom { get; set; }

    /// <summary>
    /// Gets or sets the maximum living area (inclusive) for this apartment classification, in square units.
    /// </summary>
    public required double LivingAreaTo { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points assigned to this apartment classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
