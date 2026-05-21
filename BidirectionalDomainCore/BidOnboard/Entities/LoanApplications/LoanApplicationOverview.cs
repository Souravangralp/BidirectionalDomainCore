namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a summary overview entity for a loan application, containing key attributes and references related to the application's type, documentation, features, and expected outcomes.
/// </summary>
public class LoanApplicationOverview : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the associated loan application in the overview.
    /// </summary>
    public int? LoanApplicationOverview_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the application type identifier from the GeneralLookUp table.
    /// </summary>
    public int? ApplicationType_GeneralLookUpID { get; set; } // We Will get this data from GeneralLookUpTable

    /// <summary>
    /// Gets or sets the document type identifier from the GeneralLookUp table.
    /// </summary>
    public int? DocType_GeneralLookUpID { get; set; } // We Will get this data from GeneralLookUpTable

    /// <summary>
    /// Gets or sets a value indicating whether the loan is a combination loan.
    /// </summary>
    public bool ISCombinationLoan { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is a fast refinance.
    /// </summary>
    public bool ISFastRefinance { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan includes bridging finance.
    /// </summary>
    public bool ISBridgingFinance { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the application is linked to a commercial application.
    /// </summary>
    public bool ISLinkedCommercialApplication { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is a ProPack product.
    /// </summary>
    public bool ISProPack { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan is an SMSF (Self Managed Super Fund) loan.
    /// </summary>
    public bool ISSMSFLoan { get; set; }

    /// <summary>
    /// Gets or sets the broker's application reference number. This value is encrypted.
    /// </summary>
    [EncryptColumn]
    public string? BrokerApplicationReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the expected settlement date for the loan application, stored as date only (UTC).
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? ExpectedSettlementDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the related loan application entity.
    /// </summary>
    public LoanApplication? LoanApplicationOverview_LoanApplication { get; set; }
}
