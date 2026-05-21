using Bidirectional.DomainCore.BidOnboard.Enums;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a motor vehicle asset associated with a loan application, including its details,
/// security status, ownership structure, and related encumbrances.
/// </summary>
public class MotorVehicle : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the quantity of motor vehicles.
    /// </summary>
    public string? Quantity { get; set; }

    /// <summary>
    /// Gets or sets the estimated value of the motor vehicle.
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or sets the make of the motor vehicle.
    /// </summary>
    public string? Make { get; set; }

    /// <summary>
    /// Gets or sets the model of the motor vehicle.
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Gets or sets the type of the motor vehicle (e.g., sedan, SUV, truck).
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the manufacturing year of the motor vehicle.
    /// </summary>
    public string? Year { get; set; }

    /// <summary>
    /// Gets or sets the security status of the motor vehicle asset.
    /// </summary>
    public AssetSecurityStatus AssetSecurityStatus { get; set; }

    /// <summary>
    /// Gets or sets the origin of the motor vehicle asset.
    /// </summary>
    public AssetOrigin AssetOrigin { get; set; }

    /// <summary>
    /// Gets or sets the refinancing status if the property is being refinanced.
    /// </summary>
    public PropertyRefinanceStatus RefinancingStatus { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the asset is encumbered.
    /// </summary>
    public bool ISEncumbered { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the asset is to be used as security.
    /// </summary>
    public bool ISToBeUsedAsSecurity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the asset is to be sold.
    /// </summary>
    public bool ISToBeSold { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the asset has a contract of sale.
    /// </summary>
    public bool ISContractOfSale { get; set; }

    /// <summary>
    /// Gets or sets the basis for the valuation or acquisition of the asset.
    /// </summary>
    public string? Basis { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the collection of percent owners for this non-real estate asset.
    /// </summary>
    public IList<NonRealEstateAssetOwnershipPercentage> NonRealEstateAssetOwnershipPercentages { get; set; } = new List<NonRealEstateAssetOwnershipPercentage>();

    /// <summary>
    /// Gets or sets the collection of encumbered assets related to this motor vehicle.
    /// </summary>
    public IList<EncumberedAsset> EncumberedAssets { get; set; } = new List<EncumberedAsset>();
}
