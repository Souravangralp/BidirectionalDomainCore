using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a company applicant associated with a loan application,
/// capturing company information, financials, roles, identity details, and related entities.
/// </summary>
public class CompanyApplicant : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the lookup ID for the applicant type.
    /// </summary>
    public int? CompanyType_GeneralLookUpID { get; set; } //We will get this from GeneralLookUp

    /// <summary>
    /// Gets or sets the registered company name.
    /// </summary>
    public string? CompanyName { get; set; }

    public int? IndustryTypeID { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public string? IncorporationCountry { get; set; }

    public decimal? AnnualRevenue { get; set; }

    public decimal? NetProfit { get; set; }

    public decimal? NetAssets { get; set; }

    public decimal? TotalLiabilities { get; set; }

    /// <summary>
    /// Gets or sets the applicant's Equifax credit score.
    /// </summary>
    public int? EquifaxCreditScore { get; set; }

    #region below are Company Identity Details Section 9d

    /// <summary>
    /// Gets or sets the UTC date when the company name started.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? NameStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of the last ASIC search.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? LastASICSearchDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC incorporation date of the company.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? IncorporationDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC file creation date.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? FileCreateDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of the ACN review.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ACNReviewDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the company started operations.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? CompanyStartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the current status of the company.
    /// </summary>
    public string? CompanyStatus { get; set; }

    /// <summary>
    /// Gets or sets the state where the company is incorporated.
    /// </summary>
    public string? IncorporationState { get; set; }

    /// <summary>
    /// Gets or sets the ASIC document number.
    /// </summary>
    public string? ASICDocumentNumber { get; set; } // Australian Securities and Investments Commission

    /// <summary>
    /// Gets or sets the file number associated with the company.
    /// </summary>
    public string? FileNumber { get; set; }

    /// <summary>
    /// Gets or sets the principal business activity of the company.
    /// </summary>
    public string? PrincipalBusinessActivity { get; set; }

    /// <summary>
    /// Gets or sets the address of the registered office.
    /// </summary>
    public string? RegisteredOffice { get; set; }

    /// <summary>
    /// Gets or sets the principal place of business of the company.
    /// </summary>
    public string? PrincipalPlaceOfBusiness { get; set; }

    /// <summary>
    /// Gets or sets the class of the company.
    /// </summary>
    public string? CompanyClass { get; set; }

    /// <summary>
    /// Gets or sets the subclass of the company.
    /// </summary>
    public string? CompanySubClass { get; set; }

    /// <summary>
    /// Gets or sets the previous state number.
    /// </summary>
    public string? PreviousStateNumber { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }
    #endregion

    /// <summary>
    /// Gets or sets a value indicating whether there are unpaid defaults.
    /// </summary>
    public bool ISDefaultUnpaid { get; set; }

    /// <summary>
    /// Gets or sets the amount of default unpaid, if any.
    /// </summary>
    public double? DefaultUnpaidAmount { get; set; }

    /// <summary>
    /// Gets or sets the amount in council arrears, if any.
    /// </summary>
    public double? CouncilArrearsAmount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the director is banned or disqualified.
    /// </summary>
    public bool IsBannedOrDisqualifiedDirector { get; set; }

    /// <summary>
    /// Gets or sets the reason for being a banned or disqualified director.
    /// </summary>
    public string? BannedDisqualifiedDirectorReason { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether trading occurred while insolvent.
    /// </summary>
    public bool ISTradingWhilstInsolvent { get; set; }

    /// <summary>
    /// Gets or sets information regarding trading whilst insolvent.
    /// </summary>
    public string? TradingWhilstInsolvent { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if a court winding up order exists.
    /// </summary>
    public bool ISCourtWindingUpOrder { get; set; }

    /// <summary>
    /// Gets or sets information regarding a court winding up order.
    /// </summary>
    public string? CourtWindingUpOrder { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if voluntary administration was placed.
    /// </summary>
    public bool HASPlacedVoluntaryAdministration { get; set; }

    /// <summary>
    /// Gets or sets information regarding voluntary administration.
    /// </summary>
    public string? PlacedVoluntaryAdministration { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if the company has been subjected to a petition.
    /// </summary>
    public bool HASSubjectedToPetition { get; set; }

    /// <summary>
    /// Gets or sets information regarding being subjected to a petition.
    /// </summary>
    public string? SubjectedToPetition { get; set; }

    /// <summary>
    /// Gets or sets a value indicating if the company has been subjected to foreclosure or bailout.
    /// </summary>
    public bool HASSubjectedToForeclosureBailout { get; set; }

    /// <summary>
    /// Gets or sets information regarding being subjected to foreclosure or bailout.
    /// </summary>
    public string? SubjectedToForeclosureORBailout { get; set; }

    /// <summary>
    /// Gets or sets the contact information for the company applicant.
    /// </summary>
    public Contact? Contact { get; set; }

    /// <summary>
    /// Gets or sets the list of company incomes for the applicant.
    /// </summary>
    public IList<CompanyIncome> CompanyIncomes { get; set; } = new List<CompanyIncome>();

    /// <summary>
    /// Gets or sets the list of company financials for the applicant.
    /// </summary>
    public IList<CompanyFinancial> CompanyFinancials { get; set; } = new List<CompanyFinancial>();

    /// <summary>
    /// Gets or sets the company scores associated with the applicant.
    /// </summary>
    public CompanyScore? CompanyScores { get; set; } // MST 009 108 Section 9a

    /// <summary>
    /// Gets or sets the company shares information.
    /// </summary>
    public CompanyShare? CompanyShares { get; set; } // MST 009 108 Section 9n

    /// <summary>
    /// Gets or sets the company business registration information.
    /// </summary>
    public BusinessIdentifier? BusinessIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the company address information.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// Gets or sets the industry classification information.
    /// </summary>
    public IndustryClassification? IndustryClassifications { get; set; } // MST 009 108 Section 9e

    /// <summary>
    /// Gets the list of court judgements related to the company applicant.
    /// </summary>
    public IList<CourtJudgement> CourtJudgment { get; private set; } = new List<CourtJudgement>();

    /// <summary>
    /// Gets or sets the list of financial responsible parties related to the company applicant.
    /// </summary>
    public IList<FinancialResponsible> FinancialResponsibles { get; set; } = new List<FinancialResponsible>();

    /// <summary>
    /// Gets or sets the list of liability securities related to the company applicant.
    /// </summary>
    public IList<LiabilitySecurity> LiabilitySecurities { get; set; } = new List<LiabilitySecurity>();

    public List<Applicant> Applicants { get; set; } = []; // Applicant may be director/manager and other user.

    [InverseProperty(nameof(LoanApplicationApplicantMapper.LoanApplicationApplicantMapper_CompanyApplicant))]
    public IList<LoanApplicationApplicantMapper> LoanApplicationApplicantMappers { get; set; } = [];
}
