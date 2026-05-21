namespace Bidirectional.DomainCore.BidOnboard.Assessment.Templates;

/// <summary>
/// Represents a section template within an exam, grouping related questions and defining section-level properties such as title, type, and randomization.
/// </summary>
public class SectionTemplate : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related exam template to which this section belongs.
    /// </summary>
    public int? SectionTemplate_ExamTemplateID { get; set; }

    /// <summary>
    /// Gets or sets the display title of the section template.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the type of questions contained in this section (e.g., MCQ, Text).
    /// </summary>
    public QuestionType Type { get; set; } // MCQ, Text

    /// <summary>
    /// Gets or sets a value indicating whether the questions in this section should be randomized.
    /// </summary>
    public bool ISRandomized { get; set; }

    /// <summary>
    /// Gets or sets the related exam template entity for this section.
    /// </summary>
    public ExamTemplate? SectionTemplate_ExamTemplate { get; set; }

    /// <summary>
    /// Gets or sets the collection of question templates included in this section template.
    /// </summary>
    public ICollection<QuestionTemplate> Questions { get; set; } = [];
}
