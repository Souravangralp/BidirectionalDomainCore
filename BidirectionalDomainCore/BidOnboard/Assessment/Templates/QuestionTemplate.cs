namespace Bidirectional.DomainCore.BidOnboard.Assessment.Templates;

/// <summary>
/// Represents a template for an assessment question, including its text, marks, options, and related section.
/// </summary>
public class QuestionTemplate : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related section template.
    /// </summary>
    public int? QuestionTemplate_SectionTemplateID { get; set; }

    /// <summary>
    /// Gets or sets the text of the question.
    /// </summary>
    public string? QuestionText { get; set; }

    [TextClass(TextFieldClass.Comment)]
    /// <summary>
    /// Gets or sets the summary of the question.
    /// </summary>
    public string? QuestionSummary { get; set; }

    /// <summary>
    /// Gets or sets the number of marks assigned to the question.
    /// </summary>
    public float Marks { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the question is required.
    /// </summary>
    public bool ISRequired { get; set; }

    /// <summary>
    /// Gets or sets the related section template for this question.
    /// </summary>
    public SectionTemplate? QuestionTemplate_SectionTemplate { get; set; }

    /// <summary>
    /// Gets or sets the collection of option templates associated with this question.
    /// </summary>
    public ICollection<OptionTemplate> Options { get; set; } = new List<OptionTemplate>();
}
