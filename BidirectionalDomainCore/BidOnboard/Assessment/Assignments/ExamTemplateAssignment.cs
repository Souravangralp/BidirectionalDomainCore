using Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;
using Bidirectional.DomainCore.BidOnboard.Assessment.Templates;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Assessment.Assignments;

/// <summary>
/// Represents the assignment of an exam template to a user, including due date and status, and tracks related exam attempts.
/// </summary>
public class ExamTemplateAssignment : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the assigned exam template.
    /// </summary>
    public int? ExamTemplateAssignment_ExamTemplateID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the user to whom the exam template is assigned.
    /// </summary>
    public int? ExamTemplateAssignment_UserGroupID { get; set; }

    /// <summary>
    /// Gets or sets the due date by which the assigned exam should be completed.
    /// </summary>
    public DateOnly? DueDate { get; set; }

    /// <summary>
    /// Gets or sets the exam template associated with this assignment.
    /// </summary>
    public ExamTemplate? ExamTemplateAssignment_ExamTemplate { get; set; }

    /// <summary>
    /// Gets or sets the user associated with this exam template assignment.
    /// </summary>
    public UserGroup? ExamTemplateAssignment_UserGroup { get; set; }

    public ICollection<ExamAttempt> ExamAttempts { get; set; } = [];
}
