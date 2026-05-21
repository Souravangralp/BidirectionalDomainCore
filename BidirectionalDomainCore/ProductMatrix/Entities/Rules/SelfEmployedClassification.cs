namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification rules for self-employed entities within the product matrix,
/// including characteristics such as loan type, documentation, time in business, taxation, and company status.
/// </summary>
public class SelfEmployedClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the core database general lookup of the loan type.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the core database general lookup of the document type.
    /// </summary>
    public int? DocType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the required minimum time in months for self-employment.
    /// </summary>
    public required double MinimumTimeInMonths { get; set; }

    /// <summary>
    /// Gets or sets the allowed maximum time in months for self-employment.
    /// </summary>
    public required double MaximumTimeInMonths { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the core database general lookup of the taxation status type.
    /// </summary>
    public int? TaxationStatusType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the company is taxed.
    /// </summary>
    public bool ISTaxedCompany { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the company is onshore.
    /// </summary>
    public bool ISOnshoreCompany { get; set; }

    /// <summary>
    /// Gets or sets the number of heedful points associated with the classification.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
