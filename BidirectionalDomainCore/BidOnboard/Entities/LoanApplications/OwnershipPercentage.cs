namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the ownership percentage associated with a related entity within a loan application, 
/// capturing details such as the related entity, the type of owner, and the ownership percentage value.
/// </summary>
public class OwnershipPercentage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related entity to which the ownership percentage applies.
    /// </summary>
    public int? OwnershipPercentage_RelatedEntityID { get; set; }

    /// <summary>
    /// Gets or sets the owner type identifier from the GeneralLookUp table.
    /// </summary>
    [Comment("We will get this from GeneralLookUpTable")]
    public int? OwnerType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the ownership percentage value.
    /// </summary>
    public string? OwnershipPercentageValue { get; set; }

    /// <summary>
    /// Gets or sets the related entity navigation property for which this ownership percentage is defined.
    /// </summary>
    public RelatedEntity? OwnershipPercentage_RelatedEntity { get; set; }
}
