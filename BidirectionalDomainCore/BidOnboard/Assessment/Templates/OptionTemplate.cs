namespace Bidirectional.DomainCore.BidOnboard.Assessment.Templates;

/// <summary>
/// Represents an answer option template for a question within an assessment.
/// </summary>
public class OptionTemplate : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated question template.
    /// </summary>
    public int? OptionTemplate_QuestionTemplateID { get; set; }

    /// <summary>
    /// Gets or sets the display text for this option.
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this option is a correct answer.
    /// </summary>
    public bool ISCorrect { get; set; }

    /// <summary>
    /// Gets or sets the associated question template entity.
    /// </summary>
    public QuestionTemplate? OptionTemplate_QuestionTemplate { get; set; }
}
