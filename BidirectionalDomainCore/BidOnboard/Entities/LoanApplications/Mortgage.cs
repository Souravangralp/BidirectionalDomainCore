namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a mortgage associated with a loan application, containing property, financial, account, and ownership details.
/// </summary>
public class Mortgage : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan application for this mortgage.
    /// </summary>
    public int? Mortgage_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets the name of the financial institution providing the mortgage.
    /// </summary>
    public string? NameOfFinancialInstitution { get; set; }

    /// <summary>
    /// Gets or sets the street number of the mortgaged property.
    /// </summary>
    public string? StreetNumber { get; set; }

    /// <summary>
    /// Gets or sets the street name of the mortgaged property.
    /// </summary>
    public string? StreetName { get; set; }

    /// <summary>
    /// Gets or sets the suburb location of the mortgaged property.
    /// </summary>
    public string? Suburb { get; set; }

    /// <summary>
    /// Gets or sets the postal code for the mortgaged property.
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the state where the mortgaged property is located.
    /// </summary>
    public int? Mortgage_StateID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the country where the mortgaged property is located.
    /// </summary>
    public int? Mortgage_CountryID { get; set; }

    /// <summary>
    /// Gets or sets the collection of account information related to the mortgage.
    /// </summary>
    public IList<MortgageAccountInformation> MortgageAccountsInformation { get; set; } = new List<MortgageAccountInformation>();

    /// <summary>
    /// Gets or sets a value indicating whether the mortgage is to be refinanced.
    /// </summary>
    public bool? ToBeRefinanced { get; set; }

    /// <summary>
    /// Gets or sets the estimated value of the property securing the mortgage.
    /// </summary>
    public double? EstimatedValue { get; set; }

    /// <summary>
    /// Gets or sets the weekly rental income for the mortgaged property.
    /// </summary>
    public double? WeeklyRent { get; set; }

    /// <summary>
    /// Gets or sets the minimum required monthly repayment on the mortgage.
    /// </summary>
    public double? MinimumMonthlyRepayment { get; set; }

    /// <summary>
    /// Gets or sets the amount currently owing on the mortgage.
    /// </summary>
    public double? AmountCurrentlyOwing { get; set; }

    /// <summary>
    /// Gets or sets the identifier relating to the security type of the mortgage from the General Lookup table.
    /// </summary>
    public int? SecurityType_GeneralLookupID { get; set; }

    /// <summary>
    /// Gets or sets the identifier relating to the usage type of the mortgaged property from the General Lookup table.
    /// </summary>
    public int? UsageType_GeneralLookupID { get; set; }

    #region Remove fields

    /// <summary>
    /// Gets or sets the annual property depreciation value.
    /// </summary>
    public double? AnnualPropertyDepreciation { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the current mortgage type from the General Lookup table (e.g., ISInsideSMSF or OutsideSMSF).
    /// </summary>
    [Comment("We will get this from GeneralLookUp table (ISInsideSMSF Or OutsideSMSF)")]
    public int? CurrentMortgageType_GeneralLookupID { get; set; }

    /// <summary>
    /// Gets or sets the collection of percent ownership details for the mortgage.
    /// </summary>
    public IList<MortgageOwnershipPercentage> MortgageOwnershipPercentages { get; set; } = new List<MortgageOwnershipPercentage>();

    #endregion

    /// <summary>
    /// Gets or sets the associated loan application entity for this mortgage.
    /// </summary>
    public LoanApplication? Mortgage_LoanApplication { get; set; }
}
