using Azure.Security.KeyVault.Secrets;
using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;

namespace Bidirectional.DomainCore.Persistence
{
    /// <summary>
    /// Provides access to secrets stored in Azure Key Vault via an injected <see cref="SecretClient"/>.
    /// </summary>
    public class KeyVaultSecretProvider : ISecretProvider
    {
        private readonly SecretClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVaultSecretProvider"/> class with a specified Key Vault client.
        /// </summary>
        /// <param name="client">The <see cref="SecretClient"/> used to access Azure Key Vault secrets.</param>
        public KeyVaultSecretProvider(SecretClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves a secret value from Azure Key Vault by its name.
        /// </summary>
        /// <param name="name">The name of the secret to retrieve from Azure Key Vault.</param>
        /// <returns>
        /// A <see cref="Task{String}"/> that represents the asynchronous operation. The task result contains the secret value as a string.
        /// </returns>
        public async Task<string> GetAsync(string name)
        {
            return (await _client.GetSecretAsync(name)).Value.Value;
        }
    }

}
