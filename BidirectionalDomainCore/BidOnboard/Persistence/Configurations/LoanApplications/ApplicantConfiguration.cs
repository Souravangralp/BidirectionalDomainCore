using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Bidirectional.DomainCore.BidOnboard.Persistence.Configurations.LoanApplications;

/// <summary>
/// Configures the EF Core mapping for the <see cref="Applicant"/> entity.
/// </summary>
public class EmployeeConfiguration : IEntityTypeConfiguration<Applicant>
{
    /// <summary>
    /// Configures the entity type builder for the <see cref="Applicant"/> entity.
    /// </summary>
    /// <param name="builder">The builder used to configure the <see cref="Applicant"/> entity.</param>
    public void Configure(EntityTypeBuilder<Applicant> builder)
    {

    }
}
