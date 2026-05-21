using Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.RuleBasedNotifications;

/// <summary>
/// Maps <see cref="NotificationRecipient"/> and recipient resolution foreign keys.
/// </summary>
public class NotificationRecipientConfiguration : IEntityTypeConfiguration<NotificationRecipient>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<NotificationRecipient> builder)
    {
        builder.ToTable("RuleNotificationRecipients");

        builder.Property(e => e.RecipientType)
            .HasConversion<int>();

        builder.HasOne(e => e.UserGroup)
            .WithMany()
            .HasForeignKey(e => e.UserGroupID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(e => new { e.NotificationConfigurationID, e.RecipientType });
    }
}
