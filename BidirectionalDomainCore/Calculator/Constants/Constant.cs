namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Placeholder for shared domain constants. Contains nested types for parameters, file names, fee types, doc types, and product types.
/// </summary>
public static class Constant
{
}

/// <summary>
/// Parameter names used in fee and matrix calculations (e.g. base value, previous row, fee result).
/// </summary>
public static class Parameters
{
    /// <summary>Base value parameter name.</summary>
    public const string BaseValue = "BaseValue";

    /// <summary>Custom calculated default base value parameter.</summary>
    public const string CustomCalculatedDefaultBaseValue = "CustomCalculatedDefaultBaseValue";

    /// <summary>Dependent product value parameter.</summary>
    public const string DependentProductValue = "DependentProductValue";

    /// <summary>Previous row parameter (for slab/formula context).</summary>
    public const string PreviousRow = "PreviousRow";

    /// <summary>Fee parameter name.</summary>
    public const string Fee = "Fee";

    /// <summary>Fee result value parameter.</summary>
    public const string FeeResultValue = "FeeResultValue";

    /// <summary>Custom slab base value parameter.</summary>
    public const string CustomSlabBaseValue = "CustomSlabBaseValue";

    /// <summary>Rate lock dependent value parameter.</summary>
    public const string RateLockDependentValue = "RateLockDependentValue";
}

/// <summary>
/// JSON configuration file names used for loading products, fees, base values, formulas, and related data.
/// </summary>
public static class Files
{
    /// <summary>Products configuration file.</summary>
    public const string Products = "Products.json";
    /// <summary>Fees configuration file.</summary>
    public const string Fees = "Fees.json";
    /// <summary>Fee conditions configuration file.</summary>
    public const string FeeConditions = "FeeConditions.json";
    /// <summary>Base values configuration file.</summary>
    public const string BaseValues = "BaseValues.json";
    /// <summary>Product LVRs configuration file.</summary>
    public const string ProductLVRs = "ProductLVRs.json";
    /// <summary>Parameters configuration file.</summary>
    public const string Parameters = "Parameters.json";
    /// <summary>Formulas configuration file.</summary>
    public const string Formulas = "Formulas.json";
    /// <summary>Fee detail to fee condition mapper configuration file.</summary>
    public const string FeeDetailFeeConditionMapper = "FeeDetailFeeConditionMapper.json";
    /// <summary>Fee details configuration file.</summary>
    public const string FeeDetails = "FeeDetails.json";
    /// <summary>Product category configuration file.</summary>
    public const string ProductCategory = "ProductCategory.json";
    /// <summary>Product category addition fee configuration file.</summary>
    public const string ProductCategoryAdditionFee = "ProductCategoryAdditionFee.json";
    /// <summary>Custom slabs configuration file.</summary>
    public const string CustomSlabs = "CustomSlabs.json";
    /// <summary>Rate lock fee base scenario configuration file.</summary>
    public const string RateLockFeeBaseScenario = "RateLockFeeBaseScenario.json";
}

/// <summary>
/// Fee type display names used in the system (rate lock, legal, application, risk, establishment, etc.).
/// </summary>
public static class FeeType
{
    /// <summary>Rate lock fee.</summary>
    public const string RateLockFee = "Rate Lock Fee";

    /// <summary>Legal fee.</summary>
    public const string LegalFee = "Legal Fee";

    /// <summary>Application fee.</summary>
    public const string ApplicationFee = "Application Fee";

    /// <summary>Risk fee.</summary>
    public const string RiskFee = "Risk Fee";

    /// <summary>Annual facility fee.</summary>
    public const string AnnualFacilityFee = "Annual Facility Fee";

    /// <summary>Establishment fee.</summary>
    public const string EstablishmentFee = "Establishment Fee";

    /// <summary>Settlement fee.</summary>
    public const string SettlementFee = "Settlement Fee";

    /// <summary>Discharge fee.</summary>
    public const string DischargeFee = "Discharge Fee";

    /// <summary>Rate loading fee.</summary>
    public const string RateLoadingFee = "Rate loading Fee";

    /// <summary>Deed of priority fee.</summary>
    public const string DeedOfPriorityFee = "Deed of priority Fee";

    /// <summary>Offset account fee.</summary>
    public const string OffsetAccountFee = "Offset account fee";

    /// <summary>Default application fee.</summary>
    public const string DefaultApplicationFee = "Default Application Fee";
}

/// <summary>
/// Document type display names (Full Doc, Alt Doc, Lo Doc, No Doc) used for loan documentation classification.
/// </summary>
public static class Doctype
{
    /// <summary>Full documentation type.</summary>
    public const string FullDoc = "Full Doc";
    /// <summary>Alternative documentation type.</summary>
    public const string AltDoc = "Alt Doc";
    /// <summary>Low documentation type.</summary>
    public const string LoDoc = "Lo Doc";
    /// <summary>No documentation type.</summary>
    public const string NoDoc = "No Doc";
}

/// <summary>
/// Product tier/type display names (Ultra Prime, Super Prime, Premium, Optimax, etc.) for risk and pricing.
/// </summary>
public static class ProductType
{
    /// <summary>Ultra prime product type.</summary>
    public const string UlterPrime = "Ultra Prime";
    /// <summary>Super prime product type.</summary>
    public const string SuperPrime = "Super Prime ";
    /// <summary>Premium product type.</summary>
    public const string Premium = "Premium ";
    /// <summary>Optimax product type.</summary>
    public const string Optimax = "Optimax ";
    /// <summary>Tolerant product type.</summary>
    public const string Tolerant = "Tolerant ";
    /// <summary>Progressive product type.</summary>
    public const string Progressive = "Progressive";
    /// <summary>Receptive product type.</summary>
    public const string Receptive = "Receptive";
    /// <summary>Liberal product type.</summary>
    public const string Liberal = "Liberal";
}

/// <summary>
/// Parameter names for dwelling and borrowing entity amounts used in calculations.
/// </summary>
public static class PamameterName
{
    /// <summary>Dwelling amount parameter name.</summary>
    public const string DwellingAmount = "DwellingAmount";

    /// <summary>Borrowing entity amount parameter name.</summary>
    public const string BorrowingEntityAmount = "BorrowingEntityAmount";
}
