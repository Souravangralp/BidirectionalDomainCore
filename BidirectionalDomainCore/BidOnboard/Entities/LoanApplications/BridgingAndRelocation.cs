namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a bridging and relocation loan application, including details related to loan servicing and completion types.
/// </summary>
public class BridgingAndRelocation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the bridging completion type from the GeneralLookUp table.
    /// </summary>
    public int? BridgingCompleteType_GeneralLookUpID { get; set; } // We will get this from the GeneralLookUp table

    /// <summary>
    /// Gets or sets a value indicating whether the loan is serviced at peak debt.
    /// </summary>
    public bool ISServicingAtPeakDebt { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is serviced at end debt only.
    /// </summary>
    public bool ISServicingAtEndDebtOnly { get; set; }
}
