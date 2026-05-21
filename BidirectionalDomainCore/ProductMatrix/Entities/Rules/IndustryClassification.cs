namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the industry classification details, including loan type and industry type lookup references.
/// </summary>
public class IndustryClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the industry type from the core database.
    /// </summary>
    public int? IndustryType_CoreDB_GeneralLookUpID { get; set; }
}
