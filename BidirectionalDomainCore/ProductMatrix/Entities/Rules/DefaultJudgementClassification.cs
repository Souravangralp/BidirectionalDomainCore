namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the default judgement classification for a loan, including lookup and judgement status information.
/// </summary>
public class DefaultJudgementClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID of the loan type from the CoreDB.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is a default judgement.
    /// </summary>
    public bool ISDefaultJudgement { get; set; }
}
