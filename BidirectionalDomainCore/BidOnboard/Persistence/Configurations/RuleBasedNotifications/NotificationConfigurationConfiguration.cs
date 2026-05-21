using Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.RuleBasedNotifications;

/// <summary>
/// Maps <see cref="NotificationConfiguration"/> to its own table.
/// </summary>
public class NotificationConfigurationConfiguration : IEntityTypeConfiguration<NotificationConfiguration>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<NotificationConfiguration> builder)
    {
        builder.ToTable("RuleNotificationConfigurations");

        builder.HasMany(e => e.NotificationRecipients)
            .WithOne(r => r.NotificationConfiguration)
            .HasForeignKey(r => r.NotificationConfigurationID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
