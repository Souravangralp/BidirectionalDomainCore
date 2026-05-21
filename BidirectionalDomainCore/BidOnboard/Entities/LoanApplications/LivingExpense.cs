namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a living expense record for a household associated with a loan application.
/// </summary>
public class LivingExpense : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated household for this living expense.
    /// </summary>
    public int? LivingExpense_HouseholdID { get; set; }

    /// <summary>
    /// Gets or sets the frequency type of the living expense from the GeneralLookUp table.
    /// </summary>
    [Comment("We will get this from GeneralLookUp Table")]
    public int? FrequencyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the type of living expense from the GeneralLookUp table.
    /// </summary>
    [Comment("We will get this from GeneralLookUp Table")]
    public int? LivingExpenseType_GeneralLookUpID { get; set; }

    public string? OtherLivingExpense { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount of the living expense.
    /// </summary>
    [EncryptColumn]
    public double? ExpenseAmount { get; set; }

    /// <summary>
    /// Gets or sets the description for this living expense.
    /// </summary>
    public string? ExpenseDescription { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional data related to the living expense.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional data related to the living expense.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional data related to the living expense.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the associated household entity for this living expense.
    /// </summary>
    public Household? LivingExpense_Household { get; set; }

    /// <summary>
    /// Gets or sets the percent responsible entity for this living expense.
    /// </summary>
    public ResponsibilityPercentage? ResponsibilityPercentage { get; set; }
}
