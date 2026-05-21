using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common;

/// <summary>
/// Provides extension methods for configuring enum properties on Entity Framework Core models.
/// </summary>
public static class EnumPropertyBuilderExtensions
{
    /// <summary>
    /// Configures an enum property to be stored as a string in the database, with optional maximum length and Unicode settings.
    /// </summary>
    /// <typeparam name="TEntity">The entity type being configured.</typeparam>
    /// <typeparam name="TProperty">The property type, which should be an enum or nullable enum.</typeparam>
    /// <param name="builder">The EntityTypeBuilder for the entity type.</param>
    /// <param name="propertyExpression">An expression identifying the property to configure.</param>
    /// <param name="maxLength">The maximum length of the string column (default is 50).</param>
    /// <param name="unicode">Indicates whether the column should support Unicode (default is false).</param>
    /// <returns>
    /// The property builder for further configuration.
    /// </returns>
    public static PropertyBuilder<TProperty> HasEnumStringConversion<TEntity, TProperty>(
        this EntityTypeBuilder<TEntity> builder,
        Expression<Func<TEntity, TProperty>> propertyExpression,
        int maxLength = 50,
        bool unicode = false)
        where TEntity : class
    {
        PropertyBuilder<TProperty> property = builder.Property(propertyExpression);

        Type type = typeof(TProperty);
        Type enumType = Nullable.GetUnderlyingType(type) ?? type;

        if (!enumType.IsEnum)
        {
            throw new InvalidOperationException($"{type.Name} is not an enum type.");
        }

        property
            .HasConversion<string>()
            .HasMaxLength(maxLength)
            .IsUnicode(unicode);

        return property;
    }
}
