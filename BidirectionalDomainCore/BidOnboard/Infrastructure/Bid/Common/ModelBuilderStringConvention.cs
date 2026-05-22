using Ganss.Xss;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common;

/// <summary>
/// Provides extension methods for evaluating and enforcing text policies on string properties.
/// </summary>
public static class TextPolicyExtensions
{
    /// <summary>
    /// Determines whether the specified value satisfies the provided text policy, considering property metadata and text field class.
    /// </summary>
    /// <param name="policy">The text policy to validate against.</param>
    /// <param name="property">The property information for the value, or null if unavailable.</param>
    /// <param name="value">The value to validate.</param>
    /// <param name="textClass">The classification of the text field.</param>
    /// <param name="violation">The specific policy violation encountered if validation fails.</param>
    /// <returns>True if the value satisfies the policy; otherwise, false.</returns>
    public static bool IsSatisfiedBy(this TextPolicy policy, PropertyInfo? property, string? value, TextFieldClass textClass, out TextPolicyViolation? violation)
    {
        violation = TextPolicyViolation.InvalidContent;

        if (value == null || textClass == TextFieldClass.Ignored)
            return true;

        if (string.IsNullOrWhiteSpace(value))
        {
            violation = TextPolicyViolation.EmptyOrWhitespace;
            return false;
        }

        if (property != null && property.IsDefined(typeof(EncryptColumnAttribute), false))
            return true;

        //if (property!.IsDefined(typeof(EncryptColumnAttribute), false))
        //    return true;

        if (textClass != TextFieldClass.HtmlContent &&
            ModelBuilderStringConvention.ContainsDangerousContent(value))
        {
            violation = TextPolicyViolation.DangerousContent;
            return false;
        }

        if (property?.Name != null)
        {
            bool isOverRide = ModelBuilderStringConvention.TryGetOverride(property.Name, out TextPolicy overRidePolicy);

            if (isOverRide)
            {
                if (value.Length > policy.MaxLength)
                {
                    violation = TextPolicyViolation.ExceedsMaxLength;
                    return false;
                }

                if (!overRidePolicy.Unicode && value.Any(c => c > 127))
                {
                    violation = TextPolicyViolation.UnicodeNotAllowed;
                    return false;
                }
                if (!string.IsNullOrEmpty(policy.SqlLikeExclusion) && textClass != TextFieldClass.JsonPayload && textClass != TextFieldClass.HtmlContent && textClass != TextFieldClass.XMLPayload)
                {
                    if (property.Name.Equals(nameof(BaseAuditableEntity.UniqueID), StringComparison.OrdinalIgnoreCase))
                        return value.Length == 36 && Guid.TryParse(value, out _);

                    string regex = AsciiPolicy.GetRegexPolicy(
                        overRidePolicy.ValidationName,
                        overRidePolicy.SqlLikeExclusion!);

                    if (Regex.IsMatch(value, regex))
                    {
                        violation = TextPolicyViolation.InvalidCharacters;
                        return false;
                    }
                }

                return true;
            }
        }

        if (value.Length > policy.MaxLength)
        {
            violation = TextPolicyViolation.ExceedsMaxLength;
            return false;
        }

        if (textClass == TextFieldClass.FreeTextNarrative && (!NameWhitelistRegex.IsMatch(value)))
        {
            violation = TextPolicyViolation.InvalidCharacters;
            return false;
        }

        if (!policy.Unicode && value.Any(c => c > 127))
        {
            violation = TextPolicyViolation.UnicodeNotAllowed;
            return false;
        }

        if (!string.IsNullOrEmpty(policy.SqlLikeExclusion) && textClass != TextFieldClass.JsonPayload && textClass != TextFieldClass.HtmlContent && textClass != TextFieldClass.XMLPayload)
        {
            string regexPattern = AsciiPolicy.GetRegexPolicy(
                policy.ValidationName,
                policy.SqlLikeExclusion);
            if (Regex.IsMatch(value, regexPattern))
            {
                violation = TextPolicyViolation.InvalidCharacters;
                return false;
            }
        }

        return textClass switch
        {
            TextFieldClass.JsonPayload => IsValidJson(value)
                ? true : Fail(TextPolicyViolation.InvalidJson, out violation),

            TextFieldClass.HtmlContent => IsSafeHtml(value)
                ? true : Fail(TextPolicyViolation.InvalidHtml, out violation),

            TextFieldClass.XMLPayload => IsValidXml(value)
                ? true : Fail(TextPolicyViolation.InvalidXml, out violation),

            _ => true
        };
    }

    /// <summary>
    /// Marks a validation as failed with the specified reason and sets the violation out parameter.
    /// </summary>
    /// <param name="reason">The reason for the policy violation.</param>
    /// <param name="violation">The out parameter to set the violation.</param>
    /// <returns>Always returns false to indicate validation failure.</returns>
    private static bool Fail(TextPolicyViolation reason, out TextPolicyViolation? violation)
    {
        violation = reason;
        return false;
    }

    /// <summary>
    /// Gets a reusable HTML sanitizer instance configured with allowed formatting tags.
    /// </summary>
    private static readonly HtmlSanitizer Sanitizer = CreateSanitizer();

    /// <summary>
    /// Regex to whitelist allowed characters in free-text narrative fields.
    /// </summary>
    private static readonly Regex NameWhitelistRegex = new Regex(@"^[A-Za-z0-9 .,\'\-\?]*$", RegexOptions.Compiled);
    private static readonly Regex PlainTextRegex = new Regex(@"^[A-Za-z0-9 .,!?@#%&()*\-_'"";:]*$");
    /// <summary>
    /// Creates a configured <see cref="HtmlSanitizer"/> that restricts formatting to a safe set of tags.
    /// </summary>
    /// <returns>A configured <see cref="HtmlSanitizer"/> instance for validation.</returns>
    private static HtmlSanitizer CreateSanitizer()
    {
        HtmlSanitizer sanitizer = new HtmlSanitizer();

        // OPTIONAL — restrict formatting strictly
        sanitizer.AllowedTags.Clear();
        sanitizer.AllowedTags.Add("p");
        sanitizer.AllowedTags.Add("b");
        sanitizer.AllowedTags.Add("i");
        sanitizer.AllowedTags.Add("ul");
        sanitizer.AllowedTags.Add("li");
        sanitizer.AllowedTags.Add("br");

        sanitizer.AllowedAttributes.Clear(); // safest default

        return sanitizer;
    }

