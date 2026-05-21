using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents feedback and indication details associated with a loan application, including property information, risk attributes, event data, and borrower classification.
/// </summary>
public class FeedbackAndIndication : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier linking to the associated loan application.
    /// </summary>
    public int? FeedbackAndIndication_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier linking to the associated loan security.
    /// </summary>
    public int? FeedbackAndIndication_LoanSecurityID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the product has been confirmed.
    /// </summary>
    public bool IsProductConfirmed { get; set; }

    /// <summary>
    /// Gets or sets the address information related to the feedback and indication.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// Gets or sets the number of dwellings on a single title.
    /// </summary>
    public int? NumberOfDwellingSingleTitle { get; set; }

    /// <summary>
    /// Gets or sets the council zoning classification.
    /// </summary>
    public string? CouncilZoning { get; set; }

    /// <summary>
    /// Gets or sets the usage type identifier from the general lookup table.
    /// </summary>
    public int? UsageType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the postcode capital information. (Use Address table for reference.)
    /// </summary>
    [Comment("we shall use Address table for this")]
    public string? PostcodeCapital { get; set; }

    /// <summary>
    /// Gets or sets the Standard & Poor's rating.
    /// </summary>
    [Comment("Standard & Poor's Rating")]
    public string? SAndP { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a direct credit card is involved.
    /// </summary>
    public bool ISDirectCreditCard { get; set; }

    /// <summary>
    /// Gets or sets the land size of the property.
    /// </summary>
    public double? LandSize { get; set; }

    /// <summary>
    /// Gets or sets the internal living area measurement.
    /// </summary>
    public double? InternalLivingArea { get; set; }

    /// <summary>
    /// Gets or sets the required loan amount.
    /// </summary>
    public double? LoanAmountRequired { get; set; }

    /// <summary>
    /// Gets or sets the assessed security value.
    /// </summary>
    public double? SecurityValue { get; set; }

    /// <summary>
    /// Gets or sets the loan-to-value ratio (LVR).
    /// </summary>
    public double? LVR { get; set; }

    /// <summary>
    /// Gets or sets the feedback observation type identifier from the general lookup table.
    /// </summary>
    public int? FeedbackObservationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the security is classified as high density.
    /// </summary>
    public bool ISHighDensity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is classified as non-metro.
    /// </summary>
    public bool ISNonMetro { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is classified as metro plus.
    /// </summary>
    public bool ISMetroPlus { get; set; }

    /// <summary>
    /// Gets or sets the postcode classification type identifier from the general lookup table.
    /// </summary>
    public int? PostcodeClassificationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the security classification type identifier from the general lookup table.
    /// </summary>
    public int? SecurityClassificationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the borrower type identifier from the general lookup table.
    /// </summary>
    public int? BorrowingEntityType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the residential type identifier from the general lookup table.
    /// </summary>
    public int? ResidentialType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the reference number for a skilled migrant visa subclass if required by residential type.
    /// </summary>
    [EncryptColumn]
    [Comment("Skilled migrant visa sub class reference number if selected the same residential type")]
    public string? VisaSubClassReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the population of the area related to the property.
    /// </summary>
    public double? Population { get; set; }

    /// <summary>
    /// Gets or sets the date the feedback was provided.
    /// </summary>
    public DateTime? FeedbackDate { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether FIRB approval has been obtained.
    /// </summary>
    public bool ISFIRBApproved { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional data (field 1).
    /// </summary>
    public double? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional data (field 2).
    /// </summary>
    public double? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional data (field 3).
    /// </summary>
    public double? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the collection of associated mortgage splits.
    /// </summary>
    public IList<MortgageSplit> MortgageSplits { get; set; } = new List<MortgageSplit>();

    /// <summary>
    /// Gets or sets the post-settlement event associated with the feedback.
    /// </summary>
    public PostSettlementEvent? PostSettlementEvent { get; set; }

    /// <summary>
    /// Gets or sets the referenced loan application entity.
    /// </summary>
    public LoanApplication? FeedbackAndIndication_LoanApplication { get; set; }

    /// <summary>
    /// Gets or sets the referenced loan security entity.
    /// </summary>
    public LoanSecurity? FeedbackAndIndication_LoanSecurity { get; set; }
}
