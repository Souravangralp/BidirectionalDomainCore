using Bidirectional.DomainCore.BidOnboard.Assessment.Attempts;
using Bidirectional.DomainCore.BidOnboard.Entities;
using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities.Organizations;
using Bidirectional.DomainCore.BidOnboard.Constants;
using Bidirectional.DomainCore.BidOnboard.Entities.Assets;
using Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;
using Bidirectional.DomainCore.BidOnboard.Entities.ResponsibilityQuestions;
using Bidirectional.DomainCore.BidOnboard.Entities.UserRepresentative;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class User : BaseAuditableEntity
{
    public string? DirectorID { get; set; } // Unique identifier for the user, can be used to link with external systems

    public int? ApplicationType_CoreDB_GeneralLookUpID { get; set; }

    public int? UserType_CoreDB_GeneralLookUpID { get; set; } // User type (e.g., 'Invited user', 'Onboarded user')

    public int? GenderType_CoreDB_GeneralLookUpID { get; set; }

    public int? MaritalStatusType_CoreDB_GeneralLookUpID { get; set; }

    public int? HearAboutType_CoreDB_GeneralLookUpID { get; set; } // from where did you hear about us Search Engine Social Media Ads Aggregator/CRM

    public int? TitleType_CoreDB_GeneralLookUpID { get; set; }

    public int? OtherNameTitleType_CoreDB_GeneralLookUpID { get; set; }

    public int? FatherNameTitleType_CoreDB_GeneralLookUpID { get; set; }

    public int? MotherNameTitleType_CoreDB_GeneralLookUpID { get; set; }

    public InvitedUserType? InvitedUserType { get; set; }

    public string? Position { get; set; } // e.g., Director, Partner, Sole Trader

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public bool HASOtherName { get; set; } // whether the user has other name

    public string? OtherFirstName { get; set; }

    public string? OtherMiddleName { get; set; }

    public string? OtherLastName { get; set; }

    public string? FatherFirstName { get; set; }

    public string? FatherMiddleName { get; set; }

    public string? FatherLastName { get; set; }

    public string? MotherFirstName { get; set; }

    public string? MotherMiddleName { get; set; }

    public string? MotherLastName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? AvatarUrl { get; set; } // URL to user's avatar/profile image

    public string? Nationality { get; set; }

    public bool ISAustralianCitizen { get; set; }

    public string? OtherCountryCitizenship { get; set; }

    public string? UserAssignedTo { get; set; } // this will hold the information means that current user at which stage of who has taken of the user

    public int? UserStatusType_CoreDB_GeneralLookUpID { get; set; } // this will hold the user current status when its accreditation process is

    public string? AzureAdID { get; set; }

    public DateOnly? LivingAtAddressSince { get; set; } // applicant/director living at the current address since

    public int? PartnerNameTitleType_CoreDB_GeneralLookUpID { get; set; }

    public string? PartnerFirstName { get; set; }

    public string? PartnerMiddleName { get; set; }

    public string? PartnerLastName { get; set; }

    public bool ISBannedByFinancialRegulator { get; set; } // Have you or any related entity ever been banned by a Financial Services Regulator?

    public bool ISAustralianForLessThan2Year { get; set; } // Have you been an Australian Resident/Citizen for less than 2 years?

    public string? RegistrationID { get; set; }

    public bool ISACLHolder { get; set; } // Whether the user is an ACL holder

    public string? HearAboutDescription { get; set; }

    public string? IdentifyingQuestion { get; set; }

    public string? IdentifyingAnswer { get; set; }

    public int? InFinancialIndustrySince { get; set; } // in months

    public int? InMortgageIndustrySince { get; set; } // in months

    public bool ISOnline { get; set; }

    public bool ISBlocked { get; set; }

    public string? AggregatorGroup { get; set; } // for external users

    public string? AMLStudentNumber { get; set; } // for external users

    public string? CTFStudentNumber { get; set; } // for external users

    public string? AFCANumber { get; set; } // for external users

    [TextClass(TextFieldClass.Ignored)]
    public string? BlobFolderName { get; private set; }

    public DateTime? BlockedUpToDate { get; set; }

    public DateTime? LastActiveAt { get; set; }

    public DriverLicense? DriverLicense { get; set; }

    public BirthCertificate? BirthCertificate { get; set; }

    public ICollection<Passport> Passports { get; set; } = [];

    public ICollection<DocumentDetail> DocumentDetails { get; set; } = [];

    public ICollection<EmailDetail> Emails { get; set; } = [];

    public ICollection<PhoneDetail> Phones { get; set; } = [];

    public ICollection<Address> Addresses { get; set; } = [];

    public ICollection<PreferredCommunicationDetail> PreferredCommunicationDetails { get; set; } = [];

    public ICollection<OnboardingProcess> OnboardingProcesses { get; set; } = [];

    public ICollection<OrganizationBusinessUnitGroupUserMapper> OrganizationBusinessUnitGroupUserMappers { get; set; } = [];

    public BusinessIdentifier? BusinessIdentifier { get; set; }

    public BusinessDetail? BusinessDetail { get; set; }

    public ICollection<BankAsset> BankAssets { get; set; } = [];

    public ICollection<FurnitureAndPersonalAsset> FurnitureAndPersonalAssets { get; set; } = [];

    public ICollection<InvestmentAsset> InvestmentAssets { get; set; } = [];

    public ICollection<MotorVehicleAsset> MotorVehicleAssets { get; set; } = [];

    public ICollection<OtherAsset> OtherAssets { get; set; } = [];

    public ICollection<RealEstateAsset> RealEstateAssets { get; set; } = [];

    public ICollection<SuperannuationAsset> SuperannuationAssets { get; set; } = [];

    public ICollection<CreditCardLiability> CreditCardLiabilities { get; set; } = [];

    public ICollection<HpLeaseLiability> HpLeaseLiabilities { get; set; } = [];

    public ICollection<MortgageLiability> MortgageLiabilities { get; set; } = [];

    public ICollection<OtherLiability> OtherLiabilities { get; set; } = [];

    public ICollection<PersonalLoanLiability> PersonalLoanLiabilities { get; set; } = [];

    public ICollection<Language> Languages { get; set; } = []; // languages other than English

    public ICollection<Dependent> Dependents { get; set; } = [];

    public ICollection<IndustryExperience> IndustryExperiences { get; set; } = [];

    public ICollection<Accreditation> Accreditations { get; set; } = [];

    public ICollection<ExternalUser> ExternalUsers { get; set; } = [];

    public ICollection<UserHierarchy> Parents { get; set; } = [];

    public ICollection<UserHierarchy> Children { get; set; } = [];

    public ICollection<BankDetail> Banks { get; set; } = [];

    public ICollection<UserRepresentativeReference> UserRepresentativeReferences { get; set; } = [];

    public ICollection<OnboardingHistory> OnboardingHistory { get; set; } = [];

    public ICollection<FormEntry> FormEntries { get; set; } = [];

    public ICollection<ResponsibilityQuestionUserMapper> ResponsibilityQuestionUserMappers { get; set; } = new List<ResponsibilityQuestionUserMapper>();

    public ICollection<AreaOfExpertise> AreasOfExpertise { get; set; }

    public ICollection<StateCovered> StatesCovered { get; set; }

    public List<LoanApplication> LoanApplications { get; set; } = [];

    public ICollection<LoanApplicationUserOpen> LoanApplicationUserOpens { get; set; } = [];

    public ICollection<ExamAttempt> ExamAttempts { get; set; } = [];

    #region Generate blob folder at initial level only.

    public User()
    {
    }

    public void InitBlobFolder()
    {
        if (!string.IsNullOrWhiteSpace(BlobFolderName))
        {
            return;
        }

        BlobFolderName = FolderNameGenerator.GenerateUserFolder(FirstName, LastName, DateOfBirth);
    }

    #endregion
}
