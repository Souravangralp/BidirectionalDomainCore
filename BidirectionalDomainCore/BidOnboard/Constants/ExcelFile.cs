namespace Bidirectional.DomainCore.BidOnboard.Constants;

public record ExcelFile()
{
    public static readonly string GeneralLookUp = "GeneralLookUp.xlsx";

    public static readonly string PermissionsData = "PermissionsData.xlsx";

    public static readonly string PrivacyPolicy = "PrivacyPolicy.xlsx";

    public static readonly string Workflow = "Workflow.xlsx";

    public static readonly string BSBDirectory = "BSBDirectory.xlsx";

    public static readonly string Agreements = "Agreements.xlsx";

    /// <summary>Target base rates workbook.</summary>
    public static readonly string TargetBaseRate = "TargetBaseRates.xlsx";

    /// <summary>Common data workbook (doc types, products, look-ups, loadings).</summary>
    public static readonly string CommonData = "CommonData.xlsx";

    /// <summary>Loading workbook.</summary>
    public static readonly string Loading = "Loading.xlsx";

    /// <summary>Rate calculation criteria workbook.</summary>
    public static readonly string RateCalculationCriteria = "RateCalculationCriteria.xlsx";

    /// <summary>Reverting rate workbook.</summary>
    public static readonly string RevertingRate = "RevertingRate.xlsx";

    /// <summary>Matrix detail workbook.</summary>
    public static readonly string MatrixDetail = "MatrixDetail.xlsx";

    /// <summary>Fee details workbook.</summary>
    public static readonly string FeeDetails = "FeeDetails.xlsx";

    /// <summary>WBC swap matrix detail workbook (SwapMatrix.xlsx).</summary>
    public static readonly string WbcSwapMatrixDetail = "SwapMatrix.xlsx";

    /// <summary>Brand loading sheet workbook.</summary>
    public static readonly string BrandLoadingSheet = "BrandLoadingSheet.xlsx";

    /// <summary>Fee adjustment workbook (discount and additional margin).</summary>
    public static readonly string FeeAdjustmententry = "DiscountAndAdditionalMargin.xlsx";

    /// <summary>Product category addition fees workbook.</summary>
    public static readonly string ProductCategoryAdditionFees = "ProductCategoryAdditionFees.xlsx";

    /// <summary>Rate lock fee details workbook.</summary>
    public static readonly string RateLockFeeDetails = "RateLockFeeDetails.xlsx";

    /// <summary>Legal fees details workbook.</summary>
    public static readonly string LegalFees = "LegalFeesDetails.xlsx";

    /// <summary>
    /// Gets the file name for the postcode Excel file.
    /// </summary>
    public static readonly string Postcode = "Postcode.xlsx";

    /// <summary>
    /// Gets the file name for the postcode classifications Excel file.
    /// </summary>
    public static readonly string PostcodeClassifications = "PostcodeClassifications.xlsx";

    /// <summary>
    /// Gets the file name for the latest postcode classifications Excel file.
    /// </summary>
    public static readonly string LatestPostcodeClassifications = "LatestPostcodeClassifications.xlsx";
}

/// <summary>
/// Provides sheet name constants for various sheets within Excel files used in the application.
/// </summary>
public record ExcelSheetName()
{
    /// <summary>
    /// Gets the name of the GeneralLookUps sheet.
    /// </summary>
    public static readonly string GeneralLookUps = "GeneralLookUps";

    /// <summary>
    /// Gets the name of the Suburbs sheet.
    /// </summary>
    public static readonly string Suburbs = "Suburbs";

    /// <summary>
    /// Gets the name of the PostcodeClassifications sheet.
    /// </summary>
    public static readonly string PostcodeClassifications = "PostcodeClassifications";

    /// <summary>
    /// Gets the name of the PostcodeClassificationMapper sheet.
    /// </summary>
    public static readonly string PostcodeClassificationMapper = "PostcodeClassificationMapper";

    /// <summary>
    /// Gets the name of the Block 1 sheet.
    /// </summary>
    public static readonly string Block1 = "Block 1";

    /// <summary>
    /// Gets the name of the Block 2 sheet.
    /// </summary>
    public static readonly string Block2 = "Block 2";

    /// <summary>
    /// Gets the name of the Category 1 sheet.
    /// </summary>
    public static readonly string Category1 = "Category 1";

    /// <summary>
    /// Gets the name of the Category 2 sheet.
    /// </summary>
    public static readonly string Category2 = "Category 2";

    /// <summary>
    /// Gets the name of the Category 3 sheet.
    /// </summary>
    public static readonly string Category3 = "Category 3";

    /// <summary>
    /// Gets the name of the Excluded sheet.
    /// </summary>
    public static readonly string Excluded = "Excluded";

    /// <summary>
    /// Gets the name of the High density sheet.
    /// </summary>
    public static readonly string HighDensity = "High density";

    /// <summary>
    /// Gets the name of the Inner city sheet.
    /// </summary>
    public static readonly string InnerCity = "Inner city";

    /// <summary>
    /// Gets the name of the Metro sheet.
    /// </summary>
    public static readonly string Metro = "Metro";

    /// <summary>
    /// Gets the name of the Metro plus sheet.
    /// </summary>
    public static readonly string MetroPlus = "Metro plus";

    /// <summary>
    /// Gets the name of the Non metro sheet.
    /// </summary>
    public static readonly string NonMetro = "Non metro";

    /// <summary>
    /// Gets the name of the Selected non metro sheet.
    /// </summary>
    public static readonly string SelectedNonMetro = "Selected non metro";

    /// <summary>
    /// Gets the name of the Unlisted sheet.
    /// </summary>
    public static readonly string Unlisted = "Unlisted";
}
