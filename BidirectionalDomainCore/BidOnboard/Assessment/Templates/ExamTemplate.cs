using Bidirectional.DomainCore.BidOnboard.Assessment.Assignments;

namespace Bidirectional.DomainCore.BidOnboard.Assessment.Templates;

/// <summary>
/// Represents a template for exams, including metadata such as name, type, total marks, passing criteria, and organizational structure.
/// </summary>
public class ExamTemplate : BaseAuditableEntity
{
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
    /// Gets or sets the collection of section templates included in the exam template.
    /// </summary>
    public ICollection<SectionTemplate> SectionTemplates { get; set; } = new List<SectionTemplate>();

    /// <summary>
    /// Gets or sets the collection of Exam Template Assignment included in the exam template.
    /// </summary>
    public ICollection<ExamTemplateAssignment> ExamTemplateAssignments { get; set; } = new List<ExamTemplateAssignment>();
}
