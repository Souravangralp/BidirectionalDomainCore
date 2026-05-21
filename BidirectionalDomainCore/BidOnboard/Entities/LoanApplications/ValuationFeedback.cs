namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents valuation feedback details for a loan security, including property, market, vendor, and risk information.
/// </summary>
public class ValuationFeedback : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated loan security for this valuation feedback.
    /// </summary>
    public int? ValuationFeedback_LoanSecurityID { get; set; }

    /// <summary>
    /// Gets or sets the Valex reference identifier related to the valuation feedback.
    /// </summary>
    public string? ValexReference { get; set; }

    /// <summary>
    /// Gets or sets the zoning classification for the subject property.
    /// </summary>
    public string? Zoning { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID representing the property type.
    /// </summary>
    [Comment("We will get this from GeneralLook up Table")]
    public int? PropertyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID representing the property risk type.
    /// </summary>
    [Comment("We will get this from GeneralLook up Table")]
    public int? PropertyRiskType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID representing the market type.
    /// </summary>
    [Comment("We will get this from GeneralLook up Table")]
    public int? MarketType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID representing the market risk type.
    /// </summary>
    [Comment("We will get this from GeneralLook up Table")]
    public int? MarketRiskType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the name of the vendor providing the valuation feedback.
    /// </summary>
    public string? VendorName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether an arm's length transaction exists for the property.
    /// </summary>
    public bool HASArmLength { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether related entities are involved in the transaction.
    /// </summary>
    public bool HASRelatedEntities { get; set; }

    /// <summary>
    /// Gets or sets the associated loan security entity for this valuation feedback.
    /// </summary>
    public LoanSecurity? ValuationFeedback_LoanSecurity { get; set; }
}
