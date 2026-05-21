namespace Bidirectional.DomainCore.Postcode.Constants;

/// <summary>
/// Look-up type names as stored in the core database (e.g. Residency_Type, Doc_Type).
/// Used to identify general look-up categories for drop downs and validation.
/// </summary>
public record GeneralLookUpTypesCoreDB
{
    /// <summary>High security type.</summary>
    public const string HighSecurityType = "HighSecurity_Type";

    /// <summary>PC category type".</summary>
    public const string PCCategoryType = "PCCategory_Type";

    /// <summary>Standard and poor type.</summary>
    public const string StandardAndPoorType = "Standard_And_Poor_Type";
}
