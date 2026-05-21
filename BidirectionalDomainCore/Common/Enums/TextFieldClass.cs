namespace Bidirectional.DomainCore.Common.Enums;

/// <summary>
/// Defines classifications for text field contents within the application to guide validation, handling, storage, or security.
/// </summary>
public enum TextFieldClass
{
    /// <summary>
    /// Represents fields that contain system-controlled or strictly validated identifiers.
    /// </summary>
    ControlledIdentifier,

    /// <summary>
    /// Represents fields intended for storing URLs.
    /// </summary>
    Url,

    /// <summary>
    /// Represents fields designed for user-supplied narrative, such as large, unstructured text.
    /// </summary>
    FreeTextNarrative,

    /// <summary>
    /// Represents fields meant for user or system comments or notes.
    /// </summary>
    Comment,

    /// <summary>
    /// Represents fields that store encrypted textual information.
    /// </summary>
    EncryptedText,

    /// <summary>
    /// Represents text imported from external systems or files.
    /// </summary>
    ImportedText,

    /// <summary>
    /// Represents fields containing JSON-formatted text payloads.
    /// </summary>
    JsonPayload,

    /// <summary>
    /// Represents fields containing XML-formatted text payloads.
    /// </summary>
    XMLPayload,

    /// <summary>
    /// Represents fields for HTML content. Requires sanitisation due to XSS risks.
    /// </summary>
    HtmlContent,

    /// <summary>
    /// Represents text fields that must only contain ASCII characters as per policy.
    /// </summary>
    AsciiPolicy,

    /// <summary>
    /// Represents text fields that only allow Unicode letters and separator characters as defined by policy.
    /// </summary>
    UnicodeLettersWithSeparatorsPolicy,

    /// <summary>
    /// Represents address input fields with address-specific character and format allowances.
    /// </summary>
    AddressAllowed,

    /// <summary>
    /// Represents fields that are intentionally ignored in processing.
    /// </summary>
    Ignored,

    /// <summary>
    /// Represents tokens for row-level policy columns, including dotted property paths, underscores, and claim prefixes (e.g., Claim:RawCompanyID).
    /// </summary>
    EntityAccessPolicyToken,

    /// <summary>
    /// A field containing a formula expression (calculator module).
    /// </summary>
    FormulaExpression,
}
