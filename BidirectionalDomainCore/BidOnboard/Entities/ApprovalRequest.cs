using Bidirectional.DomainCore.Calculator.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Represents a request for approval within the system, capturing all relevant audit, status, and user action details related to record changes.
/// </summary>
public class ApprovalRequest : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional bulk approval request ID.</summary>
    public int? ApprovalRequest_BulkApprovalRequestID { get; set; }

    /// <summary>
    /// Gets or sets the name of the table that contains the record for this approval request.
    /// </summary>
    public string? TableName { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the record associated with this approval request.
    /// </summary>
    public string? RecordUniqueID { get; set; }

    /// <summary>
    /// Gets or sets the name of the field that is being changed in this approval request.
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// Gets or sets the previous value of the field before the change.
    /// </summary>
    public string? OldValue { get; set; } // this will be using when we are changing base values and fees.

    /// <summary>
    /// Gets or sets the new value of the field after the change.
    /// </summary>
    public string? NewValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the change is applicable (e.g., when changing applicable fees).
    /// </summary>
    public bool ISApplicable { get; set; } // this will be using when we are changing applicable fees.

    /// <summary>
    /// Gets or sets the user who submitted the approval request.
    /// </summary>
    public string? SubmittedBy { get; set; }

    /// <summary>
    /// Gets or sets the user who reviewed the approval request.
    /// </summary>
    public string? ReviewedBy { get; set; }

    /// <summary>
    /// Gets or sets the user who rolled back the approval request.
    /// </summary>
    public string? RolledBackBy { get; set; }

    /// <summary>
    /// Gets or sets the current approval status of the request.
    /// </summary>
    public ApprovalStatus ApprovalStatus { get; set; }

    /// <summary>
    /// Gets or sets the date and time the request was submitted.
    /// </summary>
    public DateTime? SubmittedDate { get; set; }

    /// <summary>
    /// Gets or sets the date and time the request was reviewed.
    /// </summary>
    public DateTime? ReviewedDate { get; set; }

    /// <summary>
    /// Gets or sets the date and time the request was rolled back.
    /// </summary>
    public DateTime? RolledBackDate { get; set; }

    /// <summary>
    /// Gets or sets the version associated with the approval request.
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// Gets or sets the reference number or identifier for the approval request.
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// Gets or sets the comment provided by the user who submitted the request.
    /// </summary>
    public string? SubmittedComment { get; set; }

    /// <summary>
    /// Gets or sets the comment provided by the reviewer.
    /// </summary>
    public string? ReviewedComment { get; set; }

    /// <summary>
    /// Gets or sets the comment provided regarding the rollback action.
    /// </summary>
    public string? RolledBackComment { get; set; }

    /// <summary>Gets or sets the optional fee type.</summary>
    public string? FeeType { get; set; }

    /// <summary>Gets or sets the optional bulk approval request.</summary>
    public BulkApprovalRequest? ApprovalRequest_BulkApprovalRequest { get; set; }
}
