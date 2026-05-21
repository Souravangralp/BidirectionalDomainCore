namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents default loan amount parameters, including loan type identification and valid amount range.
/// </summary>
public class DefaultAmount : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID for the loan type in the core database general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the starting value of the loan amount range.
    /// </summary>
    public double? FromLoanAmount { get; set; }

    /// <summary>
    /// Gets or sets the ending value of the loan amount range.
    /// </summary>
    public double? ToLoanAmount { get; set; }
}
