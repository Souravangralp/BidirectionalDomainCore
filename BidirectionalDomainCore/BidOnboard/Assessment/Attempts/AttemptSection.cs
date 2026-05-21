namespace Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;

/// <summary>
/// Represents a section within an exam attempt, grouping related questions and displaying section-specific properties such as title and type.
/// </summary>
public class AttemptSection : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the exam attempt to which this section belongs.
    /// </summary>
    public int? AttemptSection_ExamAttemptID { get; set; }

    /// <summary>
    /// Gets or sets the display title of the attempt section.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the type of questions contained in this section.
    /// </summary>
    public QuestionType Type { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the questions in this section should be randomized.
    /// </summary>
    public bool ISRandomized { get; set; }

    /// <summary>
    /// Gets or sets the exam attempt entity associated with this section.
    /// </summary>
    public ExamAttempt? AttemptSection_ExamAttempt { get; set; }

    /// <summary>
    /// Gets or sets the collection of questions belonging to this section.
    /// </summary>
    public ICollection<AttemptQuestion> Questions { get; set; } = new List<AttemptQuestion>();
}
