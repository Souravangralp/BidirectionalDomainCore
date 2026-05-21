namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a company that is associated with a sales channel in the loan applications domain.
/// </summary>
public class SalesChannelCompany : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated sales channel.
    /// </summary>
    public int? SalesChannelCompany_SalesChannelID { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN) of the company.
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the name of the company.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Gets or sets an alternative identifier for the company.
    /// </summary>
    public string? OtherIdentifier { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional company information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional company information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional company information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the contact information for the company.
    /// </summary>
    public Contact? Contact { get; set; }

    /// <summary>
    /// Gets or sets the associated sales channel entity.
    /// </summary>
    public SalesChannel? SalesChannelCompany_SalesChannel { get; set; }
}
