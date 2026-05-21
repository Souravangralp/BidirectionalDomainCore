namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a company director associated with a loan application,
/// containing directorship details and the related self-employed profile.
/// </summary>
public class Director : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related self-employed entity, if applicable.
    /// </summary>
    public int? Director_SelfEmploymentDetailID { get; set; }

    /// <summary>
    /// Gets or sets the number of directorships held by the director.
    /// </summary>
    public int? DirectorshipCount { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the director.
    /// </summary>
    public string? DirectorID { get; set; }

    /// <summary>
    /// Gets or sets the associated self-employed entity for the director.
    /// </summary>
    public SelfEmploymentDetail? Director_SelfEmploymentDetail { get; set; }
}
