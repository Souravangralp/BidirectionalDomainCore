using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents an applicant in a loan application, containing personal, contact, and financial details required for processing the loan.
/// </summary>
public class Applicant : BaseAuditableEntity
{
    public int? Applicant_CompanyApplicantID { get; set; }

    public int? Applicant_TrustID { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the customer.
    /// </summary>
    public string? CustomerID { get; set; }

    /// <summary>
    /// Gets or sets the ID referencing the name title type from the general lookup.
    /// </summary>
    public int? NameTitleType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the applicant's Equifax credit score.
    /// </summary>
    public int? EquifaxCreditScore { get; set; }

    /// <summary>
    /// Gets or sets the number of dependent children of the applicant.
    /// </summary>
    public int? NumberOfDependents { get; set; }

    /// <summary>
    /// Indicates whether the applicant is fluent in English.
    /// </summary>
    public bool IsFluentInEnglish { get; set; }

    /// <summary>
    /// Gets or sets the applicant's preferred name or nickname.
    /// </summary>
     //[EncryptColumn]
    public string? PreferredNameOrNickname { get; set; }

    /// <summary>
    /// Gets or sets the applicant's first or Christian name.
    /// </summary>
    public string? FirstNameORChristianName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's middle name.
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's middle first name.
    /// </summary>
    [Comment("As per client Request we have MiddleFirstName")]
    public string? MiddleFirstName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's middle last name.
    /// </summary>
    [Comment("As per client Request we have MiddleLastName")]
    public string? MiddleLastName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's last, surname, or family name.
    /// </summary>
    public string? LastNameORSurnameORFamilyName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's previous first or Christian name.
    /// </summary>
    public string? PreviousFirstNameORChristianName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's previous last, surname, or family name.
    /// </summary>
    public string? PreviousLastNameORSurnameORFamilyName { get; set; }

    /// <summary>
    /// Gets or sets the occupation code for the applicant.
    /// </summary>
    public string? OccupationCode { get; set; }

    /// <summary>
    /// Gets or sets the applicant's occupation with this employer.
    /// </summary>
    public string? Occupation { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether indicates whether the applicant has a fully maintained company car.
    /// </summary>
    public bool HASFullyMaintainedCompanyCar { get; set; }

    /// <summary>
    /// Gets or sets the ID referencing the gender type from the general lookup.
    /// </summary>
    public int? GenderType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the ID referencing the other name title type from the general lookup.
    /// </summary>
    public int? OtherNameTitleType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the other first name, if applicable.
    /// </summary>
    [Comment("Discussion to remove other in this field")]
    public string? OtherFirstName { get; set; }

    /// <summary>
    /// Gets or sets the other last, surname, or family name if applicable.
    /// </summary>
    [Comment("Discussion to remove other in this field")]
    public string? OtherLastNameORSurnameORFamilyName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's marital status type from the general lookup.
    /// </summary>
    public int? MaritalStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the applicant's residential type from the general lookup.
    /// </summary>
    public int? ResidencyStatus_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the applicant's migrant visa number.
    /// </summary>
    public int? MigrantVisaNumber { get; set; }

    /// <summary>
    /// Gets or sets the applicant type from the general lookup.
    /// </summary>
    public int? ApplicantType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the applicant's mother first, Christian, or given name.
    /// </summary>
    [Comment("MotherFirstName Written as this, as per client request on (17-06-2023) Excel")]
    public string? MotherFirstORChristianNameORGiven { get; set; }

    /// <summary>
    /// Gets or sets the applicant's maiden name.
    /// </summary>
    public string? MaidenName { get; set; }

    /// <summary>
    /// Gets or sets the applicant's date of birth. This is a sensitive information field.
    /// </summary>
    [Comment("We will require to Encrypt this field As this is a sensitive information")]
    public DateOnly? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the applicant's place of birth.
    /// </summary>
    public string? PlaceOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the applicant's country of birth.
    /// </summary>
    public string? CountryOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the applicant's spouse's marital status, if applicable.
    /// </summary>
    public string? SpouseMaritalStatus { get; set; }

    /// <summary>
    /// Gets or sets the citizenship information of the applicant.
    /// </summary>
    public string? CitizenShip { get; set; }

    /// <summary>
    /// Indicates whether the applicant anticipates any changes.
    /// </summary>
    public bool ISAnticipatedChanges { get; set; }

    /// <summary>
    /// Indicates if the applicant is a first home buyer.
    /// </summary>
    public bool ISFirstHomeBuyer { get; set; }

    /// <summary>
    /// Indicates whether the applicant has a joint statement of position.
    /// </summary>
    public bool ISJointStatementOfPosition { get; set; }

    /// <summary>
    /// Indicates whether Power of Attorney has been granted for the applicant.
    /// </summary>
    public bool ISPOAGranted { get; set; }

    /// <summary>
    /// Indicates if FIRB (Foreign Investment Review Board) approval has been granted for the applicant.
    /// </summary>
    public bool ISFIRBApproved { get; set; }

    /// <summary>
    /// Indicates if the applicant has a joint nomination.
    /// </summary>
    public bool ISJointNomination { get; set; }

    /// <summary>
    /// Indicates whether the applicant is an existing customer.
    /// </summary>
    public bool ISExistingCustomer { get; set; }

    /// <summary>
    /// Indicates whether the applicant is eligible for the First Home Owner Grant (FHOG).
    /// </summary>
    public bool ISEligibleForFHOG { get; set; }

    /// <summary>
    /// Indicates whether the applicant has discussed with beneficiaries.
    /// </summary>
    public bool ISDiscussedWithBeneficiaries { get; set; }

    /// <summary>
    /// Indicates whether the applicant is politically exposed.
    /// </summary>
    public bool ISPoliticallyExposed { get; set; }

    /// <summary>
    /// Indicates whether the applicant has a will.
    /// </summary>
    public bool HASWill { get; set; }

    /// <summary>
    /// Indicates whether the applicant has a previous name.
    /// </summary>
    public bool HASPreviousName { get; set; }

    /// <summary>
    /// Indicates whether the applicant has provided a tax declaration.
    /// </summary>
    public bool HASTaxDeclarationProvided { get; set; }

    /// <summary>
    /// Indicates whether the applicant allows a credit check.
    /// </summary>
    public bool AllowCreditCheck { get; set; }

    /// <summary>
    /// Indicates whether the applicant allows direct marketing.
    /// </summary>
    public bool AllowDirectMarketing { get; set; }

    /// <summary>
    /// Indicates whether the applicant allows telemarketing.
    /// </summary>
    public bool AllowTeleMarketing { get; set; }

    /// <summary>
    /// Indicates whether the applicant authorizes third party disclosure.
    /// </summary>
    public bool AllowThirdPartyDisclosure { get; set; }

    /// <summary>
    /// Indicates whether the applicant has signed credit authority.
    /// </summary>
    public bool ISCreditAuthoritySigned { get; set; }

    /// <summary>
    /// Indicates whether the applicant has signed privacy act consent.
    /// </summary>
    public bool ISPrivacyActConsentSigned { get; set; }

    /// <summary>
    /// Indicates whether the applicant is a company director.
    /// </summary>
    public bool ISCompanyDirector { get; set; }

    /// <summary>
    /// Gets or sets the number of years the applicant has been in their current profession.
    /// </summary>
    public double? YearsInCurrentProfession { get; set; }

    /// <summary>
    /// Gets or sets the number of months the applicant has been in their current profession.
    /// </summary>
    public double? MonthInCurrentProfession { get; set; }

    /// <summary>
    /// Gets or sets the nominated borrower, if applicable.
    /// </summary>
    public string? NominatedBorrower { get; set; }

    /// <summary>
    /// Gets or sets the applicant's credit status.
    /// </summary>
    public string? CreditStatus { get; set; }

    /// <summary>
    /// Gets or sets the country where a related document was issued.
    /// </summary>
    public string? IssuedInCountry { get; set; }

    /// <summary>
    /// Gets or sets the unique ID of the applicant's accountant.
    /// </summary>
    public string? AccountantUniqueID { get; set; }

    /// <summary>
    /// Indicates whether the applicant pays credit on time.
    /// </summary>
    public bool ISCreditPayOnTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the AML (Anti-Money Laundering) check passed.
    /// </summary>
    public bool? AMLCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the OFAC (Office of Foreign Assets Control) check passed.
    /// </summary>
    public bool? OFACCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the DFAT (Department of Foreign Affairs and Trade) check passed.
    /// </summary>
    public bool? DFATCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the biometric ID verification passed.
    /// </summary>
    public bool? IDBiometricVerificationResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the ID Matrix verification was accepted.
    /// </summary>
    public bool? IDMatrixVerificationResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the KYC (Know Your Customer) verification passed.
    /// </summary>
    public bool? KYCVerificationResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the fraud check passed.
    /// </summary>
    public bool? FraudCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the HAS (High Alert System) fraud check matched.
    /// </summary>
    public bool? HASFraudCheckResult { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a HAS (High Alert System) sanction is present.
    /// </summary>
    public bool? HASSanction { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a velocity check has been completed.
    /// </summary>
    public bool? HasVelocityCheck { get; set; }

    /// <summary>
    /// Gets or sets an extra optional field for the applicant.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra optional field for the applicant.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra optional field for the applicant.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the applicant's next of kin details.
    /// </summary>
    public NextOfKin? NextOfKin { get; set; }

    /// <summary>
    /// Gets or sets the applicant's driver license information.
    /// </summary>
    public DriverLicense? DriverLicense { get; set; }

    /// <summary>
    /// Gets or sets the applicant's contact details.
    /// </summary>
    public Contact? Contacts { get; set; }

    /// <summary>
    /// Gets or sets the applicant's passport information.
    /// </summary>
    [Comment("if the Applicant is a Foreigner he may have 2 or more passports")]
    public Passport? Passport { get; set; }

    /// <summary>
    /// Gets the collection of the applicant's proofs of identity.
    /// </summary>
    public IList<ProofOfIdentity> ProofOfIdentities { get; set; } = new List<ProofOfIdentity>();

    /// <summary>
    /// Gets the collection of PAYG (Pay As You Go) details for the applicant.
    /// </summary>
    public IList<Payg> Paygs { get; set; } = new List<Payg>();

    /// <summary>
    /// Gets the collection of non-employed status records for the applicant.
    /// </summary>
    public IList<NotEmployed> NotEmployed { get; set; } = new List<NotEmployed>();

    /// <summary>
    /// Gets the collection mapping the applicant to loan applications.
    /// </summary>
    [InverseProperty(nameof(LoanApplicationApplicantMapper.LoanApplicationApplicantMapper_Applicant))]
    public IList<LoanApplicationApplicantMapper> LoanApplicationApplicantMappers { get; set; } = [];

    #region Remove fields

    /// <summary>
    /// Gets or sets the industry type ID associated with the applicant.
    /// </summary>
    public int? Industry_IndustryTypeID { get; set; }

    /// <summary>
    /// Gets or sets another industry name specified by the applicant.
    /// </summary>
    public string? OtherIndustry { get; set; }

    /// <summary>
    /// Gets or sets the FIRB approval date for the applicant, if applicable.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? FIRBApprovalDate { get; set; }

    /// <summary>
    /// Indicates whether the applicant has citizenship.
    /// </summary>
    public bool HASCitizenship { get; set; }

    /// <summary>
    /// Indicates whether the applicant has received other government incentives.
    /// </summary>
    public bool HASOtherGovtIncentive { get; set; }

    public int? RelationShipType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the applicant ID or name of the person this applicant is married to.
    /// </summary>
    [Comment("Applicant ID with whom this applicant is married too/ or name maybe")]
    public string? ApplicantMarriedTo { get; set; }

    public FamilyRelation? FamilyRelation { get; set; }

    /// <summary>
    /// Gets or sets the applicant's primary Equifax number.
    /// </summary>
    public string? PrimaryEquifaxNumber { get; set; }

    /// <summary>
    /// Gets or sets the applicant's secondary Equifax number.
    /// </summary>
    public string? SecondaryEquifaxNumber { get; set; }

    /// <summary>
    /// Gets or sets the applicant's tertiary Equifax number.
    /// </summary>
    public string? TertiaryEquifaxNumber { get; set; }

    public bool? HASOutstandingRates { get; set; }

    public decimal? OutstandingRatesAmount { get; set; }

    /// <summary>
    /// Gets the collection of addresses associated with the applicant.
    /// </summary>
    public List<Address> Addresses { get; set; } = new();

    /// <summary>
    /// Gets or sets the applicant's Medicare details.
    /// </summary>
    [Comment("if the Applicant have two or more health insurances , Name Is Not Pluralize waiting for suggestion")]
    public MedicareDetail? MedicareDetail { get; set; }

    /// <summary>
    /// Gets or sets relationship detail for the applicant.
    /// </summary>
    public ApplicantRelationshipDetail? ApplicantRelationshipDetail { get; set; }

    /// <summary>
    /// Gets or sets the applicant's insurance details.
    /// </summary>
    [Comment("one person can have one Insurance")]
    public Insurance? Insurances { get; set; }

    /// <summary>
    /// Gets or sets the introduction details for the customer.
    /// </summary>
    public IntroductionToTheCustomer? IntroductionToTheCustomers { get; set; }

    /// <summary>
    /// Gets or sets the liability security details for the applicant.
    /// </summary>
    public LiabilitySecurity? LiabilitySecurity { get; set; }

    /// <summary>
    /// Gets the collection of documents provided by the applicant.
    /// </summary>
    public IList<Document> Documents { get; set; } = new List<Document>();

    /// <summary>
    /// Gets the collection of dependents for the applicant.
    /// </summary>
    public IList<Dependent> Dependents { get; set; } = new List<Dependent>();

    /// <summary>
    /// Gets the applicant's financial and non-financial credit history records.
    /// </summary>
    public IList<CreditHistoryForFinancialAndNonFinancial> CreditHistoryForFinancialAndNonFinancials { get; set; } = new List<CreditHistoryForFinancialAndNonFinancial>();

    /// <summary>
    /// Gets the collection of card details associated with the applicant.
    /// </summary>
    public IList<CardDetail> CardDetails { get; set; } = new List<CardDetail>();

    //public SecurityQuestionMapper? SecurityQuestionMappers { get; set; }

    public CompanyApplicant? Applicant_CompanyApplicant { get; set; }

    public Trust? Applicant_Trust { get; set; }

    #endregion
}
