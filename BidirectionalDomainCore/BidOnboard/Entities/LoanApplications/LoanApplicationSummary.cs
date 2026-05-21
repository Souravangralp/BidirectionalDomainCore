namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a summary of key loan application details, including risk, fee, and serviceability information.
/// </summary>
public class LoanApplicationSummary : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the associated Loan Application ID for the summary.
    /// </summary>
    public int? LoanApplicationSummary_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the GeneralLookUp ID representing the loan repayment strategy type.
    /// </summary>
    public int? LoanRepaymentStrategyType_GeneralLookUpID { get; set; } // We will get this from GeneralLookUp Table

    /// <summary>
    /// Gets or sets the GeneralLookUp ID specifying the credit risk exception type.
    /// </summary>
    public int? CreditRiskExceptionType_GeneralLookUpID { get; set; } // We will get this from GeneralLookUp Table

    /// <summary>
    /// Gets or sets the GeneralLookUp ID indicating whether the application involves a purchase.
    /// </summary>
    public int? ApplicationThatInvolvesPurchaseType_GeneralLookUpID { get; set; } // We will get this from GeneralLookUp Table

    public int? FeeType_GeneralLookUpID { get; set; } // We will get this from GeneralLookUp Table

    public bool ISLoanSuitable { get; set; }

    public bool ISCapitalizeFee { get; set; }

    public double? Amount { get; set; }

    public string? LoanToValueRatio { get; set; }

    public string? ServiceabilityResult { get; set; }

    public string? ExtraField1 { get; set; }

    public string? ExtraField2 { get; set; }

    public string? ExtraField3 { get; set; }

    public LoanApplication? LoanApplicationSummary_LoanApplication { get; set; }

    public DocumentationInstruction? DocumentationInstruction { get; set; }
}
