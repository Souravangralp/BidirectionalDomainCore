namespace Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;

/// <summary>
/// Represents an answer provided to a specific exam attempt question, including linkages to the selected option and textual response.
/// </summary>
public class AttemptAnswer : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the related attempt question.
    /// </summary>
    public int? AttemptAnswer_AttemptQuestionID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the selected attempt option, if applicable.
    /// </summary>
    public int? AttemptAnswer_AttemptOptionID { get; set; }

    /// <summary>
    /// Gets or sets the free-text value of the answer, if applicable.
    /// </summary>
    public string? AnswerText { get; set; }

    /// <summary>
    /// Gets or sets the reference to the related attempt question.
    /// </summary>
    public AttemptQuestion? AttemptAnswer_AttemptQuestion { get; set; } = null!;

    /// <summary>
    /// Gets or sets the reference to the selected attempt option, if chosen.
    /// </summary>
    public AttemptOption? AttemptAnswer_AttemptOption { get; set; }
}
