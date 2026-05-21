namespace Bidirectional.DomainCore.Postcode.Constants
{
    /// <summary>
    /// Provides Azure Key Vault constants used in the application.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public record AzureConstant
    {
        /// <summary>
        /// The format string for the base URL of an Azure Key Vault instance.
        /// </summary>
        public const string BaseUrl = "https://{0}" + ".vault.azure.net";
    }

    /// <summary>
    /// Contains the names of Azure Blob Storage containers used by the application.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public record AzureContainer()
    {
        /// <summary>
        /// The container name for storing company logo images.
        /// </summary>
        public static readonly string CompanyLogo = "CompanyLogo";

        /// <summary>
        /// The container name for storing configuration files.
        /// </summary>
        public static readonly string Configuration = "Configuration";
    }

    /// <summary>
    /// Contains constants related to Azure Storage structure and files.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public record Storage
    {
        /// <summary>
        /// The name of the configuration folder in Azure Storage.
        /// </summary>
        public const string ConfigFolder = "bidirectional-config";

        /// <summary>
        /// The file name for CORS domain configuration.
        /// </summary>
        public const string CorsConfigFile = "domain";
    }
}
