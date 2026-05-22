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
    /// Represents the raw identifier for a business unit.
    /// </summary>
    public const string RawBusinessUnitID = "rawBusinessUnitID";

    /// <summary>
    /// Represents the unique identifier for an organization.
    /// </summary>
    public const string OrganizationID = "organizationID";

    /// <summary>
    /// Represents the name of the organization.
    /// </summary>
    public const string OrganizationName = "organizationName";

    /// <summary>
    /// Represents the raw identifier for an organization.
    /// </summary>
    public const string RawOrganizationID = "rawOrganizationID";

    /// <summary>
    /// Represents the unique identifier for an aggregator.
    /// </summary>
    public const string AggregatorID = "aggregatorID";

    /// <summary>
    /// Represents the raw identifier for an aggregator.
    /// </summary>
    public const string RawAggregatorID = "rawAggregatorID";

    /// <summary>
    /// Represents the unique identifier for a group.
    /// </summary>
    public const string GroupID = "groupID";

    /// <summary>
    /// Represents the unique identifier for a user.
    /// </summary>
    public const string UserID = "userID";

    /// <summary>
    /// Represents the raw identifier for a user.
    /// </summary>
    public const string RawUserID = "rawUserID";
}
