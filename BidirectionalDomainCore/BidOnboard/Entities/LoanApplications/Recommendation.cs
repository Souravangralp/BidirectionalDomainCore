namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a recommendation entity containing highlights, strengths, weaknesses, and related servicing details for a loan application.
/// </summary>
public class Recommendation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related loan application for the recommendation.
    /// </summary>
    public int? Recommendation_LoanApplicationId { get; set; }

    /// <summary>
    /// Gets or sets the scenario highlight strengths for the recommendation.
    /// </summary>
    [TextClass(TextFieldClass.Comment)]
    public string? ScenarioHighlightStrength { get; set; }

    /// <summary>
    /// Gets or sets the scenario highlight weaknesses for the recommendation.
    /// </summary>
    [TextClass(TextFieldClass.Comment)]
    public string? ScenarioHighlightWeakness { get; set; }

    /// <summary>
    /// Gets or sets the scenario highlight mitigants for the recommendation.
    /// </summary>
    [TextClass(TextFieldClass.Comment)]
    public string? ScenarioHighlightMitigants { get; set; }

    /// <summary>
    /// Gets or sets the servicing strengths related to the recommendation.
    /// </summary>
    [TextClass(TextFieldClass.Comment)]
    public string? ServicingStrength { get; set; }

    /// <summary>
    /// Gets or sets the servicing weaknesses related to the recommendation.
    /// </summary>
    [TextClass(TextFieldClass.Comment)]
    public string? ServicingWeakness { get; set; }

    /// <summary>
    /// Gets or sets the servicing mitigant related to the recommendation.
    /// </summary>
    [TextClass(TextFieldClass.Comment)]
    public string? ServicingMitigant { get; set; }

    /// <summary>
    /// Gets or sets the related <see cref="LoanApplication"/> entity for this recommendation.
    /// </summary>
    public LoanApplication? Recommendation_LoanApplication { get; set; }

    #region Remove fields

    /// <summary>
    /// Gets or sets the name of the approval officer associated with the recommendation.
    /// </summary>
    public string? ApprovalOfficer { get; set; }

    /// <summary>
    /// Gets or sets the office number, as per client response, changed from MobileNumber to OfficeNumber.
    /// </summary>
    [Comment("As per client response, we changed from MobileNumber(in MSt009 144) to OfficeNumber")]
    public string? OfficeNumber { get; set; }

    /// <summary>
    /// Gets or sets the email address associated with the recommendation.
    /// </summary>
    public string? EmailAddress { get; set; }

    #endregion
}