    /// <summary>
    /// Determines whether the given JSON string is valid.
    /// </summary>
    /// <param name="json">The JSON string to check.</param>
    /// <returns>True if the string is valid JSON; otherwise, false.</returns>
    private static bool IsValidJson(string json)
    {
        try
        {
            using JsonDocument doc = JsonDocument.Parse(json);
            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Regex pattern for detecting malicious JavaScript and HTML content.
    /// </summary>
    private static readonly Regex MaliciousPattern = new Regex(
    @"(<\s*script|on\w+\s*=|javascript\s*:|data\s*:|<\s*iframe|<\s*svg)",
    RegexOptions.IgnoreCase | RegexOptions.Compiled
);

    /// <summary>
    /// Determines whether the input string contains patterns that indicate malicious intent.
    /// </summary>
    /// <param name="input">The input string to check.</param>
    /// <returns>True if malicious intent is detected; otherwise, false.</returns>
    private static bool ContainsMaliciousIntent(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        return MaliciousPattern.IsMatch(input);
    }

    /// <summary>
    /// Validates if input HTML is safe and does not contain unwanted content or tags.
    /// </summary>
    /// <param name="input">The HTML input to validate.</param>
    /// <returns>True if the HTML is safe; otherwise, false.</returns>
    public static bool IsSafeHtml(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return true;

        if (ContainsMaliciousIntent(input))
            return false;

        string sanitized = Sanitizer.Sanitize(input);

        string normalizedInput = WebUtility.HtmlDecode(input);
        string normalizedSanitized = WebUtility.HtmlDecode(sanitized);

        return string.Equals(normalizedInput, normalizedSanitized, StringComparison.Ordinal);
    }

    /// <summary>
    /// Determines whether the given XML string is valid.
    /// </summary>
    /// <param name="xml">The XML string to check.</param>
    /// <returns>True if the string is valid XML; otherwise, false.</returns>
    private static bool IsValidXml(string xml)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return true;
        }
        catch
        {
            return false;
        }
    }
}

/// <summary>
/// Provides utilities and conventions for validating, enforcing, and inferring text policies for database string columns.
/// </summary>
public static class ModelBuilderStringConvention
{
    #region TextPolicy definition

    /// <summary>
    /// Gets the default text policies mapped to each <see cref="TextFieldClass"/>.
    /// </summary>
    public static readonly Dictionary<TextFieldClass, TextPolicy> Policies = new()
    {
        [TextFieldClass.ControlledIdentifier] = new(50, false, AsciiPolicy.CodeSql.Key, nameof(AsciiPolicy.CodeSql)),

        [TextFieldClass.FreeTextNarrative] = new(255, false, AsciiPolicy.ControlCharsSql.Key, nameof(AsciiPolicy.ControlCharsSql)),

        [TextFieldClass.Url] = new(500, false, AsciiPolicy.UrlSql.Key, nameof(AsciiPolicy.UrlSql)),

        [TextFieldClass.Comment] = new(1000, false, AsciiPolicy.ControlCommentSql.Key, nameof(AsciiPolicy.ControlCommentSql)),

        [TextFieldClass.EncryptedText] = new(2048, false, AsciiPolicy.Base64Sql.Key, nameof(AsciiPolicy.Base64Sql)),

        [TextFieldClass.ImportedText] = new(2000, true, AsciiPolicy.ControlCharsSql.Key, nameof(AsciiPolicy.ControlCommentSql)),

        [TextFieldClass.JsonPayload] = new(4000, true, AsciiPolicy.JsonPayloadSql.Key, nameof(AsciiPolicy.JsonPayloadSql)),

        [TextFieldClass.HtmlContent] = new(4000, true, AsciiPolicy.HTMLSql.Key, nameof(AsciiPolicy.HTMLSql)),

        [TextFieldClass.XMLPayload] = new(4000, true, AsciiPolicy.XMLPayloadSql.Key, nameof(AsciiPolicy.XMLPayloadSql)),

        [TextFieldClass.AddressAllowed] = new(500, true, AsciiPolicy.AddressSql.Key, nameof(AsciiPolicy.AddressSql)),

        [TextFieldClass.AsciiPolicy] = new(255, true, AsciiPolicy.AsciiOnlySql.Key, nameof(AsciiPolicy.AsciiOnlySql)),

        [TextFieldClass.Ignored] = new(255, true, AsciiPolicy.IgnoreSql.Key, nameof(AsciiPolicy.IgnoreSql)),

        [TextFieldClass.EntityAccessPolicyToken] = new(255, false, AsciiPolicy.EntityAccessPolicyTokenSql.Key, nameof(AsciiPolicy.EntityAccessPolicyTokenSql)),

        [TextFieldClass.FormulaExpression] = new(300, true, AsciiPolicy.FormulaSql.Key, nameof(AsciiPolicy.FormulaSql)),

        [TextFieldClass.UnicodeLettersWithSeparatorsPolicy] = new(255, true, AsciiPolicy.UnicodeLettersWithSeparatorsSql.Key, nameof(AsciiPolicy.UnicodeLettersWithSeparatorsSql)),
    };

