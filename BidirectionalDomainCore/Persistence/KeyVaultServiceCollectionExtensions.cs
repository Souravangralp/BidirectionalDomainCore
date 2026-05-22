using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bidirectional.DomainCore.Persistence;

/// <summary>
/// Registers Azure Key Vault <see cref="SecretClient"/> and <see cref="ISecretProvider"/> for all platform APIs.
/// </summary>
public static class KeyVaultServiceCollectionExtensions
{
    /// <summary>
    /// Registers a singleton <see cref="SecretClient"/> and <see cref="KeyVaultSecretProvider"/> as <see cref="ISecretProvider"/>.
    /// </summary>
    /// <param name="services">The application service collection.</param>
    /// <param name="configuration">Application configuration containing <c>KeyVault:VaultUri</c>.</param>
    /// <returns>The same <see cref="IServiceCollection"/> for chaining.</returns>
    /// <exception cref="InvalidOperationException">Thrown when <c>KeyVault:VaultUri</c> is missing or invalid.</exception>
    public static IServiceCollection AddAzureKeyVaultSecrets(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        string? vaultUri = configuration["KeyVault:VaultUri"];
        if (string.IsNullOrWhiteSpace(vaultUri))
        {
            throw new InvalidOperationException("KeyVault URI is not configured. Set KeyVault:VaultUri.");
        }

        Uri keyVaultUri = new Uri(vaultUri);

        services.AddSingleton(_ =>
        {
            DefaultAzureCredential credential = new();
            return new SecretClient(keyVaultUri, credential);
        });

        services.AddSingleton<ISecretProvider, KeyVaultSecretProvider>();

        return services;
    }
}
