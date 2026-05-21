using static Bidirectional.DomainCore.Common.Enums.TextFieldClass;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications.BaseRates;

/// <summary>
/// Stores an audit record for loan application fee version changes.
/// </summary>
public class LoanApplicationFeeAudit : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the related loan application fee ID.
    /// </summary>
    public int LoanApplicationFeeAudit_LoanApplicationFeeID { get; set; }

    /// <summary>
    /// Gets or sets the name of the updated field.
    /// </summary>
    [TextClass(Ignored)]
    public string UpdatedField { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the previous value.
    /// </summary>
    [TextClass(Ignored)]
    public string? OldValue { get; set; }

    /// <summary>
    /// Gets or sets the new value.
    /// </summary>
    [TextClass(Ignored)]
    public string? NewValue { get; set; }

    /// <summary>
    /// Gets or sets how the change was performed.
    /// </summary>
    [TextClass(Ignored)]
    public string UpdatedByMethod { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the related loan application fee.
    /// </summary>
    public LoanApplicationFee? LoanApplicationFeeAudit_LoanApplicationFee { get; set; }
}