    /// <summary>
    /// Gets the column-specific overrides for text policies, mapped by column name patterns.
    /// </summary>
    private static readonly Dictionary<string, TextPolicy> ColumnOverrides =
    new(StringComparer.OrdinalIgnoreCase)
    {
        ["*Email*"] = new(254, false, AsciiPolicy.EmailSql.Key, nameof(AsciiPolicy.EmailSql)),
        ["*Phone*"] = new(20, false, AsciiPolicy.PhoneSql.Key, nameof(AsciiPolicy.PhoneSql)),
        ["*Mobile*"] = new(20, false, AsciiPolicy.PhoneSql.Key, nameof(AsciiPolicy.PhoneSql)),

        ["*CountryCode*"] = new(20, false, AsciiPolicy.PhoneSql.Key, nameof(AsciiPolicy.PhoneSql)),

        ["*CurrencySymbol*"] = new(10, false, AsciiPolicy.CurrencySymbolSql.Key, nameof(AsciiPolicy.CurrencySymbolSql)),

        ["*FileFormat*"] = new(255, false, AsciiPolicy.FileFormatSql.Key, nameof(AsciiPolicy.FileFormatSql)),

        ["*BookingBusinessID*"] = new(255, false, AsciiPolicy.EmailSql.Key, nameof(AsciiPolicy.EmailSql)),
        ["*Website*"] = new(255, false, AsciiPolicy.UrlSql.Key, nameof(AsciiPolicy.UrlSql)),

        ["*Pan"] = new(20, false, AsciiPolicy.CodeSql.Key, nameof(AsciiPolicy.CodeSql)),
        ["*Ssn"] = new(20, false, AsciiPolicy.SSnSql.Key, nameof(AsciiPolicy.SSnSql)),
        ["*TaxId*"] = new(20, false, AsciiPolicy.CodeSql.Key, nameof(AsciiPolicy.CodeSql)),

        [nameof(BaseAuditableEntity.UniqueID)] = new(255, false, AsciiPolicy.UniqueIDSqlConstraint.Key, nameof(AsciiPolicy.UniqueIDSqlConstraint)),
        [nameof(BaseAuditableEntity.CreatedBy)] = new(255, false, AsciiPolicy.UniqueIDSqlConstraint.Key, nameof(AsciiPolicy.UniqueIDSqlConstraint)),
        [nameof(BaseAuditableEntity.LastModifiedBy)] = new(255, false, AsciiPolicy.UniqueIDSqlConstraint.Key, nameof(AsciiPolicy.UniqueIDSqlConstraint)),

        ["*Date*"] = new(50, false, AsciiPolicy.DateSql.Key, nameof(AsciiPolicy.DateSql)),

        //["*Amount*"] = new(MaxLength: 30, Unicode: false, SqlLikeExclusion: "%[^0-9.,-]%"),
        //["*Price*"] = new(MaxLength: 30, Unicode: false, SqlLikeExclusion: "%[^0-9.,-]%"), 
        //["*Balance*"] = new(MaxLength: 30, Unicode: false, SqlLikeExclusion: "%[^0-9.,-]%"),

        ["*Description*"] = new(1000, true, AsciiPolicy.ControlCommentSql.Key, nameof(AsciiPolicy.ControlCommentSql)),
        ["*Remark*"] = new(1000, true, AsciiPolicy.ControlCharsSql.Key, nameof(AsciiPolicy.ControlCharsSql)),
        ["*Comments*"] = new(1000, true, AsciiPolicy.ControlCommentSql.Key, nameof(AsciiPolicy.ControlCommentSql)),
        ["*FullAddress*"] = new(500, true, AsciiPolicy.AddressSql.Key, nameof(AsciiPolicy.AddressSql)),
        ["*InternalNotes*"] = new(2000, true, AsciiPolicy.ControlCharsSql.Key, nameof(AsciiPolicy.ControlCharsSql))
    };

    #endregion

    #region Public API

    /// <summary>
    /// Applies string policies to all string properties in the model using conventions based on property names and attributes.
    /// </summary>
    /// <param name="modelBuilder">The EF model builder for which to apply string policies.</param>
    public static void ApplyStringPolicies(this ModelBuilder modelBuilder)
    {
        foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
        {
            string? table = entity.GetTableName();
            if (table == null) continue;

            StoreObjectIdentifier tableId = StoreObjectIdentifier.Table(table, null);

            foreach (IMutableProperty property in entity.GetProperties())
            {
                if (property.ClrType != typeof(string)) continue;

                TextPolicy policy = ResolveTextPolicy(property);
                TextFieldClass textClass = property.PropertyInfo?.GetCustomAttribute<TextClassAttribute>()?.Class
                                ?? InferTextClassByName(property.Name);

                ApplyPolicy(entity, property, tableId, policy, textClass);
            }
        }
    }

    /// <summary>
    /// Validates that no Unicode string property is set to nvarchar(max) (i.e., does not have a defined max length).
    /// </summary>
    /// <param name="modelBuilder">The EF model builder to validate.</param>
    /// <exception cref="InvalidOperationException">Thrown if a Unicode string property is missing a maximum length.</exception>
    public static void ValidateNoNVarCharMax(this ModelBuilder modelBuilder)
    {
        List<IMutableProperty> violations = modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetProperties())
            .Where(p =>
                p.ClrType == typeof(string) &&
                p.IsUnicode() == true &&
                p.GetMaxLength() == null)
            .ToList();

