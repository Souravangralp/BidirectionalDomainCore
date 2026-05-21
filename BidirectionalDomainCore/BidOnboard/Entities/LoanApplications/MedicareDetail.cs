namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a Medicare record associated with a loan application, including applicant details, card information, and validity.
/// </summary>
public class MedicareDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the applicant associated with this Medicare record.
    /// </summary>
    public int? MedicareDetail_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the color type of the Medicare card.
    /// </summary>
    [Comment("Will get this from General Lookup Table -----Color is good in US but not in Australia use (Color)")]
    public int? CardColorType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the Medicare card number.
    /// </summary>
    public string? CardNumber { get; set; }

    /// <summary>
    /// Gets or sets the reference number associated with the Medicare card.
    /// </summary>
    public string? ReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the validity end date of the Medicare card.
    /// </summary>
    public DateOnly? ValidTo { get; set; }

    /// <summary>
    /// Gets or sets the applicant entity associated with this Medicare record.
    /// </summary>
    public Applicant? MedicareDetail_Applicant { get; set; }
}
