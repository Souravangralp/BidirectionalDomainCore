namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a company's address associated with a loan application, including details such as address type, start date, and linkage to the customer introduction.
/// </summary>
public class CompanyAddress : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier linking this address to an introduction to the customer.
    /// </summary>
    public int? CompanyAddress_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the type of company address, linked to the general lookup in the core database.
    /// </summary>
    public int? CompanyAddressType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the actual address string of the company.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when this address started being valid.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the descriptive type name of the company address.
    /// </summary>
    public string? AddressType { get; set; }

    //public string? DocumentNumber { get; set; }

    /// <summary>
    /// Gets or sets the related introduction to the customer entity.
    /// </summary>
    public IntroductionToTheCustomer? CompanyAddress_IntroductionToTheCustomer { get; set; }
}
