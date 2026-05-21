namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details of a borrowing entity, 
/// including entity type, loan type, and heedful points.
/// </summary>
public class BorrowingEntityClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the borrowing entity type from the core database.
    /// </summary>
    public int? BorrowingEntityType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points assigned to the borrowing entity.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
