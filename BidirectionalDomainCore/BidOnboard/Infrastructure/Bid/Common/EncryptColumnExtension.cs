using Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.Common;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common;

/// <summary>
/// Provides extension methods for applying encryption to entity properties in the model.
/// </summary>
public static class EncryptColumnExtension
{
    /// <summary>
    /// Configures the model builder to use encryption for entity properties decorated with the <see cref="EncryptColumnAttribute"/>.
    /// </summary>
    /// <param name="modelBuilder">The <see cref="ModelBuilder"/> to apply encryption configuration on.</param>
    public static void UseEncryption(this ModelBuilder modelBuilder)
    {
        EncryptionConvertor converter = new EncryptionConvertor();

        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach (IMutableProperty property in entityType.GetProperties())
            {
                if (property.ClrType == typeof(string) && !IsDiscriminator(property))
                {
                    object[]? attributes = property.PropertyInfo?.GetCustomAttributes(typeof(EncryptColumnAttribute), false);
                    if (attributes != null && attributes.Any())
                    {
                        property.SetValueConverter(converter); // <---
                    }
                }
            }
        }
    }

    /// <summary>
    /// Determines whether the specified property is the EF Core Discriminator or does not have associated property information.
    /// </summary>
    /// <param name="property">The property to check.</param>
    /// <returns><c>true</c> if the property is the discriminator or lacks property info; otherwise, <c>false</c>.</returns>
    private static bool IsDiscriminator(IMutableProperty property)
    {
        return property.Name == "Discriminator" || property.PropertyInfo == null;
    }
}

/// <summary>
/// Represents a value converter that encrypts and decrypts string properties for use with Entity Framework Core.
/// </summary>
public class EncryptionConvertor : ValueConverter<string?, string?>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EncryptionConvertor"/> class with the specified mapping hints.
    /// </summary>
    /// <param name="mappingHints">Hints that specify additional information for the conversion mapping.</param>
    public EncryptionConvertor(ConverterMappingHints? mappingHints = null)
    : base(
        static x => x != null ? ECCIESHelper.Encrypt(x) : null,
        static x => x != null ? ECCIESHelper.Decrypt(x) : null,
        mappingHints)
    { }
}
