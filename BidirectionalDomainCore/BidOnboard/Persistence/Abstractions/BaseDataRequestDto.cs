namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;

/// <summary>
/// DTO representing a base data request, including details about the requested change and its current workflow status.
/// </summary>
public class BaseDataRequestDto
{
    /// <summary>
    /// Gets or sets the unique identifier associated with the base data request.
    /// </summary>
    public string UniqueID { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name of the field affected by the request.
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// Gets or sets the previous value of the field.
    /// </summary>
    public string? OldValue { get; set; }

    /// <summary>
    /// Gets or sets the new value assigned to the field.
    /// </summary>
    public string? NewValue { get; set; }

    /// <summary>
    /// Gets or sets the current approval status of the request.
    /// </summary>
    public ApprovalStatus ApprovalStatus { get; set; }

    /// <summary>
    /// Gets or sets the name of the user who submitted the request.
    /// </summary>
    public string? SubmittedBy { get; set; }

    /// <summary>
    /// Gets or sets a comment from the request submitter.
    /// </summary>
    public string? SubmittedComment { get; set; }

    /// <summary>
    /// Gets or sets the date and time of request submission.
    /// </summary>
    public DateTime? SubmittedDate { get; set; }

    /// <summary>
    /// Gets or sets a comment from the reviewer.
    /// </summary>
    public string? ReviewedComment { get; set; }

    /// <summary>
    /// Gets or sets the date and time the request was reviewed.
    /// </summary>
    public DateTime? ReviewedDate { get; set; }

    /// <summary>
    /// Gets or sets a comment related to a rollback.
    /// </summary>
    public string? RolledBackComment { get; set; }

    /// <summary>
    /// Gets or sets the date and time the request was rolled back.
    /// </summary>
    public DateTime? RolledBackDate { get; set; }

    /// <summary>
    /// Gets or sets an optional reference related to the request.
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// Gets or sets the fee type associated with this base data record.
    /// </summary>
    public string? FeeType { get; set; }
}
