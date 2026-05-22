namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;

/// <summary>
/// Defines a contract for retrieving secrets from a provider.
/// </summary>
public interface ISecretProvider
{
    /// <summary>
    /// Asynchronously retrieves the value of a secret by its name.
    /// </summary>
    /// <param name="name">The name of the secret to retrieve.</param>
    /// <returns>
    /// A <see cref="Task{TResult}"/> representing the asynchronous operation, containing the value of the secret as a string.
    /// </returns>
    Task<string> GetAsync(string name);
}
