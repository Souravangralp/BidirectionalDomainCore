namespace Bidirectional.DomainCore.Persistence.Configurations.Bid;

/// <summary>
/// Explicit loan-schema FK names (avoids EF collisions when loan DbSets use explicit interface implementation).
/// </summary>
internal static class BidRelationshipConfiguration
{
    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<Organization>(entity =>
        {
            entity.HasOne(o => o.ParentOrganization)
                .WithMany(o => o.ChildOrganizations)
                .HasForeignKey(o => o.ParentOrganizationID)
                .HasConstraintName("FK_Loan_Organizations_ParentOrganizationID")
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<BusinessUnit>(entity =>
        {
            entity.HasOne(b => b.ParentBusinessUnit)
                .WithMany(b => b.SubBusinessUnits)
                .HasForeignKey(b => b.ParentBusinessUnitID)
                .HasConstraintName("FK_Loan_BusinessUnits_ParentBusinessUnitID")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(b => b.BusinessUnit_Organization)
                .WithMany(o => o.BusinessUnits)
                .HasForeignKey(b => b.BusinessUnit_OrganizationID)
                .HasConstraintName("FK_Loan_BusinessUnits_OrganizationID")
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
