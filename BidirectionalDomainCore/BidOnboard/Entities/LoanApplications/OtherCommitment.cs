namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a financial commitment associated with a household that does not fall under standard loan or liability categories.
/// </summary>
public class OtherCommitment : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the household associated with this commitment.
    /// </summary>
    public int? OtherCommitment_HouseholdID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID representing the frequency type of the commitment payments.
    /// </summary>
    public int? FrequencyType_GeneralLookUpID { get; set; } // We will get this from GeneralLookUp Table

    /// <summary>
    /// Gets or sets the amount of the commitment.
    /// </summary>
    public double? Amount { get; set; }

    /// <summary>
    /// Gets or sets the category of the commitment.
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information related to the commitment.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets a second extra field for additional details.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets a third extra field for further information pertinent to the commitment.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the household entity associated with this commitment.
    /// </summary>
    public Household? OtherCommitment_Household { get; set; }

    /// <summary>
    /// Gets or sets the responsible party's percentage for this commitment.
    /// </summary>
    public ResponsibilityPercentage? ResponsibilityPercentage { get; set; }
}
