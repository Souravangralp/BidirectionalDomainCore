using Bidirectional.DomainCore.BidOnboard.Entities;
using Bidirectional.DomainCore.BidOnboard.Entities.Privacy;

namespace Bidirectional.DomainCore.Persistence.Configurations.Onboarding;

/// <summary>
/// Explicit onboarding FK names and principals (avoids EF interface-DbSet constraint collisions at design time).
/// </summary>
internal static class OnboardingRelationshipConfiguration
{
    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<Organization>(entity =>
        {
            entity.HasOne(o => o.ParentOrganization)
                .WithMany(o => o.ChildOrganizations)
                .HasForeignKey(o => o.ParentOrganizationID)
                .HasConstraintName("FK_Onboarding_Organizations_ParentOrganizationID")
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<BusinessUnit>(entity =>
        {
            entity.HasOne(b => b.ParentBusinessUnit)
                .WithMany(b => b.SubBusinessUnits)
                .HasForeignKey(b => b.ParentBusinessUnitID)
                .HasConstraintName("FK_Onboarding_BusinessUnits_ParentBusinessUnitID")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(b => b.BusinessUnit_Organization)
                .WithMany(o => o.BusinessUnits)
                .HasForeignKey(b => b.BusinessUnit_OrganizationID)
                .HasConstraintName("FK_Onboarding_BusinessUnits_OrganizationID")
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<PrivacyPolicy>(entity =>
        {
            entity.HasOne(p => p.ParentPrivacyPolicy)
                .WithMany()
                .HasForeignKey(p => p.ParentPrivacyPolicyID)
                .HasConstraintName("FK_Onboarding_PrivacyPolicies_ParentPrivacyPolicyID")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(p => p.PrivacyPolicy_PrivacyPolicyType)
                .WithMany()
                .HasForeignKey(p => p.PrivacyPolicy_PrivacyPolicyTypeID)
                .HasConstraintName("FK_Onboarding_PrivacyPolicies_PrivacyPolicyTypeID")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(p => p.PrivacyPolicy_Organization)
                .WithMany()
                .HasForeignKey(p => p.PrivacyPolicy_OrganizationID)
                .HasConstraintName("FK_Onboarding_PrivacyPolicies_OrganizationID")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(p => p.PrivacyPolicy_BusinessUnit)
                .WithMany()
                .HasForeignKey(p => p.PrivacyPolicy_BusinessUnitID)
                .HasConstraintName("FK_Onboarding_PrivacyPolicies_BusinessUnitID")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(p => p.PrivacyPolicy_User)
                .WithMany()
                .HasForeignKey(p => p.PrivacyPolicy_UserID)
                .HasConstraintName("FK_Onboarding_PrivacyPolicies_UserID")
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<UserHierarchy>()
               .HasKey(uh => new { uh.UserHierarchy_ParentUserID, uh.UserHierarchy_ChildUserID });

        builder.Entity<UserHierarchy>()
            .HasOne(uh => uh.UserHierarchy_ParentUser)
            .WithMany(u => u.Children)
            .HasForeignKey(uh => uh.UserHierarchy_ParentUserID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<UserHierarchy>()
            .HasOne(uh => uh.UserHierarchy_ChildUser)
            .WithMany(u => u.Parents)
            .HasForeignKey(uh => uh.UserHierarchy_ChildUserID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
