namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Development environment name used to detect non-production (e.g. for logging or feature flags).
/// </summary>
public class DevelopmentEnvironment
{
    /// <summary>Gets or sets the development environment name ("Development") (get set).</summary>
    public static string DevEnvironment { get; set; } = "Development";
}
