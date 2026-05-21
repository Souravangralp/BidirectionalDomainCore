namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class IndustryExperience : BaseAuditableEntity
{
    public int IndustryExperience_UserID { get; set; }

    public int? EmploymentType_CoreDB_GeneralLookUpID { get; set; } // Full-time, Part-time, Self-employed, Contract

    public int? JobTitleType_CoreDB_GeneralLookUpID { get; set; } // e.g., Mortgage Broker, Loan Processor, Credit Analyst

    public decimal? ExperienceInYears { get; set; }

    public decimal? ExperienceInMonths { get; set; }

    public string? OtherJobTitle { get; set; }

    public string? OtherEmploymentType { get; set; }

    public string? EmployerOrBusinessName { get; set; } // Employer name or Business operated

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? AggregatorName { get; set; }

    public string? AggregatorContactName { get; set; }

    public string? AggregatorContactEmail { get; set; }

    public string? AggregatorContactPhone { get; set; }

    public string? AccreditedLenders { get; set; } // Lender accreditations during this period e.g., Commbank, ANZ, Westpac

    public string? LicenseType { get; set; } // ACL, CAR, etc.

    public string? LicenseNumber { get; set; }

    public DateOnly? LicenseIssueDate { get; set; }

    public DateOnly? LicenseExpiryDate { get; set; }

    public string? MainBusinessFocus { get; set; } // Residential Loans, Asset Finance, Refinance, etc.

    public string? Notes { get; set; }

    public bool ISCurrent { get; set; }

    public User? IndustryExperience_User { get; set; }
}
