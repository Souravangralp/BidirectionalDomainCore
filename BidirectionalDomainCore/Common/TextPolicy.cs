namespace Bidirectional.DomainCore.Common;

/// <summary>
/// Defines a text validation policy: maximum length, Unicode allowance, SQL LIKE exclusion pattern, and validation name.
/// Used for consistent text rules across the domain (e.g. input validation and storage).
/// </summary>
public sealed record TextPolicy
{
    /// <summary>Gets the maximum allowed length for the text.</summary>
    public int MaxLength { get; }

    /// <summary>Gets a value indicating whether Unicode characters are allowed.</summary>
    public bool Unicode { get; }

    /// <summary>Gets the optional SQL LIKE pattern for characters to exclude, e.g. for sanitization.</summary>
    public string? SqlLikeExclusion { get; }

    /// <summary>Gets the optional name identifying this policy for validation messages.</summary>
    public string? ValidationName { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextPolicy"/> record.
    /// </summary>
    /// <param name="maxLength">Maximum allowed length.</param>
    /// <param name="unicode">Whether Unicode is allowed.</param>
    /// <param name="sqlLikeExclusion">Optional SQL LIKE exclusion pattern.</param>
    /// <param name="validationName">Optional validation name.</param>
    public TextPolicy(int maxLength, bool unicode, string? sqlLikeExclusion, string? validationName)
    {
        MaxLength = maxLength;
        Unicode = unicode;
        SqlLikeExclusion = sqlLikeExclusion;
        ValidationName = validationName;
    }
}
