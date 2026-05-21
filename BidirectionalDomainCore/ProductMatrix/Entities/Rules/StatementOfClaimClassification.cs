namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details for a statement of claim, including loan type and issuance status.
/// </summary>
public class StatementOfClaimClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID for the loan type from the core database general lookup table.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a statement of claim has been issued.
    /// </summary>
    public bool ISStatementOfClaimIssued { get; set; }
}