        if (violations.Any())
        {
            string msg = string.Join(", ",
                violations.Select(v => $"{v.DeclaringType.Name}.{v.Name}"));

            throw new InvalidOperationException(
                $"Unicode string without max length detected: {msg}");
        }
    }

    #endregion

    #region Enforcement

    /// <summary>
    /// Applies the text policy to the specified property, setting column configuration and appropriate SQL constraints.
    /// </summary>
    /// <param name="entity">The entity type containing the property.</param>
    /// <param name="property">The property to apply the policy to.</param>
    /// <param name="tableId">The store object identifier for the containing table.</param>
    /// <param name="policy">The text policy to enforce.</param>
    /// <param name="textClass">The text field class of the property.</param>
    private static void ApplyPolicy(
        IMutableEntityType entity,
        IMutableProperty property,
        StoreObjectIdentifier tableId,
        TextPolicy policy,
        TextFieldClass textClass)
    {
        string? column = property.GetColumnName(tableId);

        if (property.GetMaxLength() == null)
        {
            property.SetMaxLength(policy.MaxLength);
        }

        property.SetIsUnicode(policy.Unicode);

        // Hard-map SQL type
        //property.SetColumnType(
        //    policy.Unicode
        //        ? $"nvarchar({policy.MaxLength})"
        //        : $"varchar({policy.MaxLength})");              
        property.SetColumnType($"nvarchar({policy.MaxLength})");

        if (string.IsNullOrEmpty(column))
            return;

        // Character exclusion
        string constraintName = string.Empty;
        string comment = string.Empty;

        if (AsciiPolicy.ValidationComments.TryGetValue(policy.ValidationName!, out string? value))
        {
            comment = value;
        }
        if (!string.IsNullOrEmpty(policy.SqlLikeExclusion) &&
            textClass != TextFieldClass.JsonPayload &&
            textClass != TextFieldClass.XMLPayload &&
            textClass != TextFieldClass.HtmlContent)
        {
            string check = string.Format(policy.SqlLikeExclusion, column);

            if (property.IsNullable)
                check = $"[{column}] IS NULL OR ({check})";

            constraintName = $"CK_{entity.GetTableName()}_{column}_CHARSET";

            AddCheck(entity, constraintName, check, comment);
        }

        //if (!string.IsNullOrEmpty(policy.SqlLikeExclusion))
        //    AddCheck(entity, column, "CHARSET", string.Format(policy.SqlLikeExclusion, column));
        //        //$"[{column}] NOT LIKE '{policy.SqlLikeExclusion}' [{column}]) = 0");

        // SQL-level structure validation
        if (textClass == TextFieldClass.JsonPayload)
        {
            string check = string.Format(AsciiPolicy.JsonPayloadSql.Key, column);
            constraintName = $"CK_{entity.GetTableName()}_{column}_JSON";
            AddCheck(entity, constraintName, check, comment);
        }

        else if (textClass == TextFieldClass.XMLPayload)
        {
            string check = string.Format(AsciiPolicy.XMLPayloadSql.Key, column);
            constraintName = $"CK_{entity.GetTableName()}_{column}_XML";
            AddCheck(entity, constraintName, check, comment);
        }

        else if (textClass == TextFieldClass.HtmlContent)
        {
            string check = string.Format(AsciiPolicy.HTMLSql.Key, column);
            constraintName = $"CK_{entity.GetTableName()}_{column}_HTML";
            AddCheck(entity, constraintName, check, comment);
        }
    }

    /// <summary>
    /// Adds a SQL check constraint to the entity for the specified column and description.
    /// </summary>
    /// <param name="entity">The entity type to which the check constraint is added.</param>
    /// <param name="constraintName">The name of the constraint.</param>
    /// <param name="sql">The SQL expression for the check.</param>
    /// <param name="comment">A description/comment for the constraint.</param>
    private static void AddCheck(
       IMutableEntityType entity,
       string constraintName,
       string sql, string comment)
    {
        if (entity.GetCheckConstraints().Any(c => c.Name == constraintName))
            return;

        entity.AddCheckConstraint(
        $"{constraintName}",
        sql).AddAnnotation($"Comment_{constraintName}", comment);
    }

    #endregion

    #region Policy resolution

    /// <summary>
    /// Regex for extracting LIKE clauses from PATINDEX expressions in SQL policy definitions.
    /// </summary>
    private static readonly Regex PatIndexLikeExtractor =
   new Regex(
       @"PATINDEX\s*\(\s*N?'(?<like>%\[\^.*?\]%)'",
       RegexOptions.IgnoreCase | RegexOptions.Compiled);

    /// <summary>
    /// Converts a PATINDEX-style SQL expression to an equivalent regular expression pattern.
    /// </summary>
    /// <param name="sqlExpression">The SQL expression to convert.</param>
    /// <returns>The equivalent regex pattern string.</returns>
    /// <exception cref="InvalidOperationException">Thrown if unable to extract the pattern from the SQL expression.</exception>
    public static string SqlLikeToRegexs(string sqlExpression)
    {
        Match match = PatIndexLikeExtractor.Match(sqlExpression);
        if (!match.Success)
            throw new InvalidOperationException(
                $"Unsupported SQL policy format: {sqlExpression}");

        string like = match.Groups["like"].Value;

        if (like.Contains("[^]"))
        {
            like = "a^";
        }

        string regex =
            Regex.Escape(like)
                         .Replace("%", ".*")
                         .Replace("_", ".")
                         .Replace(@"\[\^", "[^")
                         .Replace(@"\]", "]");

        return @"[\r\n]| {2,}|^(?:" + regex + @")$";
    }

    /// <summary>
    /// Converts a standard SQL LIKE pattern to a corresponding regex pattern.
    /// </summary>
    /// <param name="sqlLikePattern">The SQL LIKE pattern string.</param>
    /// <returns>A regex pattern representing the LIKE condition.</returns>
    public static string SqlLikeToRegex(string sqlLikePattern)
    {
        // simple translation: % -> .*, [^...] -> [^...]
        string pattern = Regex.Escape(sqlLikePattern)
                           .Replace("%", ".*")
                           .Replace(@"\[\^", "[^")
                           .Replace(@"\[\^", "[^")
                           .Replace(@"\]", "]");
        return "^" + pattern + "$";
    }

    /// <summary>
    /// Regex for detecting SQL keywords that could indicate SQL injection danger.
    /// </summary>
    private static readonly Regex SqlKeywordRegex = new(
    @"\b(drop|alter|delete|update|insert|truncate|merge|exec|execute)\b",
    RegexOptions.IgnoreCase | RegexOptions.Compiled);

    /// <summary>
    /// Regex for detecting SQL meta-characters or comments.
    /// </summary>
    private static readonly Regex SqlMetaRegex = new(
        @"(--|/\*|\*/|@@)",
        RegexOptions.Compiled);

    /// <summary>
    /// Regex for detecting HTML tags in a string.
    /// </summary>
    private static readonly Regex HtmlTagRegex = new(
        @"<[^>]+>",
        RegexOptions.Compiled);

    /// <summary>
    /// Determines whether the given value contains possibly dangerous SQL or HTML content.
    /// </summary>
    /// <param name="value">The string value to inspect.</param>
    /// <returns>True if dangerous content is detected; otherwise, false.</returns>
    public static bool ContainsDangerousContent(string value)
    {
        return
            SqlKeywordRegex.IsMatch(value) ||
            SqlMetaRegex.IsMatch(value) ||
            HtmlTagRegex.IsMatch(value);
    }

    /// <summary>
    /// Attempts to find a text policy override based on the property name pattern.
    /// </summary>
    /// <param name="propertyName">The property name to check for overrides.</param>
    /// <param name="overRidePolicy">The overriding text policy if found.</param>
    /// <returns>True if an override is found; otherwise, false.</returns>
    public static bool TryGetOverride(string propertyName, out TextPolicy overRidePolicy)
    {
        foreach (KeyValuePair<string, TextPolicy> kvp in ColumnOverrides)
        {
            if (IsLike(propertyName, kvp.Key))
            {
                overRidePolicy = kvp.Value;
                return true;
            }
        }

        overRidePolicy = default!;
        return false;
    }

    /// <summary>
    /// Determines whether the given input string matches the wildcard pattern.
    /// </summary>
    /// <param name="input">The input string to match.</param>
    /// <param name="pattern">The wildcard pattern (using '*' as wildcard characters).</param>
    /// <returns>True if the input matches the pattern; otherwise, false.</returns>
    private static bool IsLike(string input, string pattern)
    {
        // *Description*  => contains
        // Description*   => starts with
        // *Description   => ends with
        return pattern switch
        {
            var p when p.StartsWith("*") && p.EndsWith("*")
                => input.Contains(p.Trim('*'), StringComparison.OrdinalIgnoreCase),

            var p when p.StartsWith("*")
                => input.EndsWith(p.Trim('*'), StringComparison.OrdinalIgnoreCase),

            var p when p.EndsWith("*")
                => input.StartsWith(p.Trim('*'), StringComparison.OrdinalIgnoreCase),

            _ => input.Equals(pattern, StringComparison.OrdinalIgnoreCase)
        };
    }

    /// <summary>
    /// Resolves the effective text policy for a property described by <see cref="IProperty"/>.
    /// </summary>
    /// <param name="property">The property metadata to resolve the policy for.</param>
    /// <returns>The resolved <see cref="TextPolicy"/> for the property.</returns>
    /// <exception cref="InvalidOperationException">Thrown if required information or policy is missing.</exception>
    public static TextPolicy ResolveTextPolicy(IProperty property)
    {
        if (property.PropertyInfo == null)
            throw new InvalidOperationException(
                $"PropertyInfo missing for {property.Name}");

        return ResolveTextPolicy(property.PropertyInfo, property.Name);
    }

    /// <summary>
    /// Resolves the effective text policy for a property described by <see cref="IMutableProperty"/>.
    /// </summary>
    /// <param name="property">The property metadata to resolve the policy for.</param>
    /// <returns>The resolved <see cref="TextPolicy"/> for the property.</returns>
    /// <exception cref="InvalidOperationException">Thrown if required information or policy is missing.</exception>
    public static TextPolicy ResolveTextPolicy(IMutableProperty property)
    {
        if (property.PropertyInfo == null)
            throw new InvalidOperationException(
                $"PropertyInfo missing for {property.Name}");

        return ResolveTextPolicy(property.PropertyInfo, property.Name);
    }

    /// <summary>
    /// Resolves the effective text policy for a property using reflection information and its name.
    /// </summary>
    /// <param name="propertyInfo">Reflection metadata for the target property.</param>
    /// <param name="propertyName">The property's name.</param>
    /// <returns>The resolved <see cref="TextPolicy"/> for the property.</returns>
    /// <exception cref="InvalidOperationException">Thrown if a required policy is missing.</exception>
    public static TextPolicy ResolveTextPolicy(
    PropertyInfo propertyInfo,
    string propertyName)
    {
        if (propertyInfo.IsDefined(typeof(EncryptColumnAttribute), true))
        {
            if (!Policies.TryGetValue(TextFieldClass.EncryptedText, out TextPolicy? encPolicy))
                throw new InvalidOperationException(
                    "EncryptedText policy is not defined.");

            return encPolicy;
        }

        object[] attrs = propertyInfo.GetCustomAttributes(typeof(TextClassAttribute), true);
        TextClassAttribute? attr = attrs.FirstOrDefault() as TextClassAttribute;
        if (attr != null)
        {
            if (!Policies.TryGetValue(attr.Class, out TextPolicy? attrPolicy))
                throw new InvalidOperationException(
                    $"No TextPolicy defined for {attr.Class} on {propertyName}");

            return attrPolicy;
        }

        if (TryGetOverride(propertyName, out TextPolicy? colPolicy))
            return colPolicy;

        TextFieldClass inferred = InferTextClassByName(propertyName);

        if (!Policies.TryGetValue(inferred, out TextPolicy? inferredPolicy))
            throw new InvalidOperationException(
                $"No TextPolicy defined for inferred {inferred} on {propertyName}");

        return inferredPolicy;
    }

    /// <summary>
    /// Infers the <see cref="TextFieldClass"/> for a property based on typical naming conventions.
    /// </summary>
    /// <param name="name">The property name to analyze.</param>
    /// <returns>The inferred <see cref="TextFieldClass"/> based on the name.</returns>
    public static TextFieldClass InferTextClassByName(string name)
    {
        name = name.ToLowerInvariant();

        // 1️⃣ Structured payloads (strong signals)
        if (name.EndsWith("json") ||
            name.EndsWith("payload") ||
            name.Equals("requestdata") ||
            name.Equals("userrequest") ||
            name.Contains("metadata") ||
            name.Equals("ocrdetectedtext"))
            return TextFieldClass.JsonPayload;

        if (name.EndsWith("xml") ||
            name.Contains("xmlpayload"))
            return TextFieldClass.XMLPayload;

        // 2️⃣ URLs (strict)
        if (name.EndsWith("url") ||
            name.EndsWith("uri") ||
            name.Contains("callbackurl"))
            return TextFieldClass.Url;

        // 3️⃣ HTML (explicit only)
        if (name.Contains("html"))
            return TextFieldClass.HtmlContent;

        // 4️⃣ Identifiers / codes (tight)
        if (name.EndsWith("code") ||
            name.EndsWith("identifier") ||
            name.EndsWith("ref") || name.EndsWith("number") || name.Contains("reference") ||
            name.Contains("directorid"))
            return TextFieldClass.ControlledIdentifier;

        // 5️⃣ Human comments / notes
        if (name.Contains("note") ||
            name.Contains("comment") ||
            name.Contains("remark") ||
            name.Contains("message") ||
            name.Contains("history") ||
            name.Contains("text") ||
            name.Contains("explanation"))
            return TextFieldClass.Comment;

        if (name.Equals("creditlicenseauthorisations"))
            return TextFieldClass.ImportedText;

        // 6️⃣ Narrative text (default)
        return TextFieldClass.FreeTextNarrative;
    }

    //private static TextFieldClass InferTextClassByName(string name)
    //{
    //    name = name.ToLowerInvariant();

    //    if (name.Contains("url") || name.Contains("uri") || name.Contains("callback"))
    //        return TextFieldClass.Url;

    //    if (name.EndsWith("code") || name.EndsWith("number") || name.Contains("reference") || name.Contains("directorid"))
    //        return TextFieldClass.ControlledIdentifier;

    //    if (name.Contains("note") || name.Contains("comment") || name.Contains("explanation"))
    //        return TextFieldClass.Comment;

    //    if (name.EndsWith("json") || name.EndsWith("payload"))
    //        return TextFieldClass.JsonPayload;

    //    if (name.Contains("html") || name.Contains("content"))
    //        return TextFieldClass.HtmlContent;

    //    if (name.EndsWith("xml") || name.Contains("xmlpayload"))
    //        return TextFieldClass.XMLPayload;

    //    return TextFieldClass.FreeTextNarrative;
    //}

    #endregion
}

