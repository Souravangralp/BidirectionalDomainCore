using Bidirectional.DomainCore.BidOnboard.Assessment.Assignments;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;

/// <summary>
/// Represents an attempt made by a user to complete an exam, including the results and related assignment information.
/// </summary>
public class ExamAttempt : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the user who attempted the exam.
    /// </summary>
    public int? ExamAttempt_UserID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the related exam template assignment.
    /// </summary>
    public int? ExamAttempt_ExamTemplateAssignmentID { get; set; }

    /// <summary>
    /// Gets or sets the name of the exam template.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the type of the exam.
    /// </summary>
    public ExamType Type { get; set; }

    /// <summary>
    /// Gets or sets the total marks for the exam.
    /// </summary>
    public float TotalMarks { get; set; }

    /// <summary>
    /// Gets or sets the minimum marks required to pass the exam.
    /// </summary>
    public float PassingMarks { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether questions should be randomized.
    /// </summary>
    public bool ISRandomized { get; set; }

    /// <summary>
    /// Gets or sets the duration of the exam in minutes.
    /// </summary>
    public int? DurationInMinutes { get; set; }

    /// <summary>
    /// Gets or sets the summary information for the exam template.
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the attempt was started.
    /// </summary>
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the attempt was completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Gets or sets the marks obtained by the user in this attempt.
    /// </summary>
    public float ObtainedMarks { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the attempt was submitted.
    /// </summary>
    public bool ISSubmitted { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the attempt was passed.
    /// </summary>
    public bool ISPassed { get; set; }

    public ExamTemplateAssignmentStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the user who made this exam attempt.
    /// </summary>
    public User? ExamAttempt_User { get; set; }

    /// <summary>
    /// Gets or sets the exam template assignment related to this attempt.
    /// </summary>
    public ExamTemplateAssignment? ExamAttempt_ExamTemplateAssignment { get; set; }

    /// <summary>
    /// Gets or sets the collection of sections involved in this exam attempt.
    /// </summary>
    public ICollection<AttemptSection> Sections { get; set; } = new List<AttemptSection>();
}
