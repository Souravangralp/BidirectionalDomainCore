namespace Bidirectional.DomainCore.BidOnboard.Entities.Audit;

/// <summary>
/// Represents a log entry for messages synchronized between systems, including details about the message, its processing status, and any related errors.
/// </summary>
public class DataSyncMessageLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the synchronized message.
    /// </summary>
    public required string MessageID { get; set; }

    /// <summary>
    /// Gets or sets the type of entity associated with the synchronized message.
    /// </summary>
    public string? EntityType { get; set; }

    /// <summary>
    /// Gets or sets the action type that was performed during synchronization.
    /// </summary>
    public string? ActionType { get; set; }

    /// <summary>
    /// Gets or sets the serialized data of the message involved in synchronization.
    /// </summary>
    public string? Data { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the message was successfully synchronized.
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// Gets or sets the error message if the synchronization failed.
    /// </summary>
    public string? ErrorMessage { get; set; }
}
