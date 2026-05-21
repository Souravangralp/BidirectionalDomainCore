namespace Bidirectional.DomainCore.ProductMatrix.Entities.Postcodes;

/// <summary>
/// Represents a mapping of postcode specifications to their associated CoreDB lookup IDs.
/// </summary>
public class PostcodeSpecificationMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the Loan Type CoreDB General Lookup ID associated with the postcode.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the PC Category Type CoreDB General Lookup ID associated with the postcode.
    /// </summary>
    public int? PCCategoryType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the High Security Type CoreDB General Lookup ID associated with the postcode.
    /// </summary>
    public int? HighSecurityType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the Standard and Poor CoreDB General Lookup ID associated with the postcode.
    /// </summary>
    public int? StandardAndPoor_CoreDB_GeneralLookUpID { get; set; }
}
