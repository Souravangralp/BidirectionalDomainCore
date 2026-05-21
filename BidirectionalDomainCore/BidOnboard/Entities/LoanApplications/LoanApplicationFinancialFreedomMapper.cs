namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a mapping entity between a loan application and its associated financial freedom lookup information.
/// </summary>
public class LoanApplicationFinancialFreedomMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan application.
    /// </summary>
    public int? LoanApplicationFinancialFreedomMapper_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related CoreDB general lookup entry.
    /// </summary>
    public int? LoanApplicationFinancialFreedomMapper_GeneralLookUpID { get; set; }
}
