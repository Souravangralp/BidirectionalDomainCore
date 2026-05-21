namespace Bidirectional.DomainCore.Common.Enums;

/// <summary>
/// Defines the types of domain entities by mapping to corresponding organization and business unit types.
/// </summary>
public enum DomainEntityTypes
{
    Lender = DomainOrganizationTypes.Lender,
    WhiteLabelPartner = DomainOrganizationTypes.WhiteLabelPartner,
    MortgageManager = DomainOrganizationTypes.MortgageManager,

    Branch = DomainBusinessUnitTypes.Branch,
    Aggregator = DomainBusinessUnitTypes.Aggregator,

    Bidirectional = DomainOrganizationTypes.Bidirectional,

    WareHouse = DomainOrganizationTypes.WareHouse,
}

/// <summary>
/// Represents the organization types in the domain.
/// </summary>
public enum DomainOrganizationTypes
{
    Lender = 1,
    WhiteLabelPartner = 2,
    MortgageManager = 3,
    Bidirectional = 6,

    WareHouse = 8,
}

/// <summary>
/// Represents the business unit types in the domain.
/// </summary>
public enum DomainBusinessUnitTypes
{
    Branch = 4,
    Aggregator = 5
}

public enum ExamType
{
    ScenarioBased = 0,
    Compliance = 1,
    Technical = 2,
}

public enum QuestionType
{
    MCQ = 1,
    Radio = 1,
    Numeric = 2,
    Text = 3
}

/// <summary>
/// Lifecycle state of an exam template assignment to a user (BDM questionnaire workflow).
/// </summary>
public enum ExamTemplateAssignmentStatus
{
    /// <summary>
    /// The assignment has not yet been started by the user.
    /// </summary>
    NotStarted = 0,

    /// <summary>
    /// The assignment has been started and is currently in progress.
    /// </summary>
    InProgress = 1,

    /// <summary>
    /// The assignment has been completed by the user.
    /// </summary>
    Completed = 2,

    /// <summary>
    /// The assignment has been cancelled and will not be completed.
    /// </summary>
    Cancelled = 3,
}

/// <summary>
/// Provides extension methods for the <see cref="DomainEntityTypes"/> enum to check category membership.
/// </summary>
public static class DomainEntityTypeExtensions
{
    /// <summary>
    /// Determines whether the specified entity type is an organization type.
    /// </summary>
    /// <param name="type">The <see cref="DomainEntityTypes"/> value to check.</param>
    /// <returns>
    /// True if the entity type is defined in <see cref="DomainOrganizationTypes"/>; otherwise, false.
    /// </returns>
    public static bool ISOrganization(this DomainEntityTypes type) =>
        Enum.IsDefined(typeof(DomainOrganizationTypes), (int)type);

    /// <summary>
    /// Determines whether the specified entity type is a business unit type.
    /// </summary>
    /// <param name="type">The <see cref="DomainEntityTypes"/> value to check.</param>
    /// <returns>
    /// True if the entity type is defined in <see cref="DomainBusinessUnitTypes"/>; otherwise, false.
    /// </returns>
    public static bool ISBusinessUnit(this DomainEntityTypes type) =>
        Enum.IsDefined(typeof(DomainBusinessUnitTypes), (int)type);

    public static bool ISValidPrivacyPolicyEntityType(this TargetEntityTypes type) =>
        Enum.IsDefined(typeof(DomainEntityTypes), (int)type);

    public static bool ISOrganization(this TargetEntityTypes type) =>
        Enum.IsDefined(typeof(DomainOrganizationTypes), (int)type);

    public static bool ISBusinessUnit(this TargetEntityTypes type) =>
        Enum.IsDefined(typeof(DomainBusinessUnitTypes), (int)type);
}

/// <summary>
/// Specifies entity types that can be targets within the domain.
/// </summary>
public enum TargetEntityTypes
{
    /// <summary>
    /// Represents the Lender entity type as a possible target within the domain.
    /// </summary>
    Lender = DomainEntityTypes.Lender,

    /// <summary>
    /// Represents the White Label Partner entity type as a possible target within the domain.
    /// </summary>
    WhiteLabelPartner = DomainEntityTypes.WhiteLabelPartner,

    /// <summary>
    /// Represents the Mortgage Manager entity type as a possible target within the domain.
    /// </summary>
    MortgageManager = DomainEntityTypes.MortgageManager,

    /// <summary>
    /// Represents the Branch business unit entity type as a possible target within the domain.
    /// </summary>
    Branch = DomainEntityTypes.Branch,

    /// <summary>
    /// Represents the Aggregator business unit entity type as a possible target within the domain.
    /// </summary>
    Aggregator = DomainEntityTypes.Aggregator,

    /// <summary>
    /// Represents the Bidirectional organization entity type as a possible target within the domain.
    /// </summary>
    Bidirectional = DomainEntityTypes.Bidirectional,

    /// <summary>
    /// Represents a User entity type as a possible target within the domain.
    /// </summary>
    User = 7,

    WareHouse = DomainEntityTypes.WareHouse,
}

/// <summary>
/// Represents the types of agreements recognised by the system.
/// </summary>
public enum AgreementTypes
{
    DefaultAgreement = 1,
    FinalAgreement = 2,
}

public enum PolicySourceType
{
    Self = 1,
    Parent = 2,
}

public enum UserEnrollmentType
{
    Onboarded = 1,
    Invited = 2,
}

public enum InvitedUserType
{
    Internal = 1,
    External = 2,
}

public enum ResponsibilityQuestionStatus
{
    Pending = 1,
    Answered = 2,
    Skipped = 3,
    NotApplicable = 4
}

public enum YesNoOption
{
    No = 0,
    Yes = 1
}
