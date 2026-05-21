namespace Bidirectional.DomainCore.Postcode.Constants;

/// <summary>
/// Provides file name constants for various Excel files used in the application.
/// </summary>
public record ExcelFile
{
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
