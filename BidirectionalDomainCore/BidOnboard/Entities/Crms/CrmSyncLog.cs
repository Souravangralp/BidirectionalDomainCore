using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

namespace Bidirectional.DomainCore.BidOnboard.Entities.Crms;

/// <summary>
/// Represents a log entry for CRM synchronization operations, 
/// capturing sync status, errors, timings, and related data.
/// </summary>
public class CrmSyncLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the CRM type associated with this sync log.
    /// </summary>
    public int? CrmType { get; set; }

    /// <summary>
    /// Gets or sets the number of errors encountered during synchronization.
    /// </summary>
    public int? ErrorCount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the data has been authenticated.
    /// </summary>
    public bool ISDataAuthenticated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the data has been sanitized.
    /// </summary>
    public bool ISDataSanitized { get; set; }

    /// <summary>
    /// Gets or sets the status of the synchronization process.
    /// </summary>
    public string? SyncProcessStatus { get; set; }

    /// <summary>
    /// Gets or sets the error message if synchronization failed.
    /// </summary>
    public string? SyncErrorMessage { get; set; }

    /// <summary>
    /// Gets or sets the latitude of the user during synchronization.
    /// </summary>
    public string? SyncLatitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude of the user during synchronization.
    /// </summary>
    public string? SyncLongitude { get; set; }

    /// <summary>
    /// Gets or sets the file path associated with the synchronization process.
    /// </summary>
    public string? SyncFilePath { get; set; }

    /// <summary>
    /// Gets or sets the UTC start time of the synchronization process.
    /// </summary>
    public DateTime? SyncStartTimeUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC end time of the synchronization process.
    /// </summary>
    public DateTime? SyncEndTimeUtc { get; set; }

    /// <summary>
    /// Gets or sets the duration of the synchronization process.
    /// </summary>
    public TimeSpan? SyncDuration { get; set; }

    /// <summary>
    /// Gets or sets the loan application associated with this sync log.
    /// </summary>
    public LoanApplication? LoanApplication { get; set; }
}
