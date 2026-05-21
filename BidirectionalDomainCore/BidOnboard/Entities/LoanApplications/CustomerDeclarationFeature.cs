namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a feature associated with a customer's declaration within a loan application.
/// </summary>
public class CustomerDeclarationFeature : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related customer declaration.
    /// </summary>
    public int? CustomerDeclarationFeature_CustomerDeclarationID { get; set; }

    /// <summary>
    /// Gets or sets the feature type identifier from the GeneralLookUp table.
    /// </summary>
    public int? FeatureType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the feature category type identifier from the GeneralLookUp table.
    /// </summary>
    public int? FeatureCategoryType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets any additional comments regarding the feature.
    /// </summary>
    public string? FeatureComment { get; set; }

    /// <summary>
    /// Gets or sets the associated customer declaration entity.
    /// </summary>
    public CustomerDeclaration? CustomerDeclarationFeature_CustomerDeclaration { get; set; }
}
