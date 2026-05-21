namespace Bidirectional.DomainCore.BidOnboard.Enums;

/// <summary>
/// Represents the scope level at which a document applies.
/// </summary>
public enum DocumentScopeType
{
    /// <summary>
    /// Document specific to an individual user (e.g., ID, resume).
    /// </summary>
    User = 0,

    /// <summary>
    /// Document specific to a business unit or branch (e.g., branch license).
    /// </summary>
    BusinessUnit = 1,

    /// <summary>
    /// Document that applies organization-wide (e.g., insurance, company policies).
    /// </summary>
    Organization = 2
}
