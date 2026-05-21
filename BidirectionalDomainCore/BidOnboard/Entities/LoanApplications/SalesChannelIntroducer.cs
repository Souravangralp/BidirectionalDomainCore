namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an introducer associated with a sales channel for a loan application, 
/// including related details such as company name and custom extra fields.
/// </summary>
public class SalesChannelIntroducer : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the related sales channel.
    /// </summary>
    public int SalesChannelIntroducer_SalesChannelID { get; set; }

    /// <summary>
    /// Gets or sets the name of the company for which the introducer is associated.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the introducer.
    /// </summary>
    public string? IntroducerID { get; set; }

    /// <summary>
    /// Gets or sets the first extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets the second extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets the third extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for the related sales channel entity.
    /// </summary>
    public SalesChannel? SalesChannelIntroducer_SalesChannel { get; set; }
}