#region ASCII policy

/// <summary>
/// Defines static SQL patterns and comments for validating various ASCII-restricted and formatted string types.
/// </summary>
public static class AsciiPolicy
{
    //public const string EmailSql = "%[^A-Za-z0-9@._+-]%";
    //public static readonly string EmailSql = "PATINDEX('%[^A-Za-z0-9@._+-]%', [{0}]) = 0";
    /// <summary>
    /// SQL and regex policies for validating allowed email characters.
    /// </summary>
    public static readonly KeyValuePair<string, string> EmailSql = new(
        "PATINDEX(N'%[^A-Za-z0-9@._+-]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^A-Za-z0-9@._+\-].*)$");

    //public const string CodeSql =
    //    "%[^A-Za-z0-9 _-]%";

    //public const string CodeSql =
    //   "PATINDEX('%[^A-Za-z0-9 _-]%', [{0}]) = 0";
    /// <summary>
    /// SQL and regex policies for validating allowed code/identifier characters.
    /// </summary>
    public static readonly KeyValuePair<string, string> CodeSql = new(
        "PATINDEX(N'%[^A-Za-z0-9 _-]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^A-Za-z0-9 _\-].*)$");

    /// <summary>
    /// SQL and regex policies for allowed currency symbols and ASCII printable characters.
    /// </summary>
    public static readonly KeyValuePair<string, string> CurrencySymbolSql = new(
        "(PATINDEX(N'%[^ -~₹€£$¥₩₺₦₫฿₪₱₡₮₭]%',[{0}] COLLATE Latin1_General_BIN2) = 0)",
        @"[\r\n]| {2,}|^(?:.*[^ -~₹€£$¥₩₺₦₫฿₪₱₡₮₭].*)$");

