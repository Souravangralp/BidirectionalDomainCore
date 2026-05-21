namespace Bidirectional.DomainCore.Postcode.Constants;

/// <summary>
/// Contains constants representing authorization policies used throughout the application.
/// </summary>
public abstract class Policies
{
    /// <summary>
    /// Policy name representing the permission to purge data.
    /// </summary>
    public const string CanPurge = nameof(CanPurge);
}