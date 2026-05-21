using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.LoanApplications;

/// <summary>
/// Configures relationships for <see cref="LoanApplicationUserOpen"/> so open history is not cascade-deleted with parent entities.
/// </summary>
public class LoanApplicationUserOpenConfiguration : IEntityTypeConfiguration<LoanApplicationUserOpen>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<LoanApplicationUserOpen> builder)
    {
        builder
            .HasOne(e => e.LoanApplicationUserOpen_LoanApplication)
            .WithMany(la => la.LoanApplicationUserOpens)
            .HasForeignKey(e => e.LoanApplicationUserOpen_LoanApplicationID)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(e => e.LoanApplicationUserOpen_User)
            .WithMany(u => u.LoanApplicationUserOpens)
            .HasForeignKey(e => e.LoanApplicationUserOpen_UserID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.LastOpenedUtc)
            .IsRequired();

        builder.HasIndex(e => new { e.LoanApplicationUserOpen_LoanApplicationID, e.LoanApplicationUserOpen_UserID })
            .IsUnique()
            .HasFilter("[ISDeleted] = 0");

        builder.HasIndex(e => new { e.LoanApplicationUserOpen_UserID, e.LastOpenedUtc });
    }
}