    /// <summary>
    /// SQL and regex policies for allowed file format characters (lowercase, digits, dot, slash, plus, and hyphen).
    /// </summary>
    public static readonly KeyValuePair<string, string> FileFormatSql = new(
        "PATINDEX(N'%[^a-z0-9./+-]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^a-z0-9./+\-].*)$");

    //public const string SSnSql = "PATINDEX('%[^0-9-]%', [{0}]) = 0";
    /// <summary>
    /// SQL and regex policies for validating Social Security Number format.
    /// </summary>
    public static readonly KeyValuePair<string, string> SSnSql = new(
        "PATINDEX(N'%[^0-9-]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^0-9\-].*)$");

    //public const string DateSql = "PATINDEX('%[^0-9T:/ -]%', [{0}]) = 0";
    /// <summary>
    /// SQL and regex policies for validating date strings.
    /// </summary>
    public static readonly KeyValuePair<string, string> DateSql = new(
        "PATINDEX(N'%[^0-9T:/ -]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^0-9T:/ \-].*)$");

    //public const string PhoneSql = "PATINDEX('%[^0-9+ -]%', [{0}]) = 0";
    /// <summary>
    /// SQL and regex policies for validating phone number strings.
    /// </summary>
    public static readonly KeyValuePair<string, string> PhoneSql = new(
        "PATINDEX(N'%[^0-9+ -]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^0-9+ \-].*)$");

