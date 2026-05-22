namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Gets the Excel worksheet/sheet names used when reading workbooks. Each nested record holds sheet names for a specific
/// workbook (e.g. BaseRate, BrandLoadings, TargetBaseRate, CommonData, Loading, FeeDetail, MatrixDetail).
/// </summary>
public record Worksheet
{
    /// <summary>Gets the sheet names for the base rate workbook (BaseRateCategory, BaseRates).</summary>
    public record BaseRate
    {
        /// <summary>Gets the BaseRateCategory sheet name.</summary>
        public const string BaseRateCategory = "BaseRateCategory";

        /// <summary>Gets the BaseRates sheet name.</summary>
        public const string BaseRates = "BaseRates";
    }

    /// <summary>Gets the sheet names for brand loadings (BrandType, BrandLoadingCategory, BrandLoading, PricingAdjustment).</summary>
    public record BrandLoadings
    {
        /// <summary>Gets the BrandType sheet name.</summary>
        public const string BrandType = "BrandType";

        /// <summary>Gets the BrandLoadingCategory sheet name.</summary>
        public const string BrandLoadingCategory = "BrandLoadingCategory";

        /// <summary>Gets the BrandLoading sheet name.</summary>
        public const string BrandLoading = "BrandLoading";

        /// <summary>Gets the PricingAdjustment sheet name.</summary>
        public const string PricingAdjustment = "PricingAdjustment";
    }

    /// <summary>Gets the sheet names for target base rate workbook (BaseRate, TargetComparisionRate, TargetFeeSetting).</summary>
    public record TargetBaseRate
    {
        /// <summary>Gets the BaseRate sheet name.</summary>
        public const string BaseRate = "BaseRate";

        /// <summary>Gets the TargetComparisionRate sheet name.</summary>
        public const string TargetComparisonRate = "TargetComparisionRate";

        /// <summary>Gets the TargetFeeSetting sheet name.</summary>
        public const string TargetFeeSetting = "TargetFeeSetting";
    }

    /// <summary>Gets the sheet names for common data workbook (DocType, Product, look-ups, loadings).</summary>
    public record CommonData
    {
        /// <summary>Gets the DocType sheet name.</summary>
        public const string DocType = "DocType";

        /// <summary>Gets the Product sheet name.</summary>
        public const string Product = "Product";

        /// <summary>Gets the ProductCategory sheet name.</summary>
        public const string ProductCategory = "ProductCategory";

        /// <summary>Gets the EarlyRepaymentFee sheet name.</summary>
        public const string EarlyRepaymentFee = "EarlyRepaymentFee";

        /// <summary>Gets the DiscountPrepayment sheet name.</summary>
        public const string DiscountPrepayment = "DiscountPrepayment";

        /// <summary>Gets the DiscountSavingLimit sheet name.</summary>
        public const string DiscountSavingLimit = "DiscountSavingLimit";

        /// <summary>Gets the ResidencyType sheet name.</summary>
        public const string ResidencyType = "ResidencyType";

        /// <summary>Gets the ResidencyTypeLoading sheet name.</summary>
        public const string ResidencyTypeLoading = "ResidencyTypeLoading";

        /// <summary>Gets the PoliticallyExposedLoading sheet name.</summary>
        public const string PoliticallyExposedLoading = "PoliticallyExposedLoading";

        /// <summary>Gets the HighRiskType sheet name.</summary>
        public const string HighRiskType = "HighRiskType";

        /// <summary>Gets the HighRiskLoading sheet name.</summary>
        public const string HighRiskLoading = "HighRiskLoading";

        /// <summary>Gets the GeneralLookUps sheet name.</summary>
        public const string GeneralLookUps = "GeneralLookUps";

        /// <summary>Gets the LoadingPercentWithProduct sheet name.</summary>
        public const string LoadingPercentWithProduct = "LoadingPercentWithProduct";
    }

    /// <summary>Gets the sheet names for loading workbook (DocTypeLoading, ProductLoading).</summary>
    public record Loading
    {
        /// <summary>Gets the DocTypeLoading sheet name.</summary>
        public const string DocTypeLoading = "DocTypeLoading";

        /// <summary>Gets the ProductLoading sheet name.</summary>
        public const string ProductLoading = "ProductLoading";
    }

    /// <summary>Gets the sheet names for rate calculation criteria (RateCalculationCriteria, ProductLVRLimit).</summary>
    public record RateCalculationCriteria
    {
        /// <summary>Gets the RateCalculationCriteria sheet name.</summary>
        public const string RateCalculation = "RateCalculationCriteria";

