namespace Bidirectional.DomainCore.BidOnboard.Constants;

internal static class FolderNameGenerator
{
    public static string Generate(string organizationBUsinessUnitType, string? name, string? abn)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or empty.");
        }

        if (string.IsNullOrWhiteSpace(abn))
        {
            throw new ArgumentException("ABN cannot be null or empty.");
        }

        string cleanedName = RemoveSpecialCharacters(name);
        string pascalCaseName = ToPascalCase(cleanedName);

        if (string.IsNullOrWhiteSpace(pascalCaseName))
        {
            throw new InvalidOperationException("Failed to generate a valid folder name with Name: empty value.");
        }

        return $"{ConvertToPlural(organizationBUsinessUnitType)}/{pascalCaseName}_{abn}";
    }

    public static string GenerateUserFolder(string? firstName, string? lastName, DateOnly? dob)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException("First name is required.");
        }

        if (!dob.HasValue)
        {
            throw new ArgumentException("Date of birth is required.");
        }

        lastName ??= string.Empty;

        string cleanedFirstName = RemoveSpecialCharacters(firstName);
        string cleanedLastName = RemoveSpecialCharacters(lastName);

        string fullName = $"{cleanedFirstName.Trim()}{cleanedLastName.Trim()}";

        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new InvalidOperationException("Invalid name after sanitization.");
        }

        string dobString = dob.Value.ToString("yyyyMMdd");

        return $"{fullName}_{dobString}";
    }

    private static string ToPascalCase(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        return string.Concat(
            value.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(w => char.ToUpperInvariant(w[0]) +
                              w.Substring(1).ToLowerInvariant()));
    }

    private static string RemoveSpecialCharacters(string value)
    {
        // keep letters only
        return new string(value.Where(char.IsLetter).ToArray());
    }

    private static string ConvertToPlural(string type)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            throw new ArgumentException("Type cannot be null or empty.");
        }

        if (string.Equals(type, DomainBusinessUnitTypes.Branch.ToString(), StringComparison.OrdinalIgnoreCase))
        {
            return "branches";
        }

        return char.ToLowerInvariant(type[0]) + type.Substring(1) + "s";
    }
}
