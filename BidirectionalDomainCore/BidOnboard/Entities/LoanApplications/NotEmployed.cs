namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents information related to a loan applicant who is not currently employed.
/// </summary>
public class NotEmployed : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the applicant associated with this record.
    /// </summary>
    public int? NotEmployed_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is engaged in home duties.
    /// </summary>
    public bool HasHomeDuties { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is receiving benefits.
    /// </summary>
    public bool OnBenefits { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is retired.
    /// </summary>
    public bool ISRetired { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is a student.
    /// </summary>
    public bool ISStudent { get; set; }

    /// <summary>
    /// Gets or sets the employment status description of the applicant.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Gets or sets the start date of the non-employment period, in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the end date of the non-employment period, in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? EndDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the applicant associated with this not employed record.
    /// </summary>
    public Applicant? NotEmployed_Applicant { get; set; }
}
