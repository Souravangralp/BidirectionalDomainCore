using Microsoft.Extensions.Configuration;

namespace Bidirectional.DomainCore.Common.Utilities
{
    /// <summary>
    /// Provides a contract for retrieving the encryption key used for cryptographic operations.
    /// </summary>
    public interface IEncryptionKeyProvider
    {
        /// <summary>
        /// Gets the encryption key as a string.
        /// </summary>
        string Key { get; }
    }

    /// <summary>
    /// Implements <see cref="IEncryptionKeyProvider"/> to retrieve the encryption key from configuration.
    /// </summary>
    public class EncryptionKeyProvider : IEncryptionKeyProvider
    {
        /// <summary>
        /// Gets the encryption key as a string.
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionKeyProvider"/> class using the provided configuration.
        /// </summary>
        /// <param name="config">The application configuration containing the encryption key.</param>
        public EncryptionKeyProvider(IConfiguration config)
        {
            Key = config["EncryptTokenValue:Key"]!;
        }
    }

    /// <summary>
    /// Provides global access to the application's <see cref="IEncryptionKeyProvider"/>.
    /// </summary>
    public static class EncryptionKeyAccessor
    {
        /// <summary>
        /// Gets the current encryption key provider.
        /// </summary>
        public static IEncryptionKeyProvider Provider { get; private set; } = null!;

        /// <summary>
        /// Initializes the encryption key provider to be accessed globally.
        /// </summary>
        /// <param name="provider">The encryption key provider to set.</param>
        public static void Init(IEncryptionKeyProvider provider)
        {
            Provider = provider;
        }
    }

}
