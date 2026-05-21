namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification entity for Heedful Point Types within the rules domain, 
/// containing references to related lookup IDs and their associated heedful points value.
/// </summary>
public class HeedFulPointTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID referencing the loan type in the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID referencing the heedful point type in the core database.
    /// </summary>
    public int? HeedFulPointType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with the classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
