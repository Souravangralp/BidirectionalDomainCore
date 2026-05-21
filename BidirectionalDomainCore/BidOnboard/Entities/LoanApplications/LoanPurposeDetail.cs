namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details and specific attributes related to the purpose of a loan application,
/// including related entities and refinance information.
/// </summary>
public class LoanPurposeDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan split for the loan purpose detail.
    /// </summary>
    public int? LoanPurposeDetail_LoanSplitID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the type of loan purpose.
    /// </summary>
    public int? LoanPurposeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the type of remedial action taken.
    /// </summary>
    public int? RemedialActionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the description of the remedial action taken, if any.
    /// </summary>
    public string? RemedialActionDescription { get; set; }

    /// <summary>
    /// Gets or sets the settlement date for the loan purpose, if applicable.
    /// </summary>
    public DateTime? SettlementDate { get; set; }

    /// <summary>
    /// Gets or sets the relocation details associated with the loan purpose, if applicable.
    /// </summary>
    public Relocation? Relocation { get; set; }

    /// <summary>
    /// Gets or sets the construction details associated with the loan purpose, if applicable.
    /// </summary>
    public Construction? Construction { get; set; }

    /// <summary>
    /// Gets or sets the cash-out details associated with the loan purpose, if applicable.
    /// </summary>
    public Cashout? Cashout { get; set; }

    /// <summary>
    /// Gets or sets the purchase details associated with the loan purpose, if applicable.
    /// </summary>
    public Purchase? Purchase { get; set; }

    /// <summary>
    /// Gets or sets the related loan split entity for the loan purpose detail.
    /// </summary>
    public LoanSplit? LoanPurposeDetail_LoanSplit { get; set; }

    #region Refinance

    /// <summary>
    /// Gets or sets a value indicating whether there is no cash out other than the costs involved.
    /// </summary>
    public bool? ISNoCashOutOtherThanCosts { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID indicating the type from which the refinance is originating.
    /// </summary>
    public int? RefinanceFromType_GeneralLookUpID { get; set; }

    #endregion
}
