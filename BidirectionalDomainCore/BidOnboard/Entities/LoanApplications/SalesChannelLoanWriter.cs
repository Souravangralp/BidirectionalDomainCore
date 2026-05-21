namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a loan writer associated with a sales channel, including personal and accreditation details.
/// </summary>
public class SalesChannelLoanWriter : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated sales channel for the loan writer.
    /// </summary>
    public int? SalesChannelLoanWriter_SalesChannelID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the name title type.
    /// </summary>
    public int? NameTitleType_GeneralLookUpID { get; set; } // we will get this from the general lookup Table

    /// <summary>
    /// Gets or sets the accreditation number of the loan writer.
    /// </summary>
    public string? AccreditationNumber { get; set; }

    /// <summary>
    /// Gets or sets the first name or Christian name of the loan writer.
    /// </summary>
    public string? FirstNameORChristianName { get; set; }

    /// <summary>
    /// Gets or sets the last name, surname, or family name of the loan writer.
    /// </summary>
    public string? LastNameORSurnameORFamilyName { get; set; }

    /// <summary>
    /// Gets or sets an additional custom field for the loan writer.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets another custom field for the loan writer.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets a third custom field for the loan writer.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the contact information of the loan writer.
    /// </summary>
    public Contact? Contact { get; set; }

    /// <summary>
    /// Gets or sets the associated sales channel entity for the loan writer.
    /// </summary>
    public SalesChannel? SalesChannelLoanWriter_SalesChannel { get; set; }
}
