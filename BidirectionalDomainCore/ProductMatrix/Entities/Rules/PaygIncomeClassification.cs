namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification of PAYG (Pay As You Go) income, including related loan type, income type, referral filter, and evaluation points.
/// </summary>
public class PaygIncomeClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the associated loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the PAYG income type from the core database.
    /// </summary>
    public int? PaygIncomeType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the filter reference, containing specific values defined in an enumeration.
    /// </summary>
    [Comment("It has some specific values get from enum.")]
    public string? ReferredToOtherFilter { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with this classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
