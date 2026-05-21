using Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.RuleBasedNotifications;

/// <summary>
/// Maps the rule-based <see cref="NotificationEvent"/> catalogue to its own table (separate from legacy notifications).
/// </summary>
public class NotificationEventConfiguration : IEntityTypeConfiguration<NotificationEvent>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<NotificationEvent> builder)
    {
        builder.ToTable("RuleNotificationEvents");

        builder.Property(e => e.EventCode)
            .HasMaxLength(128)
            .IsRequired();

        builder.Property(e => e.Name)
            .HasMaxLength(256)
            .IsRequired();

        builder.Property(e => e.Description)
            .HasMaxLength(2000);

        builder.HasIndex(e => e.EventCode)
            .IsUnique()
            .HasFilter("[ISDeleted] = 0");

        builder.HasMany(e => e.NotificationConfigurations)
            .WithOne(c => c.NotificationEvent)
            .HasForeignKey(c => c.NotificationEventID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.NotificationTemplates)
            .WithOne(t => t.NotificationEvent)
            .HasForeignKey(t => t.NotificationEventID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
