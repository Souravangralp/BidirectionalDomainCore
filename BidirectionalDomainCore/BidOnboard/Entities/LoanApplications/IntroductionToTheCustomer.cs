namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the introduction details and background information collected about a customer as part of a loan application process.
/// </summary>
public class IntroductionToTheCustomer : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the associated loan application.
    /// </summary>
    public int? IntroductionToTheCustomer_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the ID of the associated applicant.
    /// </summary>
    public int? IntroductionToTheCustomer_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the ID of the associated company applicant.
    /// </summary>
    public int? IntroductionToTheCustomer_CompanyApplicantID { get; set; }

    /// <summary>
    /// Gets or sets the age of the borrower.
    /// </summary>
    public string? BorrowersAge { get; set; }

    /// <summary>
    /// Gets or sets the Equifax credit score for the borrower.
    /// </summary>
    public string? BorrowersEquifaxScore { get; set; }

    /// <summary>
    /// Gets or sets the age of the borrower's credit report.
    /// </summary>
    public string? BorrowerAgeOfReport { get; set; }

    /// <summary>
    /// Gets or sets the occupation of the borrower.
    /// </summary>
    public string? BorrowersOccupation { get; set; }

    /// <summary>
    /// Gets or sets the age of the guarantor.
    /// </summary>
    public string? GuarantorAge { get; set; }

    /// <summary>
    /// Gets or sets the Equifax credit score for the guarantor.
    /// </summary>
    public string? GuarantorsEquifaxScore { get; set; }

    /// <summary>
    /// Gets or sets the age of the guarantor's credit report.
    /// </summary>
    public string? GuarantorAgeOfReport { get; set; }

    /// <summary>
    /// Gets or sets the age of the dependent.
    /// </summary>
    public string? DependentAge { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the individual is a politically exposed person.
    /// </summary>
    public bool ISPoliticallyExposedPerson { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the result of the fraud check.
    /// </summary>
    public bool FraudCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a fraud check match was found. True means match.
    /// </summary>
    [Comment("true Means Match")]
    public bool HASFraudCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a sanction match was found.
    /// </summary>
    public bool HASSanction { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the velocity check has been performed.
    /// </summary>
    public bool HasVelocityCheck { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the result of the AML (Anti-Money Laundering) check. True means pass.
    /// </summary>
    [Comment("true Means Pass")]
    public bool AMLCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the result of the OFAC check.
    /// </summary>
    public bool OFACCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the result of the DFAT check.
    /// </summary>
    public bool DFATCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the result of the ID biometric verification.
    /// </summary>
    public bool IDBiometricVerificationResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the result of the ID matrix verification. True means accept.
    /// </summary>
    [Comment("true Means Accept")]
    public bool IDMatrixVerificationResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the result of the KYC (Know Your Customer) verification.
    /// </summary>
    public bool KYCVerificationResult { get; set; }

    /// <summary>
    /// Gets or sets additional information about any existing loans with MSt.
    /// </summary>
    [Comment("Details of any existing loans with MSt")]
    public string? AdditionalDescription { get; set; }

    /// <summary>
    /// Gets or sets the name of the employer.
    /// </summary>
    public string? EmployerName { get; set; }

    /// <summary>
    /// Gets or sets the full name of the employer.
    /// </summary>
    public string? EmployerNameInFull { get; set; }

    /// <summary>
    /// Gets or sets the duration at the current employer (in years or months).
    /// </summary>
    public int? TimeAtCurrentEmployer { get; set; }

    /// <summary>
    /// Gets or sets the status and observations regarding the customer's employment.
    /// </summary>
    [Comment("Status & observations")]
    public int? CustomerEmploymentStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number of years the customer has spent in their current field.
    /// </summary>
    public int? YearsInCurrentField { get; set; }

    /// <summary>
    /// Gets or sets the customer's highest level of tertiary qualifications.
    /// </summary>
    public string? TTertiaryQualificationsLevel { get; set; }

    /// <summary>
    /// Gets or sets the industry type in which the customer is employed.
    /// </summary>
    public string? IndustryType { get; set; }

    /// <summary>
    /// Gets or sets a summary of the company.
    /// </summary>
    public CompanySummary? CompanySummary { get; set; }

    /// <summary>
    /// Gets or sets the identity information of the company.
    /// </summary>
    public CompanyIdentity? CompanyIdentity { get; set; }

    /// <summary>
    /// Gets or sets a list of public records related to the customer or company.
    /// </summary>
    public IList<PublicRecordInformation> PublicRecordsInformation { get; set; } = new List<PublicRecordInformation>();

    //public IList<CreditHistorySnapshot> CreditHistorySnapshots { get; set; } = new List<CreditHistorySnapshot>();

    //public TradePayment? TradePayment { get; set; }

    /// <summary>
    /// Gets or sets the details of the Australian Business Number.
    /// </summary>
    public AustralianBusinessNumberDetail? AustralianBusinessNumberDetail { get; set; }

    /// <summary>
    /// Gets or sets the industry classification details.
    /// </summary>
    public IndustryClassification? IndustryClassification { get; set; }

    /// <summary>
    /// Gets or sets a list of company directors.
    /// </summary>
    public IList<CompanyDirector> CompanyDirectors { get; set; } = new List<CompanyDirector>();

    /// <summary>
    /// Gets or sets a list of current company secretaries.
    /// </summary>
    public IList<CompanyCurrentSecretary> CompanyCurrentSecretaries { get; set; } = new List<CompanyCurrentSecretary>();

    /// <summary>
    /// Gets or sets a list of business proprietorships held under the company.
    /// </summary>
    public IList<CompanyBusinessProprietorship> CompanyBusinessProprietorships { get; set; } = new List<CompanyBusinessProprietorship>();

    /// <summary>
    /// Gets or sets a list of company shares.
    /// </summary>
    public IList<CompanyShare> CompanyShares { get; set; } = new List<CompanyShare>();

    /// <summary>
    /// Gets or sets a list of current company shareholders.
    /// </summary>
    public IList<CompanyCurrentShareholder> CompanyCurrentShareholders { get; set; } = new List<CompanyCurrentShareholder>();

    /// <summary>
    /// Gets or sets a list of beneficial ownerships of the company.
    /// </summary>
    public IList<CompanyBeneficialOwnership> CompanyBeneficialOwnerships { get; set; } = new List<CompanyBeneficialOwnership>();

    /// <summary>
    /// Gets or sets a list of company credit enquiries.
    /// </summary>
    public IList<CompanyCreditEnquiry> CompanyCreditEnquiries { get; set; } = new List<CompanyCreditEnquiry>();

    /// <summary>
    /// Gets or sets a list of company addresses.
    /// </summary>
    public IList<CompanyAddress> CompanyAddresses { get; set; } = new List<CompanyAddress>();

    /// <summary>
    /// Gets or sets a list of documents associated with the loan application.
    /// </summary>
    public IList<Document> Documents { get; set; } = new List<Document>();

    //public IList<IncomeDossier> IncomeDossiers { get; set; } = new List<IncomeDossier>();

    //public IList<FileMessage> FileMessages { get; set; } = new List<FileMessage>();

    /// <summary>
    /// Gets or sets the applicant associated with this record.
    /// </summary>
    public Applicant? IntroductionToTheCustomer_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the company applicant associated with this record.
    /// </summary>
    public CompanyApplicant? IntroductionToTheCustomer_CompanyApplicant { get; set; }

    /// <summary>
    /// Gets or sets the loan application associated with this record.
    /// </summary>
    public LoanApplication? IntroductionToTheCustomer_LoanApplication { get; set; }
}
