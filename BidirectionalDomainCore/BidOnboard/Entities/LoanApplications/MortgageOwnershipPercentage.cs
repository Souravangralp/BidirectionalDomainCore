namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an entity for tracking a registered owner's percentage share of a mortgage.
/// </summary>
public class MortgageOwnershipPercentage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the associated mortgage.
    /// </summary>
    public int MortgageOwnershipPercentage_MortgageID { get; set; }

    /// <summary>
    /// Gets or sets the name of the registered owner associated with this mortgage percentage.
    /// </summary>
    public string? RegisteredOwner { get; set; }

    /// <summary>
    /// Gets or sets the percentage share held by the registered owner.
    /// </summary>
    public double? PercentShared { get; set; }

    /// <summary>
    /// Gets or sets the mortgage entity associated with the ownership percentage.
    /// </summary>
    public Mortgage? MortgageOwnershipPercentage_Mortgage { get; set; }
}
