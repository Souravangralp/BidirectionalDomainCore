namespace Bidirectional.DomainCore.ProductMatrix.Enums;

/// <summary>
/// Specifies filters for referral actions to others based on employment criteria.
/// </summary>
public enum ReferredToOtherFilter
{
    /// <summary>
    /// Filter to refer individuals who are self-employed.
    /// </summary>
    SelfEmployed = 1,

    /// <summary>
    /// Filter based on general employment status.
    /// </summary>
    EmploymentStatus = 2
}
