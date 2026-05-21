namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a sales channel associated with a loan application, including related parties and aggregator details.
/// </summary>
public class SalesChannel : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related loan application.
    /// </summary>
    public int? SalesChannel_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the lookup identifier for the sales channel type from the GeneralLookUp table.
    /// </summary>
    public int? SalesChannelType_GeneralLookUpID { get; set; }  // We will get this from GeneralLookUp

    /// <summary>
    /// Gets or sets the aggregator number for saving aggregator information.
    /// </summary>
    [EncryptColumn]
    public string? AggregatorNumber { get; set; } // We will be using this field for saving Aggregator information.

    /// <summary>
    /// Gets or sets the collection of loan writers associated with this sales channel.
    /// </summary>
    public SalesChannelLoanWriter? SalesChannelLoanWriters { get; set; }

    /// <summary>
    /// Gets or sets the collection of introducers associated with this sales channel.
    /// </summary>
    public SalesChannelIntroducer? SalesChannelIntroducers { get; set; }

    /// <summary>
    /// Gets or sets the collection of companies associated with this sales channel.
    /// </summary>
    public SalesChannelCompany? SalesChannelCompanies { get; set; }

    /// <summary>
    /// Gets or sets the loan application entity related to this sales channel.
    /// </summary>
    public LoanApplication? SalesChannel_LoanApplication { get; set; }
}
