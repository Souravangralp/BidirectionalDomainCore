namespace Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;

/// <summary>
/// Represents an available answer option for an assessment attempt question.
/// </summary>
public class AttemptOption : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated attempt question.
    /// </summary>
    public int? AttemptOption_AttemptQuestionID { get; set; }

    /// <summary>
    /// Gets or sets the text content of the attempt option.
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this option is the correct answer.
    /// </summary>
    public bool ISCorrect { get; set; }

    /// <summary>
    /// Gets or sets the associated attempt question entity.
    /// </summary>
    public AttemptQuestion? AttemptOption_AttemptQuestion { get; set; }
}
