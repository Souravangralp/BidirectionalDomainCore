namespace Bidirectional.DomainCore.Postcode.Constants;

/// <summary>
/// Defines constant claim type names used throughout the application for user identity claims.
/// </summary>
public record CustomClaimTypes
{
    /// <summary>
    /// Represents the unique identifier for a business unit.
    /// </summary>
    public const string BusinessUnitID = "businessUnitID";

    /// <summary>
    /// Represents the name of the business unit.
    /// </summary>
    public const string BusinessUnitName = "businessUnitName";

    /// <summary>
    /// Represents the unique identifier for an organization.
    /// </summary>
    public const string OrganizationID = "organizationID";

    /// <summary>
    /// Represents the name of the organization.
    /// </summary>
    public const string OrganizationName = "organizationName";

    /// <summary>
    /// Represents the raw identifier for a branch, typically used for legacy or external systems.
    /// </summary>
    public const string RawBranchID = "rawBranchID";

    /// <summary>
    /// Represents the name of the branch.
    /// </summary>
    public const string BranchName = "branchName";

    /// <summary>
    /// Represents the raw identifier for a company, typically used for legacy or external systems.
    /// </summary>
    public const string RawCompanyID = "rawCompanyID";

    /// <summary>
    /// Represents the name of the company.
    /// </summary>
    public const string CompanyName = "companyName";

    /// <summary>
    /// Represents the unique identifier for a group.
    /// </summary>
    public const string GroupID = "groupID";

    /// <summary>
    /// Represents the unique identifier for a user.
    /// </summary>
    public const string UserID = "userID";

    /// <summary>
    /// Represents the raw identifier for a user, typically used for legacy or external systems.
    /// </summary>
    public const string RawUserID = "rawUserID";
}