    //public const string ControlCharsSql =
    //"%[\x00-\x08\x0B\x0C\x0E-\x1F\x7F]%";

    //public static readonly string ControlCharsSql = "PATINDEX('%[^ -~]%', [{0}]) = 0";
    //public static readonly string ControlCharsSql = "PATINDEX(N'%[^ -~]%', [{0}] COLLATE Latin1_General_BIN2) = 0";
    /// <summary>
    /// SQL and regex policies for validating narrative/control text (restricting control/non-printable characters).
    /// </summary>
    public static readonly KeyValuePair<string, string> ControlCharsSql = new(
        "PATINDEX(N'%[^-A-Za-z0-9 .,''?]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^-A-Za-z0-9 .,'?].*)$");

    /// <summary>
    /// SQL and regex policies for entity access policy columns (dotted paths, underscores, claim prefixes such as Claim:RawCompanyID).
    /// </summary>
    public static readonly KeyValuePair<string, string> EntityAccessPolicyTokenSql = new(
        "PATINDEX(N'%[^A-Za-z0-9_ .,''?:-]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^A-Za-z0-9_ .,''?:\-].*)$");

    /// <summary>
    /// SQL and regex policies for validating address fields.
    /// </summary>
    public static readonly KeyValuePair<string, string> AddressSql = new(
    "PATINDEX(N'%[' + CHAR(0) + '-' + CHAR(31) + ']%', [{0}]) = 0",
    @"[\x00-\x1F]|\r|\n| {2,}");
    //public static readonly KeyValuePair<string, string> AddressSql = new(
    //    "PATINDEX(N'%[' + CHAR(0) + '-' + CHAR(31) + ']%', [{0}]) = 0",
    //    @"[\r\n]| {2,}|^(?:.*[^-A-Za-z0-9 .,'/?#&():;+@].*)$");

    /// <summary>
    /// SQL and regex policies for comment fields (restricting to safe printable characters).
    /// </summary>
    public static readonly KeyValuePair<string, string> ControlCommentSql = new(
        "PATINDEX(N'%[^-A-Za-z0-9 .,''?]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^-A-Za-z0-9 .,'?].*)$");

    /// <summary>
    /// SQL and regex policies for verifying GUID/UniqueID fields.
    /// </summary>
    public static readonly KeyValuePair<string, string> UniqueIDSqlConstraint = new(
        "(LEN([{0}]) = 36 AND TRY_CONVERT(uniqueidentifier, [{0}]) IS NOT NULL)",
        @"^(?![0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}$).+");

    //public static readonly string Base64Sql = "PATINDEX('%[^A-Za-z0-9+/=]%', [{0}]) = 0";

    /// <summary>
    /// SQL and regex policies for validating Base64-encoded strings.
    /// </summary>
    public static readonly KeyValuePair<string, string> Base64Sql = new(
        "PATINDEX(N'%[^A-Za-z0-9+/=]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^A-Za-z0-9+/=].*)$");

    public static readonly KeyValuePair<string, string> FormulaSql = new(
        "PATINDEX(N'%[^A-Za-z0-9_+*/().,<>= -]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]|^(?:.*[^A-Za-z0-9_+*/().,<>= \-].*)$");

    /// <summary>
    /// SQL and regex policies for place names (letters, separators, parentheses); blocks control characters only.
    /// Regex matches when invalid content is present (consistent with other <see cref="AsciiPolicy"/> pairs).
    /// </summary>
    public static readonly KeyValuePair<string, string> UnicodeLettersWithSeparatorsSql = new(
        "PATINDEX(N'%[' + CHAR(0) + '-' + CHAR(31) + ']%', [{0}]) = 0",
        @"[\x00-\x1F]|\r|\n");

    //public const string UrlSql =
    //    "%[^A-Za-z0-9:/?#\\[\\]@!$&'()*+,;=._~%-]%";

    //public const string UrlSql = "%[^A-Za-z0-9:/?#\\[\\]@!$&'()*+,;=._~%-]%";

    //public static readonly string UrlSql =
    //    "PATINDEX('%[^A-Za-z0-9:/?#\\[\\]@!$&''()*+,;=._~%-]%', [{0}]) = 0";

    /// <summary>
    /// SQL and regex policies for validating URL-safe characters.
    /// </summary>
    public static readonly KeyValuePair<string, string> UrlSql = new(
        "PATINDEX(N'%[^A-Za-z0-9:/?#\\[\\]@!$&''()*+,;=._~%-]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^A-Za-z0-9:/?#\[\]@!$&'()*+,;=._~%\-].*)$");

    /// <summary>
    /// SQL and regex policies for verifying valid JSON content.
    /// </summary>
    public static readonly KeyValuePair<string, string> JsonPayloadSql = new(
        "ISJSON([{0}]) = 1",
        @"(?!)");

    /// <summary>
    /// SQL and regex policies for verifying valid XML content.
    /// </summary>
    public static readonly KeyValuePair<string, string> XMLPayloadSql = new(
        "ISXML([{0}]) = 1",
        @"(?!)");

    /// <summary>
    /// SQL and regex policies for restricting to printable ASCII only.
    /// </summary>
    public static readonly KeyValuePair<string, string> AsciiOnlySql = new(
        "PATINDEX(N'%[^ -~]%', [{0}] COLLATE Latin1_General_BIN2) = 0",
        @"[\r\n]| {2,}|^(?:.*[^ -~].*)$");

    /// <summary>
    /// SQL and regex policies for ignoring validation (matches anything).
    /// </summary>
    public static readonly KeyValuePair<string, string> IgnoreSql = new(
        "PATINDEX(N'%[^]%', [{0}]) > 0",
        @"(?!)");

