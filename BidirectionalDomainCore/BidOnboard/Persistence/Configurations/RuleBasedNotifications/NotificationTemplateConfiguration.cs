using Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.RuleBasedNotifications;

/// <summary>
/// Maps <see cref="NotificationTemplate"/> content for the rule engine.
/// </summary>
public class NotificationTemplateConfiguration : IEntityTypeConfiguration<NotificationTemplate>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<NotificationTemplate> builder)
    {
        builder.ToTable("RuleNotificationTemplates");

        builder.Property(e => e.EventCode)
            .HasMaxLength(128)
            .IsRequired();

        builder.Property(e => e.Subject)
            .HasMaxLength(512);

        builder.Property(e => e.Body)
            .HasMaxLength(8000);

        builder.Property(e => e.SmsBody)
            .HasMaxLength(640);

        builder.HasIndex(e => new { e.NotificationEventID, e.ISActive });
    }
}
