namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an income record associated with a loan application, including details about income type, amount, category, and related entities.
/// </summary>
public class Income : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated PAYG income.
    /// </summary>
    public int? Income_PaygID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the income is earned onshore.
    /// </summary>
    public bool? ISOnshoreIncome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is the primary income.
    /// </summary>
    public bool? ISPrimary { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the PAYG income type.
    /// </summary>
    public int? PaygIncomeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the income amount.
    /// </summary>
    public float? Amount { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional income-related information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets another extra field for additional income-related information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an additional extra field for income-related information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the general lookup identifier for the income category type.
    /// </summary>
    public int? IncomeCategoryType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the gross annual income.
    /// </summary>
    public decimal? GrossAnnualIncome { get; set; }

    /// <summary>
    /// Gets or sets the monthly income.
    /// </summary>
    public decimal? MonthlyIncome { get; set; }

    /// <summary>
    /// Gets or sets the expected annual income.
    /// </summary>
    public decimal? ExpectedAnnualIncome { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the associated country.
    /// </summary>
    public int? CountryID { get; set; }

    /// <summary>
    /// Gets or sets the related PAYG income entity.
    /// </summary>
    public Payg? Income_Payg { get; set; }
}
