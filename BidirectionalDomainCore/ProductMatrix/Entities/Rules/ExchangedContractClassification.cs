namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details for an exchanged contract, 
/// including loan type, property purchase type, and the applicable month range.
/// </summary>
public class ExchangedContractClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the property purchase type from the core database.
    /// </summary>
    public int? PropertyPurchaseType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the starting month for the classification's validity range.
    /// </summary>
    public double? FromMonth { get; set; }

    /// <summary>
    /// Gets or sets the ending month for the classification's validity range.
    /// </summary>
    public double? ToMonth { get; set; }
}
