namespace Bidirectional.DomainCore.Postcode.Constants;

/// <summary>
/// Contains constants for user-related stored procedures.
/// </summary>
[ExcludeFromCodeCoverage]
public record UserStoredProcedure
{
    /// <summary>
    /// The stored procedure name for retrieving suburb classification information.
    /// </summary>
    public static readonly string GetSuburbClassification = "uspGetSuburbClassification";

    /// <summary>
    /// The stored procedure name for retrieving postcode classification information.
    /// </summary>
    public static readonly string GetPostcodeClassification = "uspGetPostcodeClassification";
}

/// <summary>
/// Contains parameter names for suburb classification stored procedures.
/// </summary>
[ExcludeFromCodeCoverage]
public record SuburbClassificationParams
{
    /// <summary>
    /// The name of the parameter for the postcode ID in the suburb classification stored procedure.
    /// </summary>
    public static readonly string PostcodeID = "@PostcodeID";
}
