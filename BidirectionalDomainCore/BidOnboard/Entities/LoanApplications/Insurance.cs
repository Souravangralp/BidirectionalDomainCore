namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an insurance policy associated with a loan application, containing details about the policy, holder, and related entities.
/// </summary>
public class Insurance : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the applicant associated with the insurance.
    /// </summary>
    public int? Insurance_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the insurance type identifier from the CoreDB GeneralLookUp table.
    /// </summary>
    public int? InsuranceType_GeneralLookUpID { get; set; }  // We will get this form GeneralLookUp Table

    /// <summary>
    /// Gets or sets the premium frequency type identifier from the CoreDB GeneralLookUp table.
    /// </summary>
    public int? PremiumFrequencyType_GeneralLookUpID { get; set; } // We will get this form GeneralLookUp Table

    /// <summary>
    /// Gets or sets the name of the policy holder.
    /// </summary>
    public string? PolicyHolderName { get; set; }

    /// <summary>
    /// Gets or sets the insurance policy number.
    /// </summary>
    public string? InsurancePolicyNumber { get; set; }

    /// <summary>
    /// Gets or sets the value of the insurance policy.
    /// </summary>
    public string? PolicyValue { get; set; }

    /// <summary>
    /// Gets or sets the minimum value of the insurance policy.
    /// </summary>
    public string? PolicyMinimumValue { get; set; }

    /// <summary>
    /// Gets or sets the premium amount for the insurance policy.
    /// </summary>
    public string? PremiumAmount { get; set; }

    /// <summary>
    /// Gets or sets the linked contact details related to the insurance policy.
    /// </summary>
    public string? LinkedContactDetails { get; set; } // Based on sales trekker

    /// <summary>
    /// Gets or sets the UTC date when the policy is due for renewal.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? PolicyRenewalDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the applicant associated with the insurance.
    /// </summary>
    public Applicant? Insurance_Applicant { get; set; }
}
