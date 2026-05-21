namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a declaration made by the broker regarding a loan application, 
/// capturing required confirmations and disclosures as part of the loan application process.
/// </summary>
public class BrokerDeclaration : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the associated loan application.
    /// </summary>
    public int? BrokerDeclaration_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether interest only requirements have been met.
    /// </summary>
    public bool ISInterestOnlyMeetsRequirement { get; set; }

    /// <summary>
    /// Gets or sets the description of how the interest only requirements are met.
    /// </summary>
    public string? InterestOnlyMeetsRequirementDescription { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the risks of interest only have been explained.
    /// </summary>
    public bool ISInterestOnlyRisksExplained { get; set; }

    /// <summary>
    /// Gets or sets the description of the explanation given for interest only risks.
    /// </summary>
    public string? InterestOnlyRiskExplanationDescription { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether any of the applicants are related to the broker.
    /// </summary>
    [Comment("Are any of the applicants related to you")]
    public bool ISAnyApplicantRelatedToYou { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether any applicant is directly related to the broker.
    /// </summary>
    public bool ISAnyApplicantDirectlyRelatedToYou { get; set; }

    public string? ApplicantRelationshipDetails { get; set; }

    /// <summary>
    /// Gets or sets the type identifier describing the relationship of applicants to the broker.
    /// </summary>
    [Comment("Are any of the applicants related to you")]
    public int? ApplicantRelatedToYouType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the broker benefits financially from any other sources related to the application.
    /// </summary>
    [Comment("Do you financial benefit from any other source")]
    public bool ISThereAnyFinancialBenefitSource { get; set; }

    /// <summary>
    /// Gets or sets the type identifier for the source of financial benefit.
    /// </summary>
    [Comment("Do you financial benefit from any other source")]
    public int? FinancialBenefitSourceType_GeneralLookUpID { get; set; }

    public string? ApplicantBenefitDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether additional fees are charged to customers.
    /// </summary>
    [Comment("Do you charge customers any additional fees")]
    public bool HASAdditionalFeesChargedFromCustomer { get; set; }

    /// <summary>
    /// Gets or sets the type identifier for the additional fees charged from customers.
    /// </summary>
    [Comment("Do you charge customers any additional fees")]
    public int? AdditionalFeesChargedFromCustomerType_GeneralLookUpID { get; set; }

    public string? ApplicantAdditionalFeesDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the broker personally knows the applicants.
    /// </summary>
    [Comment("Do you know the applicants personally")]
    public bool ISApplicantPersonallyWellKnown { get; set; }

    /// <summary>
    /// Gets or sets the type identifier for how the broker knows the applicants personally.
    /// </summary>
    [Comment("Do you know the applicants personally")]
    public int? ApplicantPersonallyWellKnownType_GeneralLookUpID { get; set; }

    public string? ApplicantPersonalWellKnownDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether all the information in the application is accurate.
    /// </summary>
    [Comment("Is all the information in this application accurate?")]
    public bool ISAccurateInformationProvided { get; set; }

    /// <summary>
    /// Gets or sets the type identifier for inaccurate information provided.
    /// </summary>
    [Comment("Is all the information in this application accurate?")]
    public int? InaccurateInformationProvidedType_GeneralLookUpID { get; set; }

    public string? AccurateInformationProvidedDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether any applicant benefits financially from the broker.
    /// </summary>
    [Comment("Does the applicant benefit financially from you")]
    public bool ISApplicantFinanciallyBenefitsFromYou { get; set; }

    /// <summary>
    /// Gets or sets the type identifier for the financial benefit to applicants from the broker.
    /// </summary>
    [Comment("Does the applicant benefit financially from you")]
    public int? ApplicantFinanciallyBenefitType_GeneralLookUpID { get; set; }

    public string? ApplicantFinanciallyBenefitsFromYouDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the broker has complied with all regulatory requirements.
    /// </summary>
    [Comment("Have you complied with all regulatory requirements?")]
    public bool HASCompliedWithRegulatoryRequirements { get; set; }

    /// <summary>
    /// Gets or sets the type identifier for requirements not complied with.
    /// </summary>
    [Comment("Have you complied with all regulatory requirements?")]
    public int? NotCompliedWithRegulatoryRequirementType_GeneralLookUpID { get; set; }

    public string? CompliedWithRegulatoryRequirementDetails { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the product has been assessed as suitable for the customer.
    /// </summary>
    [Comment("The product(s) has been assessed as NOT UNSUITABLE for the customer?")]
    public bool ISProductAssessedSuitable { get; set; }

    /// <summary>
    /// Gets or sets the associated loan application entity reference.
    /// </summary>
    public LoanApplication? BrokerDeclaration_LoanApplication { get; set; }
}
