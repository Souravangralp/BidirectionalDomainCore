namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    public class BusinessCreditEnquiry : BaseAuditableEntity
    {
        public int? BusinessCreditEnquiry_CompanyApplicantID { get; set; }

        public int? BusinessCreditEnquiry_TrustID { get; set; }

        // Section 9a
        public DateTime? LastCheckedForASICUpdatesOnUtc { get; set; }

        public string? RequestID { get; set; }

        public DateTime? ReportCreatedUtc { get; set; }

        public string? ChargeBackNumber { get; set; }

        public DateTime? ASICExtractDateUtc { get; set; }

        // Section 9b
        public bool HasSummary { get; set; }

        public bool HasPublicRecord { get; set; }

        public bool HasOrganizationAndManagementStructure { get; set; }

        public bool HasASICDocuments { get; set; }

        public bool HasCreditHistory { get; set; }

        public int? EquifaxScore { get; set; }

        public decimal? AdverseRiskPercentage { get; set; }

        public int? AdverseRiskMonths { get; set; }

        public CompanyApplicant? BusinessCreditEnquiry_CompanyApplicant { get; set; }

        public Trust? BusinessCreditEnquiry_Trust { get; set; }

        public ICollection<BusinessCreditEnquiryFactor> BusinessCreditEnquiryFactors { get; set; } = [];
    }

}
