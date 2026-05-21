namespace Bidirectional.DomainCore.BidOnboard.Entities.UserRepresentative;

public class UserRepresentativeReference : BaseAuditableEntity
{
    public int? UserRepresentativeReference_UserID { get; set; }

    public RepresentativeReferenceStatus ReferenceStatus { get; set; }

    public string NameOfRepresentative { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string ASICNumber { get; set; } = string.Empty;

    public string AdvisorNumber { get; set; } = string.Empty;

    public string? LicenseAuthorizeBriefDescription { get; set; }

    public bool ISFinancialAdvisorOrMortgageBroker { get; set; }

    public bool ReportBreachToASIC { get; set; }

    public DateOnly? ReportBreachToASICDate { get; set; }

    public string TypeOfBreach { get; set; } = string.Empty;

    public string NatureOfBreach { get; set; } = string.Empty;

    public string RemedialActionTaken { get; set; } = string.Empty;

    public bool ISDishonesty { get; set; }

    public bool ISUnprofessionalConduct { get; set; }

    public bool ISRefusalOrDeliberateNonCompliance { get; set; }

    public bool ISGrossIncompetence { get; set; }

    public bool ISBreachOfFinancialPlanner { get; set; }

    public string? ConductBriefSummary { get; set; }

    public string? ConductInternalAssessment { get; set; }

    public string? ConductExternalNotificationDetails { get; set; }

    public string? ConductFinancialServicesComplaintDetails { get; set; }

    public string? ConductConductOrPerformanceDetails { get; set; }

    public bool ISThereAnyEnquiryOrInvestigation { get; set; }

    public string? EnquiryOrInvestigationDetails { get; set; }

    public string? ComplaintDetails { get; set; }

    public string? ComplianceAndAuditDetails { get; set; }

    public string? ComplaintBriefSummary { get; set; }

    public string? ComplaintInternalAssessment { get; set; }

    public string? ComplaintExternalNotificationDetails { get; set; }

    public string? ComplaintFinancialServicesComplaintDetails { get; set; }

    public string? ComplaintConductOrPerformanceDetails { get; set; }

    public string? ProgressAndStatusOfTheEnquiry { get; set; }

    public User? UserRepresentativeReference_User { get; set; }

    public ICollection<UserComplianceAuditDetail> UserComplianceAuditDetails { get; set; } = [];

    public EmailDetail? EmailDetail { get; set; }

    public PhoneDetail? PhoneDetail { get; set; }
}
