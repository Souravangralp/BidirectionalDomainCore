namespace Bidirectional.DomainCore.Postcode.Constants;

/// <summary>
/// Contains constant values and types related to postcodes classification, categorization, and security.
/// </summary>
[ExcludeFromCodeCoverage]
public record PostcodesConstants
{
    /// <summary>
    /// Defines classification type string constants for postcodes.
    /// </summary>
    public record ClassificationType
    {
        /// <summary>
        /// Classification type for PCCategory.
        /// </summary>
        public static readonly string PCCategory = "PCCategory";

        /// <summary>
        /// Classification type for Standard and Poor.
        /// </summary>
        public static readonly string StandardAndPoor = "StandardAndPoor";

        /// <summary>
        /// Classification type for High Security.
        /// </summary>
        public static readonly string HighSecurity = "HighSecurity";

        /// <summary>
        /// Classification type for Unsuitable.
        /// </summary>
        public static readonly string Unsuitable = "Unsuitable";
    }

    /// <summary>
    /// Contains constants for types of high security classifications for postcodes.
    /// </summary>
    public record HighSecurityType
    {
        /// <summary>
        /// High security type for High Density areas.
        /// </summary>
        public static readonly string HighDensity = "HighDensity";

        /// <summary>
        /// High security type for Selected Non-Metro areas.
        /// </summary>
        public static readonly string SelectedNonMetro = "SelectedNonMetro";

        /// <summary>
        /// High security type for Metro Plus areas.
        /// </summary>
        public static readonly string MetroPlus = "MetroPlus";
    }

    /// <summary>
    /// Contains constants for different island or land location types.
    /// </summary>
    public record IsLandLocation
    {
        /// <summary>
        /// Type for Beach locations.
        /// </summary>
        public static readonly string Beach = "Beach";

        /// <summary>
        /// Type for Island locations.
        /// </summary>
        public static readonly string Island = "Island";

        /// <summary>
        /// Type for Creek locations.
        /// </summary>
        public static readonly string Creek = "Creek";

        /// <summary>
        /// Type for Point locations.
        /// </summary>
        public static readonly string Point = "Point";

        /// <summary>
        /// Type for Bay locations.
        /// </summary>
        public static readonly string Bay = "Bay";

        /// <summary>
        /// Type for Bite locations.
        /// </summary>
        public static readonly string Bite = "Bite";

        /// <summary>
        /// Type for Retreat locations.
        /// </summary>
        public static readonly string Retreat = "Retreat";
    }

    /// <summary>
    /// Provides RGB hex color codes used for postcode classifications.
    /// </summary>
    public static class ClassificationsRGB
    {
        /// <summary>
        /// RGB code for Dark Blue color.
        /// </summary>
        public const string DarkBlue = "FF002060";

        /// <summary>
        /// RGB code for Red color.
        /// </summary>
        public const string Red = "FFFF0000";

        /// <summary>
        /// RGB code for Light Blue color.
        /// </summary>
        public const string LightBlue = "FF00B0F0";

        /// <summary>
        /// RGB code for Green color.
        /// </summary>
        public const string Green = "FF92D050";

        /// <summary>
        /// RGB code for Light Violet color.
        /// </summary>
        public const string LightViolet = "FF33CCCC";

        /// <summary>
        /// RGB code for Spanish Blue color.
        /// </summary>
        public const string SpanishBlue = "FF0070C0";
    }

    /// <summary>
    /// Specifies constants for Standard and Poor classification values.
    /// </summary>
    public static class StandardAndPoor
    {
        /// <summary>
        /// Classification value for Metro area.
        /// </summary>
        public const int Metro = 295;

        /// <summary>
        /// Classification value for Non-Metro area.
        /// </summary>
        public const int NonMetro = 296;

        /// <summary>
        /// Classification value for Inner City area.
        /// </summary>
        public const int InnerCity = 297;

        /// <summary>
        /// Classification value for Excluded area.
        /// </summary>
        public const int Excluded = 298;

        /// <summary>
        /// Type alias for Excluded classification.
        /// </summary>
        public const string ExcludedType = "Excluded";
    }

    /// <summary>
    /// Contains constants for postcode category types and values.
    /// </summary>
    public static class PCCategoryType
    {
        /// <summary>
        /// Category 1 postcode value.
        /// </summary>
        public const int Category1 = 256;

        /// <summary>
        /// Category 2 postcode value.
        /// </summary>
        public const int Category2 = 257;

        /// <summary>
        /// Category 3 postcode value.
        /// </summary>
        public const int Category3 = 258;

        /// <summary>
        /// Value for Unlisted category.
        /// </summary>
        public const int UnListed = 259;

        /// <summary>
        /// Type alias for Unlisted category.
        /// </summary>
        public const string UnListedType = "UnListed";
    }

    /// <summary>
    /// Provides lookup constants for general high security types.
    /// </summary>
    public static class HighSecurityGeneralLookUpType
    {
        /// <summary>
        /// Lookup value for Metro Plus high security type.
        /// </summary>
        public const int MetroPlus = 141;

        /// <summary>
        /// Lookup value for High Density high security type.
        /// </summary>
        public const int HighDensity = 142;

        /// <summary>
        /// Lookup value for Selected Non-Metro high security type.
        /// </summary>
        public const int SelectedNonMetro = 143;
    }
}
