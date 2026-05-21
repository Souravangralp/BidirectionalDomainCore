namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a shareholder currently associated with a company within a loan application,
/// including ownership details and related Equifax-sourced information.
/// </summary>
public class CompanyCurrentShareholder : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the introduction to the customer associated with this shareholder.
    /// </summary>
    public int? CompanyCurrentShareholder_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the full name of the shareholder.
    /// </summary>
    public string? ShareholderFullName { get; set; }

    /// <summary>
    /// Gets or sets the address of the shareholder.
    /// </summary>
    public string? ShareholderAddress { get; set; }

    /// <summary>
    /// Gets or sets the class of shares held by the shareholder.
    /// </summary>
    public string? ShareholderClass { get; set; }

    /// <summary>
    /// Gets or sets the number of shares currently held by the shareholder.
    /// </summary>
    public int? SharesHeldCount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the shareholder is a beneficial owner. 
    /// The value is sourced from Equifax, typically 'Y' (Yes) or 'N' (No).
    /// </summary>
    [Comment("we are getting only 'Y' & 'N' values from Equifax, which seem to indicate 'Yes' and 'No'. Needs to be confirmed with Equifax API")]
    public bool IsBeneficialOwner { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether all shares held are fully paid. 
    /// The value is sourced from Equifax, typically 'Y' (Yes) or 'N' (No).
    /// </summary>
    [Comment("we are getting only 'Y' & 'N' values from Equifax, which seem to indicate 'Yes' and 'No'. Needs to be confirmed with Equifax API")]
    public bool IsFullyPaidShares { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the shares are jointly held. 
    /// The value is sourced from Equifax, typically 'Y' (Yes) or 'N' (No).
    /// </summary>
    [Comment("we are getting only 'Y' & 'N' values from Equifax, which seem to indicate 'Yes' and 'No'. Needs to be confirmed with Equifax API")]
    public bool IsJointlyHeldShares { get; set; }

    /// <summary>
    /// Gets or sets the document number associated with the shareholder.
    /// </summary>
    public string? ShareholderDocumentNumber { get; set; }

    /// <summary>
    /// Gets or sets the introduction to the customer entity related to this shareholder.
    /// </summary>
    public IntroductionToTheCustomer? CompanyCurrentShareholder_IntroductionToTheCustomer { get; set; }
}
