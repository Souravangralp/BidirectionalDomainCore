namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the score and related details for a company applicant in a loan application.
/// </summary>
public class CompanyScore : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated company applicant.
    /// </summary>
    public int? CompanyScore_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the score request.
    /// </summary>
    public string? ScoreRequestID { get; set; }

    /// <summary>
    /// Gets or sets the date the score report was created.
    /// </summary>
    public string? ScoreReportCreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the chargeback reference number for the score request.
    /// </summary>
    public string? ChargeBackReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the date of the last ASIC update in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? LastASICUpdateDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the ASIC extract date in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ASICExtractDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the related company applicant entity.
    /// </summary>
    public CompanyApplicant? CompanyScore_CompanyApplicant { get; set; }
}
