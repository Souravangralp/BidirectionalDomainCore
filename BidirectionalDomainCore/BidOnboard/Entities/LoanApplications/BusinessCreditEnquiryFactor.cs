namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications
{
    public class BusinessCreditEnquiryFactor : BaseAuditableEntity
    {
        public int BusinessCreditEnquiryFactor_BusinessCreditEnquiryID { get; set; }

        /// <summary>
        /// Gets or sets companyRegistration
        /// DirectorInformation
        /// EnquiryPattern
        /// etc.
        /// </summary>
        public string? FactorType { get; set; }

        /// <summary>
        /// Gets or sets low / Medium / High
        /// or numeric scale.
        /// </summary>
        public int? RiskLevel { get; set; }

        public BusinessCreditEnquiry? BusinessCreditEnquiryFactor_BusinessCreditEnquiry { get; set; }
    }

}
