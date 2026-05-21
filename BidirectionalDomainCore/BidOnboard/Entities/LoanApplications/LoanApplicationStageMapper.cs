namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a mapping entity between a loan application and its associated stage, 
/// including tracking of stage start and end times and completion status.
/// </summary>
public class LoanApplicationStageMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan application.
    /// </summary>
    public int? LoanApplicationStageMapper_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related loan application stage.
    /// </summary>
    public int? LoanApplicationStageMapper_LoanApplicationStageID { get; set; }

    /// <summary>
    /// Gets or sets the UTC start date and time for when the stage began.
    /// </summary>
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC end date and time for when the stage ended.
    /// </summary>
    public DateTime? EndDateUtc { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this stage has been marked as completed.
    /// </summary>
    public bool ISCompleted { get; set; }
}