    /// <summary>
    /// SQL and regex policies for validating HTML content fields (restricting unsafe patterns).
    /// </summary>
    public static readonly KeyValuePair<string, string> HTMLSql = new(
        "[{0}] NOT LIKE '%<%' " +
        "AND [{0}] NOT LIKE '%>%' " +
        "AND [{0}] NOT LIKE '%script%' " +
        "AND [{0}] NOT LIKE '%javascript:%' " +
        "AND [{0}] NOT LIKE '%onerror=%' " +
        "AND [{0}] NOT LIKE '%onclick=%' " +
        "AND [{0}] NOT LIKE '%onload=%'",
        @"(?i)(<|>|script|javascript:|onerror=|onclick=|onload=)");

    /// <summary>
    /// Gets the mapping from SQL patterns to human-readable validation comments.
    /// </summary>
    public static readonly Dictionary<string, string> ValidationComments = new Dictionary<string, string>
    {
        { nameof(EmailSql), "Ensures the string contains only valid email characters: letters, digits, @, ., _, +, -" },
        { nameof(CodeSql), "Allows only letters, digits, spaces, underscores (_) and hyphens (-)" },
        { nameof(CurrencySymbolSql), "Validates currency symbols and printable ASCII characters including ₹, €, £, $, ¥, ₩, ₺, ₦, ₫, ฿, ₪, ₱, ₡, ₮, ₭" },
        { nameof(FileFormatSql), "Allows only lowercase letters, digits, and file-related characters: . / + -" },
        { nameof(SSnSql), "Allows only digits and hyphens, for Social Security Number formats" },
        { nameof(DateSql), "Validates date strings allowing digits, T, :, /, spaces, and hyphens" },
        { nameof(PhoneSql), "Allows digits, plus (+), spaces, and hyphens (-) for phone numbers" },
        { nameof(ControlCharsSql), "Restricts all non-printable/control characters; allows letters, digits, spaces, and punctuation (-A-Za-z0-9 .,''?)" },
        { nameof(EntityAccessPolicyTokenSql), "Allows letters, digits, spaces, underscore, dot, hyphen, colon, comma, apostrophe, and question mark for policy paths and claim sources" },
        { nameof(ControlCommentSql), "Same as ControlCharsSql; used for comment fields, allows letters, digits, spaces, and punctuation (-A-Za-z0-9 .,''?)" },
        { nameof(UniqueIDSqlConstraint), "Validates that the string is exactly 36 characters and a valid GUID/uniqueidentifier" },
        { nameof(Base64Sql), "Ensures the string contains only valid Base64 characters: A-Z, a-z, 0-9, +, /, =" },
        { nameof(UrlSql), "Allows only URL-safe characters: letters, digits, :, /, ?, #, [], @, !, $, &, ', (, ), *, +, ,, ;, =, ., _, ~, %, -" },
        { nameof(JsonPayloadSql), "Ensures the column contains valid JSON content" },
        { nameof(XMLPayloadSql), "Ensures the column contains valid XML content" },
        { nameof(HTMLSql), "Prevents HTML tags and unsafe script content in this column" },
        { nameof(AsciiOnlySql), "It is used when no rejex implemented" },
        { nameof(IgnoreSql), "It is used when no rejex implemented" },
        { nameof(FormulaSql), "Allows calculator formula characters: letters, digits, underscore, operators (+ - * /), parentheses, decimal/comma, comparisons (< > =), and spaces" },
        { nameof(UnicodeLettersWithSeparatorsSql), "Allows letters, digits, and common separators; blocks control characters only" },
    };

    /// <summary>
    /// Gets the mapping of validation keys to both SQL and regex policies for equivalent constraints.
    /// </summary>
    public static readonly Dictionary<string, KeyValuePair<string, string>> ValidationPolicyPairs = new()
    {
        { nameof(EmailSql), EmailSql },
        { nameof(CodeSql), CodeSql },
        { nameof(CurrencySymbolSql), CurrencySymbolSql },
        { nameof(FileFormatSql), FileFormatSql },
        { nameof(SSnSql), SSnSql },
        { nameof(DateSql), DateSql },
        { nameof(PhoneSql), PhoneSql },
        { nameof(ControlCharsSql), ControlCharsSql },
        { nameof(EntityAccessPolicyTokenSql), EntityAccessPolicyTokenSql },
        { nameof(AddressSql), AddressSql },
        { nameof(ControlCommentSql), ControlCommentSql },
        { nameof(UniqueIDSqlConstraint), UniqueIDSqlConstraint },
        { nameof(Base64Sql), Base64Sql },
        { nameof(UrlSql), UrlSql },
        { nameof(JsonPayloadSql), JsonPayloadSql },
        { nameof(XMLPayloadSql), XMLPayloadSql },
        { nameof(AsciiOnlySql), AsciiOnlySql },
        { nameof(IgnoreSql), IgnoreSql },
        { nameof(HTMLSql), HTMLSql },
        { nameof(FormulaSql), FormulaSql },
        { nameof(UnicodeLettersWithSeparatorsSql), UnicodeLettersWithSeparatorsSql }
    };

    /// <summary>
    /// Resolves the regex policy using the validation key when available; otherwise converts from SQL policy.
    /// </summary>
    /// <param name="validationName">The named validation policy key.</param>
    /// <param name="sqlPolicy">The SQL policy expression to fallback-convert when no key mapping exists.</param>
    /// <returns>The resolved regex pattern equivalent for validation.</returns>
    public static string GetRegexPolicy(string? validationName, string? sqlPolicy)
    {
        if (!string.IsNullOrWhiteSpace(validationName) &&
            ValidationPolicyPairs.TryGetValue(validationName, out KeyValuePair<string, string> policyPair))
        {
            return policyPair.Value;
        }

        if (string.IsNullOrWhiteSpace(sqlPolicy))
            return string.Empty;

        return ModelBuilderStringConvention.SqlLikeToRegexs(sqlPolicy);
    }
}

#endregion
