namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the employment classification details and associated rule parameters for an applicant.
/// </summary>
public class EmploymentClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the Loan Type identifier from the CoreDB General LookUp table.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the Employment Type identifier from the CoreDB General LookUp table.
    /// </summary>
    public int? EmploymentType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum required months of work experience.
    /// </summary>
    public double? MinimumExperienceOfWorkInMonths { get; set; }

    /// <summary>
    /// Gets or sets the maximum allowed months of work experience.
    /// </summary>
    public double? MaximumExperienceOfWorkInMonths { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the employment is in the same line of work.
    /// </summary>
    public bool ISSameLineOfWork { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points assigned.
    /// </summary>
    public int? HeedfulPoints { get; set; }

    /// <summary>
    /// Gets or sets the filter used to refer to other classifications.
    /// </summary>
    public string? ReferredToOtherFilter { get; set; }
}
