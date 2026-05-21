namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Represents the various types of filters available in the Bidirectional Product Matrix API domain,
/// used to categorize and identify filtering criteria for product matrix operations.
/// </summary>
public enum FilterType
{
    /// <summary>
    /// Filter based on the age of the credit report.
    /// </summary>
    AgeOfCreditReport = 23,

    /// <summary>
    /// Filter based on the age of the natural person.
    /// </summary>
    AgeOfNaturalPerson = 10,

    /// <summary>
    /// Filter based on the purpose or aim of the application.
    /// </summary>
    ApplicationObjective = 21,

    /// <summary>
    /// Filter based on the type of borrowing entity.
    /// </summary>
    BorrowingEntity = 8,

    /// <summary>
    /// Filter based on different button types.
    /// </summary>
    ButtonType = 32,

    /// <summary>
    /// Filter based on the type of cash-out.
    /// </summary>
    CashOutType = 22,

    /// <summary>
    /// Filter based on construction criteria.
    /// </summary>
    Construction = 17,

    /// <summary>
    /// Filter for renovations without structural changes.
    /// </summary>
    RenovationWithNoStructural = 18,

    /// <summary>
    /// Filter for renovations with structural changes.
    /// </summary>
    RenovationWithStructural = 19,

    /// <summary>
    /// Filter for green construction projects.
    /// </summary>
    ConstructionGreen = 20,

    /// <summary>
    /// Filter for cases relating to discharged bankruptcy.
    /// </summary>
    DischargeBankrupt = 33,

    /// <summary>
    /// Filter for default-over scenarios.
    /// </summary>
    DefaultOver = 45,

    /// <summary>
    /// Filter based on credit index criteria.
    /// </summary>
    CreditIndex = 34,

    /// <summary>
    /// Filter for financial default conditions.
    /// </summary>
    FinancialDefault = 35,

    /// <summary>
    /// Filter for cases with potential significant impact.
    /// </summary>
    PotentialImpactFull = 43,

    /// <summary>
    /// Filter for exchanged contract scenarios.
    /// </summary>
    ExchangedContract = 44,

    /// <summary>
    /// Filter for industry-based criteria.
    /// </summary>
    Industry = 36,

    /// <summary>
    /// Filter based on the presence of a statement of claim.
    /// </summary>
    StatementOfClaim = 37,

    /// <summary>
    /// Filter based on default judgement scenarios.
    /// </summary>
    DefaultJudgement = 38,

    /// <summary>
    /// Filter for low documentation requirements.
    /// </summary>
    LoDocRequirement = 39,

    /// <summary>
    /// Filter based on latency in self-employed documentation.
    /// </summary>
    SelfEmployedDocumentationLatency = 40,

    /// <summary>
    /// Filter for arrears conditions.
    /// </summary>
    Arrear = 41,

    /// <summary>
    /// Filter for document types.
    /// </summary>
    DocType = 12,

    /// <summary>
    /// Filter based on dwelling classification.
    /// </summary>
    Dwelling = 5,

    /// <summary>
    /// Filter for employer classification.
    /// </summary>
    EmployerClassification = 13,

    /// <summary>
    /// Filter for employment status.
    /// </summary>
    EmploymentStatus = 14,

    /// <summary>
    /// Filter based on facility type.
    /// </summary>
    FacilityType = 9,

    /// <summary>
    /// Filter based on who is guiding the application.
    /// </summary>
    GuidedBy = 25,

    /// <summary>
    /// Filter for heedful points criteria.
    /// </summary>
    HeedfulPoints = 26,

    /// <summary>
    /// Filter based on land size classification.
    /// </summary>
    LandSizeClassification = 27,

    /// <summary>
    /// Filter for loan amount classification.
    /// </summary>
    LoanAmountClassification = 2,

    /// <summary>
    /// Filter for Loan-to-Value Ratio classification.
    /// </summary>
    LVRClassification = 3,

    /// <summary>
    /// Filter based on the marital status of the applicant.
    /// </summary>
    MaritalStatus = 7,

    /// <summary>
    /// Filter for other types of income.
    /// </summary>
    OtherIncomeType = 15,

    /// <summary>
    /// Filter for postcode categories.
    /// </summary>
    PostCodeCategories = 4,

    /// <summary>
    /// Filter for Pay As You Go (PAYG) income type.
    /// </summary>
    PaygIncomeType = 42,

    /// <summary>
    /// Filter for repayment type.
    /// </summary>
    RepaymentType = 6,

    /// <summary>
    /// Filter for security type.
    /// </summary>
    SecurityType = 28,

    /// <summary>
    /// Filter for self-employed status.
    /// </summary>
    SelfEmployed = 16,

    /// <summary>
    /// Filter for the type of service.
    /// </summary>
    ServiceType = 29,

    /// <summary>
    /// Filter for title type.
    /// </summary>
    TitleType = 30,

    /// <summary>
    /// Filter for units or apartments.
    /// </summary>
    UnitsApartment = 24,

    /// <summary>
    /// Filter for usage type.
    /// </summary>
    UsageType = 31,

    /// <summary>
    /// Filter for zoning classification.
    /// </summary>
    Zoning = 11,

    /// <summary>
    /// Filter for liability consolidation scenarios.
    /// </summary>
    LateRepaymentFilter = 47,

    /// <summary>
    /// Filter for borrower financial condition classification.
    /// </summary>
    BorrowerFinancialConditionClassification = 48,

    /// <summary>
    /// Filter based on business registration.
    /// </summary>
    BusinessRegistration = 49,

    /// <summary>
    /// Filter for financial statement criteria.
    /// </summary>
    FinancialStatement = 50,

    /// <summary>
    /// Filter for residency type.
    /// </summary>
    ResidencyType = 51,

    /// <summary>
    /// Filter that includes both financial and entity classification.
    /// </summary>
    FinancialAndEntityClassificationFilter = 52,

    /// <summary>
    /// Filter for default amount thresholds.
    /// </summary>
    DefaultAmount = 53,

    /// <summary>
    /// Filter based on the number of financial defaults.
    /// </summary>
    NoOfFinancialDefault = 54,
}
