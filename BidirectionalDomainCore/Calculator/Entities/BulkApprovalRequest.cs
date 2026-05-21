namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a bulk approval request that groups multiple approval requests.
/// </summary>
public class BulkApprovalRequest : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional fee type.</summary>
    public string? FeeType { get; set; }

    /// <summary>Gets or sets the optional submitted-by user.</summary>
    public string? SubmittedBy { get; set; }

    /// <summary>Gets or sets the optional reviewed-by user.</summary>
    public string? ReviewedBy { get; set; }

    /// <summary>Gets or sets the optional rolled-back-by user.</summary>
    public string? RolledBackBy { get; set; }

    /// <summary>Gets or sets the approval status.</summary>
    public ApprovalStatus ApprovalStatus { get; set; }

    /// <summary>Gets or sets the optional submitted comment.</summary>
    public string? SubmittedComment { get; set; }

    /// <summary>Gets or sets the optional submitted date.</summary>
    public DateTime? SubmittedDate { get; set; }

    /// <summary>Gets or sets the optional reviewed comment.</summary>
    public string? ReviewedComment { get; set; }

    /// <summary>Gets or sets the optional reviewed date.</summary>
    public DateTime? ReviewedDate { get; set; }

    /// <summary>Gets or sets the optional rolled-back comment.</summary>
    public string? RolledBackComment { get; set; }

    /// <summary>Gets or sets the optional rolled-back date.</summary>
    public DateTime? RolledBackDate { get; set; }

    /// <summary>Gets or sets the optional reference.</summary>
    public string? Reference { get; set; }

    /// <summary>Gets or sets the list of approval requests.</summary>
    public List<ApprovalRequest> ApprovalRequests { get; set; } = [];
}
