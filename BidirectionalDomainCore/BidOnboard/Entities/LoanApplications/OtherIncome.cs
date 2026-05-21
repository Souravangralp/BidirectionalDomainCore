namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents income sources associated with a loan application that do not fall under standard income categories.
/// Contains details such as type, amount, frequency, taxation status, country of origin, and description.
/// </summary>
public class OtherIncome : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the loan application associated with this other income entry.
    /// </summary>
    public int? OtherIncome_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the type of other income.
    /// </summary>
    public int? Type_GeneralLookUpID { get; set; } // We Will get this data from GeneralLookUpTable

    /// <summary>
    /// Gets or sets the general lookup ID for the frequency type of the other income.
    /// </summary>
    public int? FrequencyType_GeneralLookUpID { get; set; } // We Will get this data from GeneralLookUpTable

    /// <summary>
    /// Gets or sets a value indicating whether this income has been taxed.
    /// </summary>
    public bool ISTaxed { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this income is taxable.
    /// </summary>
    public bool ISTaxable { get; set; }

    /// <summary>
    /// Gets or sets the amount of other income.
    /// </summary>
    public double? Amount { get; set; }

    /// <summary>
    /// Gets or sets the country from which the other income is derived.
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Gets or sets the start date of receiving this other income, in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets information regarding the responsible party's share of the income.
    /// </summary>
    public ResponsibilityPercentage? ResponsibilityPercentage { get; set; }

    /// <summary>
    /// Gets or sets the related loan application entity for this other income.
    /// </summary>
    public LoanApplication? OtherIncome_LoanApplication { get; set; }
}
