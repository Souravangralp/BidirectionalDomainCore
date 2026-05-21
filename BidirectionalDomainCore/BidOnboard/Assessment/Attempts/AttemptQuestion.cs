namespace Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;

/// <summary>
/// Represents a question within an assessment attempt, including its options, answers, awarded marks, and related metadata.
/// </summary>
public class AttemptQuestion : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the section ID associated with this question attempt.
    /// </summary>
    public int? AttemptQuestion_AttemptSectionID { get; set; }

    /// <summary>
    /// Gets or sets the text content of the question.
    /// </summary>
    public string? QuestionText { get; set; } = null!;

    [TextClass(TextFieldClass.Comment)]
    /// <summary>
    /// Gets or sets the summary of the question.
    /// </summary>
    public string? QuestionSummary { get; set; }

    /// <summary>
    /// Gets or sets the total marks assigned to the question.
    /// </summary>
    public float Marks { get; set; }

    public bool ISAttempted { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the question was answered correctly.
    /// </summary>
    public bool ISCorrect { get; set; }

    /// <summary>
    /// Gets or sets the marks awarded to the question in this attempt.
    /// </summary>
    public float MarksAwarded { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the question is required.
    /// </summary>
    public bool ISRequired { get; set; }

    /// <summary>
    /// Gets or sets the attempt section related to this question.
    /// </summary>
    public AttemptSection? AttemptQuestion_AttemptSection { get; set; }

    /// <summary>
    /// Gets or sets the collection of options presented for the question.
    /// </summary>
    public ICollection<AttemptOption> Options { get; set; } = new List<AttemptOption>();

    /// <summary>
    /// Gets or sets the collection of answers provided for the question.
    /// </summary>
    public ICollection<AttemptAnswer> Answers { get; set; } = new List<AttemptAnswer>();
}
