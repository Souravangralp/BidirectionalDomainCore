namespace Bidirectional.DomainCore.Common.Enums;

/// <summary>
/// Specifies the distinct section names used in the application.
/// </summary>
public enum SectionName
{
    /// <summary>
    /// Represents the Core Product Setting section.
    /// </summary>
    CoreProductSetting = 1,
}

/// <summary>
/// Provides helper methods for working with the <see cref="SectionName"/> enum.
/// </summary>
public static class SectionNameHelper
{
    /// <summary>
    /// Attempts to retrieve the <see cref="SectionName"/> enum value that matches the given name.
    /// </summary>
    /// <param name="name">The name of the enum value to parse.</param>
    /// <returns>
    /// The corresponding <see cref="SectionName"/> value if parsing succeeds; otherwise, <c>null</c>.
    /// </returns>
    public static SectionName? GetEnumFromName(string name)
    {
        return Enum.TryParse<SectionName>(name, true, out SectionName result) ? result : null;
    }

    /// <summary>
    /// Gets the string representation of the <see cref="SectionName"/> enum value that matches the given name.
    /// </summary>
    /// <param name="name">The name of the enum value.</param>
    /// <returns>
    /// The string representation of the matching <see cref="SectionName"/> value, or an empty string if no match is found.
    /// </returns>
    public static string GetEnumDescription(string name)
    {
        SectionName? enumValue = GetEnumFromName(name);
        return enumValue?.ToString() ?? string.Empty;
    }
}
