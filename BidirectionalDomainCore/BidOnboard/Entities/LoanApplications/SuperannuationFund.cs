namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a superannuation fund that can be used in a loan application, including its properties and ownership information.
/// </summary>
public class SuperannuationFund : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the fund manager.
    /// </summary>
    public string? FundManager { get; set; } // need to encrypt

    /// <summary>
    /// Gets or sets a value indicating whether the fund is to be used as security.
    /// </summary>
    public bool ISToBeUsedAsSecurity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the fund is to be sold.
    /// </summary>
    public bool ISToBeSold { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the fund is encumbered.
    /// </summary>
    public bool ISEncumbered { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the fund has a contract of sale.
    /// </summary>
    public bool ISContractOfSale { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether there is not interest in other assets.
    /// </summary>
    public bool ISNotKeenOnOther { get; set; }

    /// <summary>
    /// Gets or sets the value of the superannuation fund.
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or sets the basis for the valuation of the fund.
    /// </summary>
    public string? Basis { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether ownership is to be transferred to a Self-Managed Superannuation Fund (SMSF).
    /// </summary>
    public bool? ISTransferOwnershipToSMSF { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution holding the fund.
    /// </summary>
    public string? FinancialInstitution { get; set; }

    /// <summary>
    /// Gets or sets the name of another financial institution, if applicable.
    /// </summary>
    public string? OtherFIName { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the list of percent owners of non-real estate assets associated with this superannuation fund.
    /// </summary>
    public IList<NonRealEstateAssetOwnershipPercentage> NonRealEstateAssetOwnershipPercentages { get; set; } = new List<NonRealEstateAssetOwnershipPercentage>();
}
