namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a summary of a company within a loan application, providing detailed information for various sections such as company structure, credit history, risk assessments, and associated header values.
/// </summary>
public class CompanySummary : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID referencing the introduction to the customer for this company summary.
    /// </summary>
    [Comment("This Table will contain fields for Section 9a, 9b, 9c, 9h and header values for all sections" + "Section 9(a)")]
    public int? CompanySummary_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the ID of the summary request.
    /// </summary>
    [Comment("Section 9(a)")]
    public string? SummaryRequestID { get; set; }

    /// <summary>
    /// Gets or sets the enriched company score request information.
    /// </summary>
    [Comment("Section 9(a) - Enriched on - header Value")]
    public string? EnrichedCompanyScoreRequest { get; set; }

    /// <summary>
    /// Gets or sets the chargeback reference number associated with this summary.
    /// </summary>
    [Comment("Section 9(a)")]
    public string? ChargeBackReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the UTC date when the summary report was created.
    /// </summary>
    [Column(TypeName = "date")]
    [Comment("Section 9(a)")]
    public DateTime? SummaryReportCreatedDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of the last ASIC update.
    /// </summary>
    [Column(TypeName = "date")]
    [Comment("Section 9(a)")]
    public DateTime? LastASICUpdateDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the UTC date of the ASIC extract.
    /// </summary>
    [Column(TypeName = "date")]
    [Comment("Section 9(a)")]
    public DateTime? ASICExtractDateUtc { get; set; }

    /// <summary>
    /// Gets or sets the total summary counts for the company.
    /// </summary>
    [Comment("Section 9(b)")]
    public int? SummaryCounts { get; set; }

    /// <summary>
    /// Gets or sets the number of public records found for the company.
    /// </summary>
    [Comment("Section 9(b)")]
    public int? PublicRecordCounts { get; set; }

    /// <summary>
    /// Gets or sets the number of organizational and management structure records.
    /// </summary>
    [Comment("Section 9(b)")]
    public int? OrgAndMgmtStructureCounts { get; set; }

    /// <summary>
    /// Gets or sets the number of ASIC documents related to the company.
    /// </summary>
    [Comment("Section 9(b)")]
    public int? ASICDocumentCounts { get; set; }

    /// <summary>
    /// Gets or sets the count of credit history records.
    /// </summary>
    [Comment("Section 9(b)")]
    public int? CreditHistoryCounts { get; set; }

    /// <summary>
    /// Gets or sets the Equifax credit score of the company.
    /// </summary>
    [Comment("Section 9(b)")]
    public int? EquifaxCreditScore { get; set; }

    /// <summary>
    /// Gets or sets the percentage chance of an adverse event occurring.
    /// </summary>
    [Comment("Section 9(b) - % chance of adverse")]
    public double? ChanceOfAdverseEvent { get; set; }

    /// <summary>
    /// Gets or sets the number of months the adverse event chance applies to.
    /// </summary>
    [Comment("Section 9(b) chance of adverse in the next months")]
    public int? ChanceOfAdverseInNextMonths { get; set; }

    /// <summary>
    /// Gets or sets the risk type for company registration, referencing the 'RiskType' in GeneralLookUp.
    /// </summary>
    [Comment("Section 9(c) Company Registration - Will Have value 1 to 3, Seeded under Type 'RiskType' in GeneralLookUp")]
    public int? CompanyRegistrationRiskType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the risk type for director information, referencing the 'RiskType' in GeneralLookUp.
    /// </summary>
    [Comment("Section 9(c) Director Information - Will Have value 1 to 3, Seeded under Type 'RiskType' in GeneralLookUp")]
    public int? DirectorInformationRiskType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the risk type for enquiry pattern, referencing the 'RiskType' in GeneralLookUp.
    /// </summary>
    [Comment("Section 9(c) Enquiry pattern - Will Have value 1 to 3, Seeded under Type 'RiskType' in GeneralLookUp")]
    public int? EnquiryPatternRiskType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the count of adverse actions involving company directors.
    /// </summary>
    [Comment("Section 9(h)")]
    public int? CompanyDirectorsAdverse { get; set; }

    /// <summary>
    /// Gets or sets the count of adverse actions involving directors of related entities.
    /// </summary>
    [Comment("Section 9(h)")]
    public int? CompanyDirectorsRelatedEntityAdverse { get; set; }

    /// <summary>
    /// Gets or sets the number of current and prior external administration events.
    /// </summary>
    [Comment("Section 9(h) - Current & prior external administration count")]
    public int? ExternalAdministrationCount { get; set; }

    /// <summary>
    /// Gets or sets the count of current and prior deregistration or strike-offs.
    /// </summary>
    [Comment("Section 9(h) - Current & prior deregistration/strike-offs count")]
    public int? DeregistrationAndStrikeOffCount { get; set; }

    /// <summary>
    /// Gets or sets the number of company directors.
    /// </summary>
    [Comment("Section 9(k) Header value")]
    public int? DirectorCounts { get; set; }

    /// <summary>
    /// Gets or sets the number of company secretaries.
    /// </summary>
    [Comment("Section 9(l) Header value")]
    public int? CompanySecretaryCounts { get; set; }

    /// <summary>
    /// Gets or sets the number of business proprietorships.
    /// </summary>
    [Comment("Section 9(m) Header value")]
    public int? BusinessProprietorshipCounts { get; set; }

    /// <summary>
    /// Gets or sets the total value of business proprietorships.
    /// </summary>
    [Comment("Section 9(m) Header value")]
    public int? TotalAmountOfBusinessProprietorshipsValue { get; set; }

    /// <summary>
    /// Gets or sets the count of company shares issued.
    /// </summary>
    [Comment("Section 9(n) Header value")]
    public int? CompanySharesIssuedCount { get; set; }

    /// <summary>
    /// Gets or sets the total value of issued company shares.
    /// </summary>
    [Comment("Section 9(n) Header value")]
    public int? TotalAmountOfCompanySharesValue { get; set; }

    /// <summary>
    /// Gets or sets the number of credit enquiries made for the company.
    /// </summary>
    [Comment("Section 9(r) Header Value")]
    public int? CreditEnquiriesCounts { get; set; }

    /// <summary>
    /// Gets or sets the total value of credit enquiries for the company.
    /// </summary>
    [Comment("Section 9(r) Header Value")]
    public int? TotalAmountOfCreditEnquiriesValue { get; set; }

    /// <summary>
    /// Gets or sets the number of addresses associated with the company.
    /// </summary>
    [Comment("Section 9(s) Header Value")]
    public int? NumberOfCompanyAddresses { get; set; }

    /// <summary>
    /// Gets or sets the count of company document listings.
    /// </summary>
    [Comment("Section 9(t) Header Value")]
    public int? NumberOfCompanyDocumentListing { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for the linked introduction to the customer entity.
    /// </summary>
    public IntroductionToTheCustomer? CompanySummary_IntroductionToTheCustomer { get; set; }
}
