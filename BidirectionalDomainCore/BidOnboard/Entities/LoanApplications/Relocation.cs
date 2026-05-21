using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the relocation details associated with a loan application, including relocation type, property information, and related financial data.
/// </summary>
public class Relocation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related relocation loan purpose detail.
    /// </summary>
    public int? Relocation_LoanPurposeDetailID { get; set; }

    /// <summary>
    /// Gets or sets the ID referencing the relocation type from the GeneralLookUp table.
    /// </summary>
    [Comment("We will get this data from GeneralLookUp table")]
    public int? RelocationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the loan account is servicing at peak debt.
    /// </summary>
    public bool? ISServicingAtPeakDebt { get; set; }

    /// <summary>
    /// Gets or sets the ending debt amount after relocation.
    /// </summary>
    public double? EndDebtAmount { get; set; }

    /// <summary>
    /// Gets or sets the property disposal strategy type ID from the GeneralLookUp table.
    /// </summary>
    public int? PropertyDisposalStrategyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the date on which the target property was exchanged, in UTC.
    /// </summary>
    [Comment("Disposal of target property strategy")]
    [Column(TypeName = "date")]
    public DateTime? ExchangedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the repayment plan type ID proposed for interim repayment, from the GeneralLookUp table.
    /// </summary>
    [Comment("Propose interim repayment plan")]
    public int? RepaymentPlanType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the estimated value of the property being relocated.
    /// </summary>
    public double? EstimatedValue { get; set; }

    /// <summary>
    /// Gets or sets the property type ID from the GeneralLookUp table.
    /// </summary>
    public int? PropertyType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the address information of the property involved in the relocation.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// Gets or sets the navigation property representing the related loan purpose detail entity.
    /// </summary>
    public LoanPurposeDetail? Relocation_LoanPurposeDetail { get; set; }
}
