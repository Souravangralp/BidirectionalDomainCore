using Bidirectional.DomainCore.BidOnboard.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Onboarding.Helpers;

[ExcludeFromCodeCoverage]
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(user => user.OrganizationBusinessUnitGroupUserMappers)
                .WithOne(user => user.User)
                .HasForeignKey(user => user.UserID)
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Passports)
            .WithOne(user => user.Passport_User)
            .HasForeignKey(user => user.Passport_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.DocumentDetails)
            .WithOne(user => user.DocumentDetail_User)
            .HasForeignKey(user => user.DocumentDetail_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Emails)
            .WithOne(user => user.EmailDetail_User)
            .HasForeignKey(user => user.EmailDetail_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Phones)
            .WithOne(user => user.PhoneDetail_User)
            .HasForeignKey(user => user.PhoneDetail_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Addresses)
            .WithOne(user => user.Address_User)
            .HasForeignKey(user => user.Address_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.PreferredCommunicationDetails)
            .WithOne(user => user.PreferredCommunicationDetail_User)
            .HasForeignKey(user => user.PreferredCommunicationDetail_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.OnboardingProcesses)
            .WithOne(user => user.OnboardingProcess_User)
            .HasForeignKey(user => user.OnboardingProcess_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.OrganizationBusinessUnitGroupUserMappers)
            .WithOne(user => user.User)
            .HasForeignKey(user => user.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.BankAssets)
            .WithOne(user => user.BankAsset_User)
            .HasForeignKey(user => user.BankAsset_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.FurnitureAndPersonalAssets)
            .WithOne(user => user.FurnitureAndPersonalAsset_User)
            .HasForeignKey(user => user.FurnitureAndPersonalAsset_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.InvestmentAssets)
            .WithOne(user => user.InvestmentAsset_User)
            .HasForeignKey(user => user.InvestmentAsset_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.MotorVehicleAssets)
            .WithOne(user => user.MotorVehicleAsset_User)
            .HasForeignKey(user => user.MotorVehicleAsset_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.OtherAssets)
            .WithOne(user => user.OtherAsset_User)
            .HasForeignKey(user => user.OtherAsset_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.RealEstateAssets)
            .WithOne(user => user.RealEstateAsset_User)
            .HasForeignKey(user => user.RealEstateAsset_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.SuperannuationAssets)
            .WithOne(user => user.SuperannuationAsset_User)
            .HasForeignKey(user => user.SuperannuationAsset_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.CreditCardLiabilities)
            .WithOne(user => user.Liability_User)
            .HasForeignKey(user => user.Liability_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.HpLeaseLiabilities)
            .WithOne(user => user.HpLeaseLiability_User)
            .HasForeignKey(user => user.HpLeaseLiability_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.MortgageLiabilities)
            .WithOne(user => user.MortgageLiability_User)
            .HasForeignKey(user => user.MortgageLiability_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.OtherLiabilities)
            .WithOne(user => user.OtherLiability_User)
            .HasForeignKey(user => user.OtherLiability_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.PersonalLoanLiabilities)
            .WithOne(user => user.PersonalLoanLiability_User)
            .HasForeignKey(user => user.PersonalLoanLiability_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Languages)
            .WithOne(user => user.Language_User)
            .HasForeignKey(user => user.Language_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Dependents)
            .WithOne(user => user.Dependent_User)
            .HasForeignKey(user => user.Dependent_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.IndustryExperiences)
            .WithOne(user => user.IndustryExperience_User)
            .HasForeignKey(user => user.IndustryExperience_UserID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(user => user.Accreditations)
            .WithOne(user => user.Accreditation_User)
            .HasForeignKey(user => user.Accreditation_UserID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
