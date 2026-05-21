namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a record of a company applicant that has been default listed, 
/// including associated financial and court judgement data.
/// </summary>
public class DefaultListing : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the company applicant that has been default listed.
    /// </summary>
    public int? DefaultListing_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the identifier referencing the related court judgement or credit history record for financial and non-financial data.
    /// </summary>
    public int? CourtJudgement_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the credit history type, mapping to the General LookUp table (e.g., Financial, Telco, Utility).
    /// </summary>
    public int? CreditHistoryType_GeneralLookUpID { get; set; } // We will get this values ( Financial, Telco, Utility ) from General LookUp table

    /// <summary>
    /// Gets or sets the amount associated with the default listing.
    /// </summary>
    public double? DefaultListingAmount { get; set; }

    /// <summary>
    /// Gets or sets the amount that has been paid towards the default listing.
    /// </summary>
    public double? Paid { get; set; }

    /// <summary>
    /// Gets or sets the reference to the related company applicant entity.
    /// </summary>
    public CompanyApplicant? DefaultListing_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the reference to the related court judgement or credit history entity for financial and non-financial records.
    /// </summary>
    public CreditHistoryForFinancialAndNonFinancial? CourtJudgement_CreditHistoryForFinancialAndNonFinancial { get; set; }
}
