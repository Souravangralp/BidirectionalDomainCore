using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessDetail : BaseAuditableEntity
{
    public int? BusinessType_CoreDB_GeneralLookUpID { get; set; } // Lookup for Sole Trader, Company, Trust, Partnership

    public string? OtherBusiness { get; set; } // If the business type is not in the lookup, specify here

    public int? BusinessDetail_UserID { get; set; }

    public int? ExpectedMonthlySettlement_CoreDB_GeneralLookUpID { get; set; } // Look up table will hold these values '$1,000,000 - $2,000,000', '$3,000,000 - $4,000,000', '$5,000,000 - $10,000,000'

    public int? PortfolioSizeType_CoreDB_GeneralLookUpID { get; set; } // Look up table will have these values '$25,000,000 � $100,000,000', '$100,000,000 � $250,000,000', '$250,000,000 � $1 Billion'

    public int? CrmType_CoreDB_GeneralLookUpID { get; set; } // we will get this from look up for Monday.com, Pipedrive CRM, Zoho CRM, Creatio

    public string? OtherCrm { get; set; } // if chose other in CrmType_CoreDB_GeneralLookUpID then we will input this from user.

    public string? BusinessName { get; set; } // Business or Company Name

    public string? Logo { get; set; }

    public string? Website { get; set; }

    public bool ISRepresentative { get; set; } // If true, then they are under another ACL holder

    public string? RepresentingAclNumber { get; set; } // Set if they are a credit rep

    public string? TradingName { get; set; } // Trading name if different from Business Name

    public string? Industry { get; set; } // Industry type (e.g., IT, Construction, Retail)

    public int BusinessStatus_CoreDB_GeneralLookUpID { get; set; } // Lookup for Active, Inactive, Deregistered, etc.

    public DateOnly RegistrationDate { get; set; } // When the business was registered

    public DateOnly? DeregistrationDate { get; set; } // If the business is deregistered

    public bool ISGSTRegistered { get; set; } // Whether the business is registered for GST

    public string? GST { get; set; } // Australian Company Number (only for companies)

    public int? GSTStatusType_CoreDB_GeneralLookUpID { get; set; } // we will get this from look up for like Active, Deactivate, expired

    public DateOnly? GSTEffectiveFrom { get; set; }

    public DateOnly? GSTEffectiveTo { get; set; }

    public string? TaxFileNumber { get; set; } // Tax File Number (if applicable)

    public int BusinessStructure_CoreDB_GeneralLookUpID { get; set; } // Lookup: Private, Public, LLC, etc.

    public int OwnershipType_CoreDB_GeneralLookUpID { get; set; } // Lookup: Sole Proprietorship, Partnership, Corporation

    public string? OtherOwnershipType { get; set; }

    public string? Notes { get; set; } // Any additional remarks or internal notes

    public int? NoOfEmployees { get; set; } // may be the no of employees in company

    public int? TimeInBusinessInMonths { get; set; }

    public int? TimeInBusinessInYears { get; set; }

    public string? Descriptions { get; set; } // Description of the business

    public string? TopThreeLenders { get; set; }

    public string? BusinessGrowthExpectation { get; set; }

    public string? CreditRepresentativeNumber { get; set; } // for external users

    public User? BusinessDetail_User { get; set; }

    public BusinessIdentifier? BusinessIdentifier { get; set; }

    public ICollection<Address> Addresses { get; set; } = []; // Registered business address

    public ICollection<EmailDetail> Emails { get; set; } = [];

    public ICollection<PhoneDetail> Phones { get; set; } = [];

    public ICollection<BusinessLender> BusinessLenders { get; set; } = []; // Options: https://www.canstar.com.au/providers/home-loans/ can choose up to 3

    public ICollection<BusinessObjective> BusinessObjectives { get; set; } = []; // Can chose up to 3 also from this.

    public ICollection<BankDetail> Banks { get; set; } = [];
}