        /// <summary>Gets the ProductLVRLimit sheet name.</summary>
        public const string ProductLVRLimit = "ProductLVRLimit";
    }

    /// <summary>Gets the sheet names for reverting rate workbook (BaseRevertingRate, BaseIncrementRevertingRate).</summary>
    public record RevertingRate
    {
        /// <summary>Gets the BaseRevertingRate sheet name.</summary>
        public const string BaseRevertingRate = "BaseRevertingRate";

        /// <summary>Gets the BaseIncrementRevertingRate sheet name.</summary>
        public const string BaseIncrementRevertingRate = "BaseIncrementRevertingRate";
    }

    /// <summary>Gets the sheet names for product category additional fee workbook.</summary>
    public record ProductCategoryAdditionalFee
    {
        /// <summary>Gets the ProductCategoryAdditionalFee sheet name.</summary>
        public const string ProductCategoryAdditionalFees = "ProductCategoryAdditionalFee";

        /// <summary>Gets the FeeDetails sheet name.</summary>
        public const string FeeDetails = "FeeDetails";

        /// <summary>Gets the ApplicableFee sheet name.</summary>
        public const string ApplicableFee = "ApplicableFee";

        /// <summary>Gets the FeeFloorByLoanType sheet name.</summary>
        public const string FeeFloorByLoanType = "FeeFloorByLoanType";
    }

    /// <summary>Gets the sheet name for rate lock fee base data.</summary>
    public record RateLockFeeDetails
    {
        /// <summary>Gets the RateLockFeeBaseData sheet name.</summary>
        public const string RateLockFeeBaseData = "RateLockFeeBaseData";
    }

    /// <summary>Gets the sheet name for legal fees base data.</summary>
    public record LegalFeesDetails
    {
        /// <summary>Gets the LegalFeesBaseData sheet name.</summary>
        public const string LegalFeesBaseData = "LegalFeesBaseData";
    }

    /// <summary>Gets the sheet names for matrix detail workbook (MatrixDetail, MatrixFeeConditionMapper).</summary>
    public record MatrixDetail
    {
        /// <summary>Gets the MatrixDetail sheet name.</summary>
        public const string MatrixData = "MatrixDetail";

        /// <summary>Gets the MatrixFeeConditionMapper sheet name.</summary>
        public const string MatrixFeeConditionMapper = "MatrixFeeConditionMapper";
    }

    /// <summary>Gets the sheet names for fee detail workbook (FeeDetails, FeeConditions, Formulas).</summary>
    public record FeeDetail
    {
        /// <summary>Gets the FeeDetails sheet name.</summary>
        public const string FeeDetails = "FeeDetails";

        /// <summary>Gets the FeeConditions sheet name.</summary>
        public const string FeeConditions = "FeeConditions";

        /// <summary>Gets the Formulas sheet name.</summary>
        public const string Formulas = "Formulas";
    }

    /// <summary>Gets the sheet names for WBC swap matrix (SwapMatrix, SwapMatrixCategory).</summary>
    public record WBCSwapMatrix
    {
        /// <summary>Gets the SwapMatrix sheet name.</summary>
        public const string WbcSwapMatrixDetail = "SwapMatrix";

        /// <summary>Gets the SwapMatrixCategory sheet name.</summary>
        public const string WbcSwapMatrixCategory = "SwapMatrixCategory";
    }

    /// <summary>Gets the sheet names for brand loading sheet (BrandLoading, BrandLoadingCatagory, RateLoading, BrandType).</summary>
    public record BrandLoading
    {
        /// <summary>Gets the BrandLoading sheet name.</summary>
        public const string BrandLoadingSheet = "BrandLoading";

        /// <summary>Gets the BrandLoadingCatagory sheet name.</summary>
        public const string BrandLoadingCategory = "BrandLoadingCatagory";

        /// <summary>Gets the RateLoading sheet name.</summary>
        public const string RateLoading = "RateLoading";

        /// <summary>Gets the BrandType sheet name.</summary>
        public const string BrandType = "BrandType";
    }

    /// <summary>Gets the sheet name for fee adjustment (DiscountAndAdditionalMargin).</summary>
    public record FeeAdjustment
    {
        /// <summary>Gets the DiscountAndAdditionalMargin sheet name.</summary>
        public const string DiscountAndAdditionalMargin = "DiscountAndAdditionalMargin";
    }
}
