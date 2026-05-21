namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details and attributes of a construction project within a loan application,
/// including builder information, cost components, permits, green rating, and related construction metadata.
/// </summary>
public class Construction : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID linking to the related loan purpose detail specific to construction.
    /// </summary>
    public int? Construction_LoanPurposeDetailID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a front-end loaded progress draw down schedule is being sought.
    /// </summary>
    [Comment("Seeking a front end loaded progress draw down schedule")]
    public bool ISSeekingDrawDownSchedule { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the construction is MST approved or verified.
    /// </summary>
    public bool ISMSTApprovedORVerified { get; set; }

    /// <summary>
    /// Gets or sets the construction type lookup ID from the core database.
    /// </summary>
    public int? ConstructionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the builder type lookup ID from the core database.
    /// </summary>
    public int? BuilderType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the risk management construction type lookup ID from the core database.
    /// </summary>
    public int? RiskManagementConstructionType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the construction stage lookup ID from the core database.
    /// </summary>
    public int? ConstructionStage_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is green rated.
    /// </summary>
    public bool? ISGreenRated { get; set; }

    /// <summary>
    /// Gets or sets the green rating score, if available.
    /// </summary>
    public double? GreenRating { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the construction is for renovation.
    /// </summary>
    public bool? ISRenovation { get; set; }

    /// <summary>
    /// Gets or sets the structural change type lookup ID from the core database.
    /// </summary>
    public int? StructuralChangeType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the cost of the land for the construction.
    /// </summary>
    public double? LandCost { get; set; }

    /// <summary>
    /// Gets or sets the cost of improvements for the construction.
    /// </summary>
    public double? CostOfImprovement { get; set; }

    /// <summary>
    /// Gets or sets the final total cost of the construction.
    /// </summary>
    public double? FinalCost { get; set; }

    /// <summary>
    /// Gets or sets the number of months until the start of construction.
    /// </summary>
    public int? StartConstructionInMonths { get; set; }

    /// <summary>
    /// Gets or sets the number of months to complete the construction.
    /// </summary>
    public int? CompleteConstructionInMonths { get; set; }

    /// <summary>
    /// Gets or sets the name of the builder.
    /// </summary>
    public string? BuilderName { get; set; }

    /// <summary>
    /// Gets or sets the name of the green licensed builder.
    /// </summary>
    public string? GreenLicensedBuilderName { get; set; }

    /// <summary>
    /// Gets or sets the name of the owner builder.
    /// </summary>
    public string? OwnerBuilderName { get; set; }

    /// <summary>
    /// Gets or sets the permit details for the owner builder.
    /// </summary>
    public string? OwnerBuilderPermit { get; set; }

    /// <summary>
    /// Gets or sets the licensed number of the owner builder.
    /// </summary>
    public string? OwnerBuilderLicensedNumber { get; set; }

    /// <summary>
    /// Gets or sets the permit number for the owner builder.
    /// </summary>
    public string? OwnerBuilderPermitNumber { get; set; }

    /// <summary>
    /// Gets or sets the license number of the builder.
    /// </summary>
    public string? BuilderLicenseNumber { get; set; }

    /// <summary>
    /// Gets or sets the license number of the green licensed builder.
    /// </summary>
    public string? GreenLicensedBuilderLicensedNumber { get; set; }

    /// <summary>
    /// Gets or sets the state where the builder holds a license.
    /// </summary>
    public string? BuilderStateLicenseHeld { get; set; }

    /// <summary>
    /// Gets or sets the Australian Business Number (ABN) of the builder or related entity.
    /// </summary>
    public string? ABN { get; set; }

    /// <summary>
    /// Gets or sets the Australian Company Number (ACN) of the builder or related entity.
    /// </summary>
    public string? ACN { get; set; }

    /// <summary>
    /// Gets or sets the NatHERS 7-star certification number under the Nationwide House Energy Rating Scheme.
    /// </summary>
    [Comment("----((Nationwide House Energy Rating Scheme))-----, <------ NatHERS 7-starCertification number")]
    public string? NatHERSSevenStarCertificationNumber { get; set; }

    /// <summary>
    /// Gets or sets the owner's name.
    /// </summary>
    public string? OwnersName { get; set; }

    /// <summary>
    /// Gets or sets the owner's mobile number.
    /// </summary>
    public string? OwnerMobileNumber { get; set; }

    /// <summary>
    /// Gets or sets the owner's email address.
    /// </summary>
    public string? OwnerEmail { get; set; }

    /// <summary>
    /// Gets or sets the director identification number relevant to the construction.
    /// </summary>
    public string? DirectorIdentificationNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of the drawdown administrator.
    /// </summary>
    public string? DrawdownAdministratorName { get; set; }

    /// <summary>
    /// Gets or sets the mobile number of the drawdown administrator.
    /// </summary>
    public string? DrawdownAdministratorMobileNumber { get; set; }

    /// <summary>
    /// Gets or sets the email address of the drawdown administrator.
    /// </summary>
    public string? DrawdownAdministratorEmail { get; set; }

    /// <summary>
    /// Gets or sets the collection of construction bank account signatory details.
    /// </summary>
    public IList<ConstructionBankAccountSignatoryDetail> ConstructionBankAccountSignatoryDetails { get; set; } = new List<ConstructionBankAccountSignatoryDetail>();

    /// <summary>
    /// Gets or sets the navigation property linking to the related loan purpose detail for construction.
    /// </summary>
    public LoanPurposeDetail? Construction_LoanPurposeDetail { get; set; }
}
