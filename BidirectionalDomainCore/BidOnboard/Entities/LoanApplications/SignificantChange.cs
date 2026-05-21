namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a significant change impacting a loan application, used for responsible lending assessment. 
/// Tracks details such as type of change, its description, financial impact, time period, and its relation to responsible lending circumstances.
/// </summary>
public class SignificantChange
{
    /// <summary>
    /// Gets or sets the unique identifier for the significant change.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the related circumstances for responsible lending entity.
    /// </summary>
    public int? SignificantChange_CircumstancesForResponsibleLendingID { get; set; }

    /// <summary>
    /// Gets or sets the type or name of the significant change.
    /// </summary>
    public string? Change { get; set; }

    /// <summary>
    /// Gets or sets a detailed description of the significant change.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the estimated monthly financial impact of this change.
    /// </summary>
    public string? MonthlyFinancialImpact { get; set; }

    /// <summary>
    /// Gets or sets the UTC start date of the period during which this change applies.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC end date of the period during which this change applies.
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? EndDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the related circumstances for responsible lending.
    /// </summary>
    public CircumstancesForResponsibleLending? SignificantChange_CircumstancesForResponsibleLending { get; set; }
}
