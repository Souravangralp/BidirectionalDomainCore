namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a single approval request for a change (e.g. base values, fees, applicable fees).
/// </summary>
public class ApprovalRequest : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional bulk approval request ID.</summary>
    public int? ApprovalRequest_BulkApprovalRequestID { get; set; }

    /// <summary>Gets or sets the optional table name.</summary>
    public string? TableName { get; set; }

    /// <summary>Gets or sets the optional record unique ID.</summary>
    public string? RecordUniqueID { get; set; }

    /// <summary>Gets or sets the optional fee type.</summary>
    public string? FeeType { get; set; }

    /// <summary>Gets or sets the optional field name.</summary>
    public string? FieldName { get; set; }

    /// <summary>Gets or sets the old value (used when changing base values and fees).</summary>
    public double OldValue { get; set; }

    /// <summary>Gets or sets the optional new value.</summary>
    public double? NewValue { get; set; }

    /// <summary>Gets or sets a value indicating whether the change is applicable (used when changing applicable fees).</summary>
    public bool ISApplicable { get; set; }

    /// <summary>Gets or sets the optional submitted-by user.</summary>
    public string? SubmittedBy { get; set; }

    /// <summary>Gets or sets the optional reviewed-by user.</summary>
    public string? ReviewedBy { get; set; }

    /// <summary>Gets or sets the optional rolled-back-by user.</summary>
    public string? RolledBackBy { get; set; }

    /// <summary>Gets or sets the approval status.</summary>
    public ApprovalStatus ApprovalStatus { get; set; }

    /// <summary>Gets or sets the optional submitted date.</summary>
    public DateTime? SubmittedDate { get; set; }

    /// <summary>Gets or sets the optional reviewed date.</summary>
    public DateTime? ReviewedDate { get; set; }

    /// <summary>Gets or sets the optional rolled-back date.</summary>
    public DateTime? RolledBackDate { get; set; }

    /// <summary>Gets or sets the optional version.</summary>
    public string? Version { get; set; }

    /// <summary>Gets or sets the optional reference.</summary>
    public string? Reference { get; set; }

    /// <summary>Gets or sets the optional submitted comment.</summary>
    public string? SubmittedComment { get; set; }

    /// <summary>Gets or sets the optional reviewed comment.</summary>
    public string? ReviewedComment { get; set; }

    /// <summary>Gets or sets the optional rolled-back comment.</summary>
    public string? RolledBackComment { get; set; }

    /// <summary>Gets or sets the optional bulk approval request.</summary>
    public BulkApprovalRequest? ApprovalRequest_BulkApprovalRequest { get; set; }
}
