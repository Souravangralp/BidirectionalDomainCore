using Bidirectional.DomainCore.BidOnboard.Entities.RuleBasedNotifications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.RuleBasedNotifications;

/// <summary>
/// Maps <see cref="UserNotification"/> rows for the rule-based in-app inbox.
/// </summary>
public class UserNotificationConfiguration : IEntityTypeConfiguration<UserNotification>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<UserNotification> builder)
    {
        builder.ToTable("RuleEngineUserNotifications");

        builder.Property(e => e.EventCode)
            .HasMaxLength(128);

        builder.Property(e => e.Title)
            .HasMaxLength(512);

        builder.Property(e => e.Message)
            .HasMaxLength(4000);

        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(e => new { e.UserID, e.ISRead, e.CreatedUtc });
    }
}
