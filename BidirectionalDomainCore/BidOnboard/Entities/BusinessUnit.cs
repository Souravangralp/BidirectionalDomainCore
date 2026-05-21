using Bidirectional.DomainCore.BidOnboard.Entities;
using Bidirectional.DomainCore.BidOnboard.Entities.Organizations;
using Bidirectional.DomainCore.BidOnboard.Constants;
using Bidirectional.DomainCore.BidOnboard.Entities.Agreement;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessUnit : BaseAuditableEntity
{
    public int? BusinessUnit_OrganizationID { get; set; }

    public DomainBusinessUnitTypes BusinessType { get; set; } // Fo now we have two types: "Branch" and "Aggregator"

    public int? ParentBusinessUnitID { get; set; }

    public int? ReferralSource_CoreDB_GeneralLookUpID { get; set; }

    public int? ApprovedOwnerOperatorType_CoreDB_GeneralLookUpID { get; set; }

    public string? EntityType { get; set; }

    public string? Name { get; set; }

    public string? Website { get; set; }

    public string? PrimaryBrandColorCode { get; set; }

    public string? SecondaryBrandColorCode { get; set; }

    public string? TertiaryBrandColorCode { get; set; }

    public string? Domain { get; set; }

    public string? Color { get; set; }

    [TextClass(TextFieldClass.Url)]
    public string? LogoFilePath { get; set; }

    public string? ASICRepresentationNumber { get; set; }

    public DateOnly? ASICRegistrationDate { get; set; }

    public string? DocumentAcronym { get; set; }

    public string? ThemeSettings { get; set; }

    public string? FormPrefix { get; set; }

    [TextClass(TextFieldClass.Url)]
    public string? FaviconUrl { get; set; }

    public DateOnly? EstablishedDate { get; set; }

    public int? NumberOfEmployees { get; set; }

    public double? AnnualRevenue { get; set; }

    public string? TaxIdentificationNumber { get; set; }

    public string? ReferralSourceInformation { get; set; }

    public DateOnly? AtHomeOfficeTill { get; set; } // required if Approved Owner Operator Type is "Home Office". This field will have the months for which the AOO will be operating from Home Office.

    public string? BookingBusinessID { get; set; }

    public string? NumberOfBrokers { get; set; }

    public bool ISBlocked { get; set; }

    [TextClass(TextFieldClass.Ignored)]
    public string? BlobFolderName { get; private set; }

    public DateTime? BlockedUpToDate { get; set; }

    public BusinessUnit? ParentBusinessUnit { get; set; }

    public BusinessIdentifier? BusinessIdentifier { get; set; }

    public ICollection<BusinessUnit> SubBusinessUnits { get; set; } = [];

    public ICollection<PhoneDetail> Phones { get; set; } = [];

    public ICollection<Address> Addresses { get; set; } = [];

    public ICollection<EmailDetail> Emails { get; set; } = [];

    public ICollection<OrganizationBusinessUnitGroupMapper> OrganizationBusinessUnitGroupMappers { get; set; } = [];

    public ICollection<Referee> Referees { get; set; } = [];

    public ICollection<DocumentDetail> Documents { get; set; } = [];

    public ICollection<OnboardingProcess> OnboardingProcesses { get; set; } = [];

    public ICollection<OnboardingHistory> OnboardingHistory { get; set; } = [];

    public Organization? BusinessUnit_Organization { get; set; }

    public List<OrganizationBusinessUnitAgreement> OrganizationBusinessUnitAgreements { get; set; } = [];

    public List<ExternalUser> ExternalUsers { get; set; } = [];

    public ICollection<BankDetail> Banks { get; set; } = [];

    public ICollection<FormEntry> FormEntries { get; set; } = [];

    public ICollection<CoreProductSetting> CoreProductSettings { get; set; } = [];

    public ICollection<AssignedProduct> AssignedProducts { get; set; } = [];

    #region Generate blob folder at initial level only

    public BusinessUnit()
    {
    }

    public void InitBlobFolder()
    {
        if (!string.IsNullOrWhiteSpace(BlobFolderName))
        {
            return;
        }

        BlobFolderName = FolderNameGenerator.Generate(BusinessType.ToString(), Name, BusinessIdentifier?.ABN);
    }

    #endregion
}
