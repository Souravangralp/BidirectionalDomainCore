namespace Bidirectional.DomainCore.BidOnboard.Entities.Generals.Industries;

/// <summary>
/// Represents an industry with associated code, name, annual income, status, and notes.
/// </summary>
public class Industry : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique code identifying the industry.
    /// </summary>
    public string? IndustryCode { get; set; }

    /// <summary>
    /// Gets or sets the name of the industry.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the total annual income amount associated with the industry.
    /// </summary>
    public double? AnnualIncomeAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the industry is archived.
    /// </summary>
    public bool ISArchived { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the industry is rejected.
    /// </summary>
    public bool ISRejected { get; set; }

    /// <summary>
    /// Gets or sets additional notes for the industry.
    /// </summary>
    public string? AdditionalNotes { get; set; }
}
