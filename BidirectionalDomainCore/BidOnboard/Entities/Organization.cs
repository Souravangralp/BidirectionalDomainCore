using Bidirectional.DomainCore.BidOnboard.Entities.Organizations;
using Bidirectional.DomainCore.BidOnboard.Constants;
using Bidirectional.DomainCore.BidOnboard.Entities.Agreement;
using Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class Organization : BaseAuditableEntity
{
    public int? ParentOrganizationID { get; set; }

    public DomainOrganizationTypes OrganizationType { get; set; } // Fo now we have two types: "White Label partner" and "Lender" and "Mortgage Manager"

    public string? Name { get; set; }

    public string? TradingName { get; set; }

    public string? EntityTypeName { get; set; }

    public int? OrganizationType_CoreDB_GeneralLookUpID { get; set; }

    public DateOnly? GSTRegisteredFrom { get; set; }

    public string? BusinessLocation { get; set; }

    public string? Website { get; set; }

    public string? LogoUrl { get; set; }

    public string? Domain { get; set; }

    [TextClass(TextFieldClass.Url)]
    public string? LogoFilePath { get; set; }

    public string? Color { get; set; }

    public string? Font { get; set; }

    public string? FaviconUrl { get; set; }

    public string? TaxIdentificationNumber { get; set; }

    public double? AnnualRevenue { get; set; }

    public string? TenantID { get; set; } // Unique tenant identifier

    public string? ShortBusinessDescription { get; set; }

    public string? PrimaryBrandColorCode { get; set; }

    public string? SecondaryBrandColorCode { get; set; }

    public string? TertiaryBrandColorCode { get; set; }

    public string? BookingBusinessID { get; set; }

    public string? ThemeSettings { get; set; }

    public string? FormPrefix { get; set; }

    public int? EstablishedYear { get; set; }

    public string? BusinessObjective { get; set; }

    public string? PrincipleStaffSettingUpCompany { get; set; }

    public string? FundSource { get; set; }

    public string? FuturePlans { get; set; }

    public int? TotalNumberOfEmployees { get; set; }

    public int? BusinessPremisesType_CoreDB_GeneralLookUpID { get; set; }

    public string? OtherBusinessPremisesType { get; set; }

    public string? LinkedInProfile { get; set; }

    public bool ISBlocked { get; set; }

    public DateTime? BlockedUpToDate { get; set; }

    public ICollection<StaffDistribution> StaffDistributions { get; set; } = [];

    public ICollection<BusinessCostDetail> BusinessCostDetails { get; set; } = [];

    public ICollection<BusinessPartnerDetail> BusinessPartnerDetails { get; set; } = [];

    public ICollection<BusinessCapabilityType> BusinessCapabilityTypes { get; set; } = [];

    public ICollection<BusinessPanelFinancialInstitution> BusinessPanelFinancialInstitutions { get; set; } = [];

    public ICollection<OrganizationAward> OrganizationAwards { get; set; } = [];

    public int? CurrentPortfolioRangeType_CoreDB_GeneralLookUpID { get; set; } // $0�50m, $50�150m, etc.

    public int? LastMonthSettledRangeType_CoreDB_GeneralLookUpID { get; set; } // <$1m, $1�5m, etc.

    public int? AnticipatedAnnualVolumeRangeType_CoreDB_GeneralLookUpID { get; set; } // <$10m, $10�50m, etc.

    public int MortgageInsurer_CoreDB_GeneralLookUpID { get; set; } // e.g. Genworth, QBE, Others

    public string? OtherMortgageInsurer { get; set; } // free-text fallback

    public int? SupportType_CoreDB_GeneralLookUpID { get; set; } // e.g. Loan Packaging, Compliance, Marketing

    public string? OtherSupportType { get; set; }

    public bool ISAppliedAsBrokerUnderMortgageManager { get; set; }

    public string? AsBrokerUnderMortgageManagers { get; set; }

    [TextClass(TextFieldClass.Ignored)]
    public string? BlobFolderName { get; private set; }

    public Organization? ParentOrganization { get; set; }

    public BusinessIdentifier? BusinessIdentifier { get; set; }

    public WarehouseFacility? WarehouseFacility { get; set; }

    public ICollection<Referee> Referees { get; set; } = [];

    public ICollection<Organization> ChildOrganizations { get; set; } = [];

    public ICollection<BusinessUnit> BusinessUnits { get; set; } = [];

    public ICollection<OrganizationBusinessUnitGroupMapper> OrganizationBusinessUnitGroupMappers { get; set; } = [];

    public ICollection<Address> Addresses { get; set; } = [];

    public ICollection<DocumentDetail> Documents { get; set; } = [];

    public ICollection<EmailDetail> Emails { get; set; } = [];

    public ICollection<PhoneDetail> Phones { get; set; } = [];

    public ICollection<OnboardingProcess> OnboardingProcesses { get; set; } = [];

    public ICollection<OnboardingHistory> OnboardingHistory { get; set; } = [];

    public ICollection<Bidirectional.DomainCore.BidOnboard.Entities.Privacy.PrivacyPolicy> PrivacyPolicies { get; set; } = [];

    public ICollection<DefaultAgreement> DefaultAgreements { get; set; } = [];

    public ICollection<OrganizationBusinessUnitAgreement> OrganizationBusinessUnitAgreements { get; set; } = [];

    public ICollection<ExternalUser> ExternalUsers { get; set; } = [];

    public ICollection<BankDetail> Banks { get; set; } = [];

    public ICollection<FormEntry> FormEntries { get; set; } = [];

    public ICollection<CoreProductSetting> CoreProductSettings { get; set; } = [];

    public ICollection<AssignedProduct> AssignedProducts { get; set; } = [];

    #region Generate blob folder at initial level only

    public Organization()
    {
    }

    public void InitBlobFolder()
    {
        if (!string.IsNullOrWhiteSpace(BlobFolderName))
        {
            return;
        }

        BlobFolderName = FolderNameGenerator.Generate(OrganizationType.ToString(), Name, BusinessIdentifier?.ABN);
    }

    #endregion
}
