using Bidirectional.DomainCore.BidOnboard.Enums;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a stage within the loan application process, including its order, status, and related approval and notification configurations.
/// </summary>
public class LoanApplicationStage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the loan application process stage.
    /// </summary>
    public LoanApplicationProcessStage StageName { get; set; }

    /// <summary>
    /// Gets or sets the sequential order of this stage within the loan application process.
    /// </summary>
    public int StageOrder { get; set; }

    /// <summary>
    /// Gets or sets the current status associated with this loan application stage.
    /// </summary>
    public LoanApplicationStatus LoanApplicationStatus { get; set; }

    /// <summary>
    /// Gets or sets the collection of approval group mappings for this stage. There may be one or multiple approval groups.
    /// </summary>
    public List<LoanApplicationApproverStageMapper> LoanApplicationApproveStageMappers { get; set; } = [];  //It could be single or multiple approval groups

    /// <summary>
    /// Gets or sets the notification hierarchy configuration specifying which user groups are notified at this stage.
    /// </summary>
    public List<EmailNotificationHierarchyLevelMapper> EmailNotificationHierarchyLevelMapper { get; set; } = [];   //Configurations: which user groups get notified at this stage
}
