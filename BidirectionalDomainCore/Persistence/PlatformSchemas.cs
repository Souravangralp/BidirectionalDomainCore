namespace Bidirectional.DomainCore.Persistence;

/// <summary>
/// SQL Server schema names — one per bounded module (repo) in the modular monolith.
/// </summary>
public static class PlatformSchemas
{
    public const string Shared = "shared";

    public const string BidOnboard = "bidOnboard";

    public const string Calculator = "calculator";

    public const string Postcode = "postcode";

    public const string ProductMatrix = "productMatrix";
}
