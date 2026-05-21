namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of a button type, including related loan, occupancy, and lookup identifiers.
/// </summary>
public class ButtonTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the loan type lookup identifier from the CoreDB General Lookup table.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the occupancy type lookup identifier from the CoreDB General Lookup table.
    /// </summary>
    public int? OccupancyType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the button type lookup identifier from the CoreDB General Lookup table.
    /// </summary>
    public int? ButtonType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points assigned to this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
