namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Azure Key Vault URL template. {0} is the vault name (e.g. "myvault" yields "https://myvault.vault.azure.net").
/// </summary>
public record AzureConstant
{
    /// <summary>Key Vault base URL template; {0} = vault name.</summary>
    public const string BaseUrl = "https://{0}" + ".vault.azure.net";
}

/// <summary>
/// Azure Blob Storage container names used by the application (e.g. CompanyLogo, Configuration).
/// </summary>
public record AzureContainer
{
    /// <summary>Gets the container name.</summary>
    public string ContainerName { get; } = string.Empty;

    private AzureContainer(string containerName)
    {
        ContainerName = containerName;
    }

    /// <summary>Company logo container.</summary>
    public static readonly AzureContainer CompanyLogo = new("CompanyLogo");

    /// <summary>Configuration container.</summary>
    public static readonly AzureContainer Configuration = new("Configuration");
}

/// <summary>
/// Storage path and file names for config (e.g. bidirectional-config folder, domain CORS config file).
/// </summary>
public record Storage
{
    /// <summary>Configuration folder name in storage ("bidirectional-config").</summary>
    public const string ConfigFolder = "bidirectional-config";

    /// <summary>CORS configuration file name ("domain").</summary>
    public const string CorsConfigFile = "domain";
}
