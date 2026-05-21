namespace Bidirectional.DomainCore.ProductMatrix.Entities.Products;

/// <summary>
/// Represents the classification details of a product using numeral parameters, such as loan amount range and numeral type reference.
/// </summary>
public class NumeralClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the minimum loan amount for this numeral classification.
    /// </summary>
    public required double LoanAmountFrom { get; set; }

    /// <summary>
    /// Gets or sets the maximum loan amount for this numeral classification.
    /// </summary>
    public required double LoanAmountTo { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID referencing the numeral type in the core database.
    /// </summary>
    public int NumeralType_CoreDB_GeneralLookUpID { get; set; }
}
