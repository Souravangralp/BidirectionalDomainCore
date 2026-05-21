namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of a title type, including loan type and related metadata for rule-based processing.
/// </summary>
public class TitleTypeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the loan type from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the title type from the CoreDB general lookup.
    /// </summary>
    public int? TitleType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with this title type classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
