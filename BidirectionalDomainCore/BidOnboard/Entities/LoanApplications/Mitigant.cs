namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a mitigant factor within responsible lending, providing details about factors and descriptions linked to specific circumstances.
/// </summary>
public class Mitigant : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated circumstances for responsible lending.
    /// </summary>
    public int? Mitigant_CircumstancesForResponsibleLendingID { get; set; }

    /// <summary>
    /// Gets or sets the name or label of the mitigant factor.
    /// </summary>
    public string? Factor { get; set; }

    /// <summary>
    /// Gets or sets the related circumstances for responsible lending entity associated with this mitigant.
    /// </summary>
    public CircumstancesForResponsibleLending? Mitigant_CircumstancesForResponsibleLending { get; set; }
}
