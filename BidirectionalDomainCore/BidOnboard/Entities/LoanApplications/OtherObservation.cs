namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an additional observation related to a specific loan application, including its status or type information.
/// </summary>
public class OtherObservation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated loan application for this observation.
    /// </summary>
    public int OtherObservation_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID indicating the status or type of this observation, if available.
    /// </summary>
    public int? StatusORObservationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the loan application entity associated with this observation.
    /// </summary>
    public LoanApplication? OtherObservation_LoanApplication { get; set; }
}
