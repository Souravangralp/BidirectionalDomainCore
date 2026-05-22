namespace Bidirectional.DomainCore.Postcode.Entities.Mappers;

/// <summary>
/// Represents the mapping of postcode specification data, including classification identifiers and their related entities.
/// </summary>
public class PostcodeSpecificationMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the S and P postcode classification.
    /// </summary>
    public int? PostcodeClassification_SAndPID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the High Security postcode classification.
    /// </summary>
    public int? PostcodeClassification_HighSecurityID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the PC Category postcode classification.
    /// </summary>
    public int? PostcodeClassification_PCCategoryID { get; set; }

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

    /// <summary>
    /// Gets or sets the PC Category postcode classification entity.
    /// </summary>
    public PostcodeClassification? PostcodeClassification_PCCategory { get; set; }

    /// <summary>
    /// Gets or sets the High Security postcode classification entity.
    /// </summary>
    public PostcodeClassification? PostcodeClassification_HighSecurity { get; set; }

    /// <summary>
    /// Gets or sets the S and P postcode classification entity.
    /// </summary>
    public PostcodeClassification? PostcodeClassification_SAndP { get; set; }
}
