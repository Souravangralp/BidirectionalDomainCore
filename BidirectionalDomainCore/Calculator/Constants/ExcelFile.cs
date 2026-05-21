namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Excel workbook file names used for importing base rates, loadings, fees, matrices, and related configuration.
/// Each static instance represents a known Excel file (e.g. TargetBaseRates.xlsx, CommonData.xlsx).
/// </summary>
public record ExcelFile
{
    /// <summary>Gets the file name of this Excel workbook.</summary>
    public string FileName { get; } = string.Empty;

    private ExcelFile(string fileName)
    {
        FileName = fileName;
    }

    //public static readonly ExcelFile BaseRate = new ("BaseRates.xlsx");

    //public static readonly ExcelFile BrandLoading = new ("BrandLoadings.xlsx");

    /// <summary>Target base rates workbook.</summary>
    public static readonly ExcelFile TargetBaseRate = new("TargetBaseRates.xlsx");

    /// <summary>Common data workbook (doc types, products, look-ups, loadings).</summary>
    public static readonly ExcelFile CommonData = new("CommonData.xlsx");

    /// <summary>Loading workbook.</summary>
    public static readonly ExcelFile Loading = new("Loading.xlsx");

    /// <summary>Rate calculation criteria workbook.</summary>
    public static readonly ExcelFile RateCalculationCriteria = new("RateCalculationCriteria.xlsx");

    /// <summary>Reverting rate workbook.</summary>
    public static readonly ExcelFile RevertingRate = new("RevertingRate.xlsx");

    /// <summary>Matrix detail workbook.</summary>
    public static readonly ExcelFile MatrixDetail = new("MatrixDetail.xlsx");

    /// <summary>Fee details workbook.</summary>
    public static readonly ExcelFile FeeDetails = new("FeeDetails.xlsx");

    /// <summary>WBC swap matrix detail workbook (SwapMatrix.xlsx).</summary>
    public static readonly ExcelFile WbcSwapMatrixDetail = new("SwapMatrix.xlsx");

    /// <summary>Brand loading sheet workbook.</summary>
    public static readonly ExcelFile BrandLoadingSheet = new("BrandLoadingSheet.xlsx");

    /// <summary>Fee adjustment workbook (discount and additional margin).</summary>
    public static readonly ExcelFile FeeAdjustmententry = new("DiscountAndAdditionalMargin.xlsx");

    /// <summary>Product category addition fees workbook.</summary>
    public static readonly ExcelFile ProductCategoryAdditionFees = new("ProductCategoryAdditionFees.xlsx");

    /// <summary>Rate lock fee details workbook.</summary>
    public static readonly ExcelFile RateLockFeeDetails = new("RateLockFeeDetails.xlsx");

    /// <summary>Legal fees details workbook.</summary>
    public static readonly ExcelFile LegalFees = new("LegalFeesDetails.xlsx");
}
