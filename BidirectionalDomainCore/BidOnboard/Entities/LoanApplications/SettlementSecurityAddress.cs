namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the address information associated with a settlement security in a loan application.
/// </summary>
public class SettlementSecurityAddress : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated loan application.
    /// </summary>
    public int? SettlementSecurityAddress_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the settlement security address.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the associated <see cref="LoanApplication"/>.
    /// </summary>
    public LoanApplication? SettlementSecurityAddress_LoanApplication { get; set; }
}
