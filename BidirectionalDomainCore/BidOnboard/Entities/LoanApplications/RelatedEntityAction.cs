namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an action related to an entity in the context of loan applications,
/// including details about credit history, payment status, and financial defaults.
/// </summary>
public class RelatedEntityAction : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related credit history entity 
    /// for financial and non-financial records.
    /// </summary>
    public int? RelatedEntityAction_CreditHistoryForFinancialAndNonFinancialID { get; set; }

    /// <summary>
    /// Gets or sets the lookup identifier for the payment status type from the core database.
    /// </summary>
    public int? PaymentStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this action represents a financial default.
    /// </summary>
    public bool ISFinancialDefault { get; set; }

    /// <summary>
    /// Gets or sets the value associated with the related entity action.
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or sets the date when the action was listed.
    /// </summary>
    public DateOnly? ListedOn { get; set; }

    /// <summary>
    /// Gets or sets the amount that has been paid.
    /// </summary>
    public double? Paid { get; set; }

    /// <summary>
    /// Gets or sets the date on which the payment was made.
    /// </summary>
    public DateOnly? PaidOn { get; set; }

    /// <summary>
    /// Gets or sets the related credit history for financial and non-financial records.
    /// </summary>
    public CreditHistoryForFinancialAndNonFinancial? RelatedEntityAction_CreditHistoryForFinancialAndNonFinancial { get; set; }

    #region Remove Fields

    /// <summary>
    /// Gets or sets the identifier for the related entity associated with this action.
    /// </summary>
    public int? RelatedEntityAction_RelatedEntityID { get; set; }

    /// <summary>
    /// Gets or sets the lookup identifier for the credit history type from the core database.
    /// </summary>
    public int? CreditHistoryType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the total amount of unpaid default.
    /// </summary>
    public double? TotalUnpaidDefault { get; set; }

    /// <summary>
    /// Gets or sets the amount in council arrears.
    /// </summary>
    public double? InCouncilArrears { get; set; }

    /// <summary>
    /// Gets or sets the lookup identifier for the action type from the core database.
    /// </summary>
    public int? ActionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the related entity associated with this action.
    /// </summary>
    public RelatedEntity? RelatedEntityAction_RelatedEntity { get; set; }

    #endregion
}
