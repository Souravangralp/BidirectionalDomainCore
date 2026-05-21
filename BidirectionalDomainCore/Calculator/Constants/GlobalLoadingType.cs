namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Loading type display names: brand-specific loading vs multi-brand loading (e.g. "Prime residential full doc I").
/// </summary>
public record GlobalLoadingType
{
    /// <summary>Brand specific loading type.</summary>
    public const string BrandSpecificLoading = "Brand Specific Loading";

    /// <summary>Multi-brand loading type (Prime residential full doc I).</summary>
    public const string MultiBrandLoading = "Prime residential full doc I";
}
