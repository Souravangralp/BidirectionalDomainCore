namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the default listing rules and their parameters for loan products.
/// </summary>
public class DefaultListing : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID from the core database that represents the loan type.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the minimum number of months for the default listing range.
    /// </summary>
    public double? DefaultListingMinMonths { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of months for the default listing range.
    /// </summary>
    public double? DefaultListingMaxMonths { get; set; }
}
