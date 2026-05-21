using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Bidirectional.DomainCore.Persistence;

/// <summary>
/// Design-time factory for EF Core migrations (single <c>Persistence/Migrations</c> folder for all module schemas).
/// </summary>
public sealed class PlatformDbContextFactory : IDesignTimeDbContextFactory<PlatformDbContext>
{
    public PlatformDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        string connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? "Server=DESKTOP-6SHLPJJ\\SQLEXPRESS;Initial Catalog=BidirectionalDomain;Persist Security Info=False;Integrated Security=True;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";

        connectionString = EnsureDesignTimeTrustServerCertificate(connectionString);

        DbContextOptions<PlatformDbContext> options = new DbContextOptionsBuilder<PlatformDbContext>()
            .UseSqlServer(
                connectionString,
                sql => sql.MigrationsAssembly(typeof(PlatformDbContext).Assembly.FullName))
            .Options;

        return new PlatformDbContext(options, configuration);
    }

    /// <summary>
    /// Local SQL Server (e.g. Express) often uses encryption without a trusted CA. Only applied when
    /// <c>TrustServerCertificate</c> is not already set in the connection string.
    /// </summary>
    internal static string EnsureDesignTimeTrustServerCertificate(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString)
            || connectionString.Contains("TrustServerCertificate", StringComparison.OrdinalIgnoreCase))
        {
            return connectionString;
        }

        SqlConnectionStringBuilder builder = new(connectionString)
        {
            TrustServerCertificate = true,
        };

        return builder.ConnectionString;
    }
}
