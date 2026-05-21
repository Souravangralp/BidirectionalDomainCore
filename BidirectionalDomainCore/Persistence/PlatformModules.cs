namespace Bidirectional.DomainCore.Persistence;

/// <summary>
/// Top-level folder names under BidirectionalDomainCore (repo modules).
/// </summary>
public static class PlatformModules
{
    public const string Shared = "Shared";

    /// <summary>Cross-cutting types under <c>Common/</c> (not module-owned entities).</summary>
    public const string Common = "Common";

    public const string BidOnboard = "BidOnboard";

    public const string Calculator = "Calculator";

    public const string Postcode = "Postcode";

    public const string ProductMatrix = "ProductMatrix";
}
