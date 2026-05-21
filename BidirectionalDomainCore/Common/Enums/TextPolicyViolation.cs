namespace Bidirectional.DomainCore.Common.Enums;

/// <summary>
/// Specifies the types of policy violations that can be detected in text fields throughout the application.
/// </summary>
public enum TextPolicyViolation
{
    /// <summary>
    /// The text is empty or contains only whitespace.
    /// </summary>
    EmptyOrWhitespace,

    /// <summary>
    /// The text exceeds the maximum allowed length.
    /// </summary>
    ExceedsMaxLength,

    /// <summary>
    /// The text contains Unicode characters that are not allowed.
    /// </summary>
    UnicodeNotAllowed,

    /// <summary>
    /// The text contains characters that are deemed invalid by policy.
    /// </summary>
    InvalidCharacters,

    /// <summary>
    /// The text contains content considered dangerous (e.g., scripts or patterns that pose security risks).
    /// </summary>
    DangerousContent,

    /// <summary>
    /// The text matches patterns associated with SQL injection or similar risks.
    /// </summary>
    SqlPatternViolation,

    /// <summary>
    /// The text is invalid JSON.
    /// </summary>
    InvalidJson,

    /// <summary>
    /// The text is invalid HTML.
    /// </summary>
    InvalidHtml,

    /// <summary>
    /// The text is invalid XML.
    /// </summary>
    InvalidXml,

    /// <summary>
    /// The text contains unacceptable or restricted content not otherwise classified.
    /// </summary>
    InvalidContent
}
