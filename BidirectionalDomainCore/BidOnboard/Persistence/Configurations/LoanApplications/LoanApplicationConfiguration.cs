using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.LoanApplications;

/// <summary>
/// Configures the database schema for the <see cref="LoanApplication"/> entity.
/// </summary>
public class LoanApplicationConfiguration : IEntityTypeConfiguration<LoanApplication>
{
    /// <summary>
    /// Configures the properties and relationships of the <see cref="LoanApplication"/> entity.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity type.</param>
    public void Configure(EntityTypeBuilder<LoanApplication> builder)
    {
        //builder.Property(e => e.Id)
        //    .HasColumnName("Id")
        //    .ValueGeneratedNever();
    }
}
