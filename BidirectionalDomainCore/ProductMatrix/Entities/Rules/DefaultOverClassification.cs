namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the default over-classification rules for loan entities, including loan type, payment status, and default time periods.
/// </summary>
public class DefaultOverClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the loan type from the CoreDB general lookup.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the payment status type from the CoreDB general lookup.
    /// </summary>
    public int? PaymentStatusType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the starting range of default time in months.
    /// </summary>
    public double? FromDefaultTimeInMonth { get; set; }

    /// <summary>
    /// Gets or sets the ending range of default time in months.
    /// </summary>
    public double? ToDefaultTimeInMonth { get; set; }
}
