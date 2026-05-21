using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.Leads
{
    /// <summary>
    /// Represents a lead entity with personal, contact, and organizational information for tracking and management within the application.
    /// </summary>
    public class Lead : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the associated loan application identifier for the lead.
        /// </summary>
        public int? Lead_LoanApplicationID { get; set; }

        /// <summary>
        /// Gets or sets the associated organization identifier for the lead.
        /// </summary>
        public int? Lead_OrganizationID { get; set; }

        /// <summary>
        /// Gets or sets the associated business unit identifier for the lead.
        /// </summary>
        public int? Lead_BusinessUnitID { get; set; }

        /// <summary>
        /// Gets or sets the user identifier assigned to the lead.
        /// </summary>
        public int? Lead_UserID { get; set; }

        /// <summary>
        /// Gets or sets the first name of the lead.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the lead.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the lead.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the primary phone number of the lead.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the WhatsApp number of the lead.
        /// </summary>
        public string? WhatsAppNumber { get; set; }

        /// <summary>
        /// Gets or sets the Facebook identifier of the lead.
        /// </summary>
        public string? FacebookID { get; set; }

        /// <summary>
        /// Gets or sets the Instagram identifier of the lead.
        /// </summary>
        public string? InstagramID { get; set; }

        /// <summary>
        /// Gets or sets the WeChat identifier of the lead.
        /// </summary>
        public string? WechatID { get; set; }

        /// <summary>
        /// Gets or sets the LinkedIn identifier of the lead.
        /// </summary>
        public string? LinkedInID { get; set; }

        /// <summary>
        /// Gets or sets the preferred contact type lookup identifier from CoreDB for the lead.
        /// </summary>
        public int? PreferredContactType_GeneralLookUpID { get; set; }

        /// <summary>
        /// Gets or sets the preferred contact slot time type lookup identifier from CoreDB for the lead.
        /// </summary>
        public int? PreferredContactSlotTimeType_GeneralLookUpID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the loan purpose type is purchase.
        /// </summary>
        public bool ISPurchase { get; set; } //Loan purpose type, e.g., purchase, refinance, etc.

        /// <summary>
        /// Gets or sets a value indicating whether the investment type is investment property.
        /// </summary>
        public bool ISInvestment { get; set; } // Investment type, e.g., investment property, etc.

        /// <summary>
        /// Gets or sets the security type lookup identifier from CoreDB for the lead.
        /// </summary>
        public int? SecurityType_GeneralLookUpID { get; set; }

        /// <summary>
        /// Gets or sets the ownership status type lookup identifier from CoreDB for the lead.
        /// </summary>
        public int? OwnershipStatusType_GeneralLookUpID { get; set; }

        /// <summary>
        /// Gets or sets the number of adults in the household associated with the lead.
        /// </summary>
        public int? NumberOfAdultsInHouseHolds { get; set; }

        /// <summary>
        /// Gets or sets additional comments regarding the lead.
        /// </summary>
        public string? Comments { get; set; }

        /// <summary>
        /// Gets or sets additional descriptions for the lead.
        /// </summary>
        public string? Descriptions { get; set; }

        /// <summary>
        /// Gets or sets the source from which the lead was generated.
        /// </summary>
        public string? LeadSource { get; set; }

        /// <summary>
        /// Gets or sets the status of the lead.
        /// </summary>
        public string? LeadStatus { get; set; }

        /// <summary>
        /// Gets or sets the preferred date and time for contacting the lead.
        /// </summary>
        public DateTime? PreferredContactDateTime { get; set; }

        /// <summary>
        /// Gets or sets the organization entity associated with the lead.
        /// </summary>
        public Organization? Lead_Organization { get; set; }

        /// <summary>
        /// Gets or sets the business unit entity associated with the lead.
        /// </summary>
        public BusinessUnit? Lead_BusinessUnit { get; set; }

        /// <summary>
        /// Gets or sets the user entity assigned to the lead.
        /// </summary>
        public User? Lead_User { get; set; }

        /// <summary>
        /// Gets or sets the loan application entity linked with the lead.
        /// </summary>
        public LoanApplication? Lead_LoanApplication { get; set; }

        /// <summary>
        /// Gets or sets the address information for the lead.
        /// </summary>
        public Address? Address { get; set; }
    }
}
