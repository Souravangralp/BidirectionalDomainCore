namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a saving or term deposit account associated with a loan application, detailing financial institution data, account details, and ownership specifics.
/// </summary>
public class SavingAndTermDepositAccount : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related loan application.
    /// </summary>
    public int? SavingAndTermDepositAccount_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the account type lookup ID from the core database.
    /// </summary>
    public int? SavingAccountType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution holding the account.
    /// </summary>
    public string? FinancialInstitution { get; set; }

    /// <summary>
    /// Gets or sets the account number of the saving or term deposit account.
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the current balance of the account.
    /// </summary>
    public double? Balance { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the account is related to a contract of sale.
    /// </summary>
    public bool ISContractOfSale { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the account is to be used as security for the loan.
    /// </summary>
    public bool ISToBeUsedAsSecurity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the account is intended to be sold.
    /// </summary>
    public bool ISToBeSold { get; set; }

    /// <summary>
    /// Gets or sets the value of the account if sold or used as security.
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// Gets or sets the basis for the account valuation or its use.
    /// </summary>
    public string? Basis { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether ownership of the account will be transferred to SMSF (Self-Managed Superannuation Fund).
    /// </summary>
    public bool? ISTransferOwnershipToSMSF { get; set; }

    /// <summary>
    /// Gets or sets the name of another financial institution, if applicable.
    /// </summary>
    public string? OtherFIName { get; set; }

    /// <summary>
    /// Gets or sets the Bank State Branch (BSB) code for the account.
    /// </summary>
    public string? BSB { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional custom information.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional custom information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for additional custom information.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets the collection of ownership percentage allocations for this non-real estate asset.
    /// </summary>
    public IList<NonRealEstateAssetOwnershipPercentage> NonRealEstateAssetOwnershipPercentages { get; set; } = new List<NonRealEstateAssetOwnershipPercentage>();
}
