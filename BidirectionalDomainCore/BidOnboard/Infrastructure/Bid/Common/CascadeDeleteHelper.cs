using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities.Valocity;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Common;

/// <summary>
/// Provides helper methods for configuring cascade delete relationships in the Entity Framework model builder.
/// </summary>
[ExcludeFromCodeCoverage]
public static class CascadeDeleteHelper
{
    /// <summary>
    /// Configures the cascade delete behavior for various entity relationships in the model.
    /// </summary>
    /// <param name="builder">The model builder used to configure entity relationships.</param>
    public static void OnModelCreating(ModelBuilder builder)
    {
        #region Applicant Cascade Delete        

        #region Applicant DriverLicense

        builder.Entity<Applicant>()
            .HasOne(applicant => applicant.DriverLicense)
            .WithOne(driverLicense => driverLicense.DriverLicense_Applicant)
            .HasForeignKey<DriverLicense>(driverLicense => driverLicense.DriverLicense_ApplicantID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region Applicant Passports

        builder.Entity<Applicant>()
            .HasOne(applicant => applicant.Passport)
            .WithOne(passport => passport.Passport_Applicant)
            .HasForeignKey<Passport>(passport => passport.Passport_ApplicantID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region Applicant Payg

        builder.Entity<Applicant>()
             .HasMany(applicant => applicant.Paygs)
             .WithOne(payg => payg.Payg_Applicant)
             .HasForeignKey(payg => payg.Payg_ApplicantID)
             .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Payg>()
            .HasOne(payg => payg.EmploymentStatus)
            .WithOne(employmentIncomeDetail => employmentIncomeDetail.EmploymentIncomeDetail_Payg)
            .HasForeignKey<EmploymentStatusDetail>(employmentIncomeDetail => employmentIncomeDetail.EmploymentIncomeDetail_PaygID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Payg>()
           .HasOne(payg => payg.SelfEmploymentDetail)
           .WithOne(selfEmployed => selfEmployed.SelfEmploymentDetail_Payg)
           .HasForeignKey<SelfEmploymentDetail>(selfEmployed => selfEmployed.SelfEmploymentDetail_PaygID)
           .OnDelete(DeleteBehavior.Cascade);

        //builder.Entity<Payg>()
        //   .HasOne(payg => payg.EmployerDetails)
        //   .WithOne(employerDetail => employerDetail.EmployerDetail_Payg)
        //   .HasForeignKey<EmployerDetail>(employerDetail => employerDetail.EmployerDetail_PaygID)
        //   .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region Applicant CreditHistoryForFinancialAndNonFinancials

        builder.Entity<Applicant>()
            .HasMany(applicant => applicant.CreditHistoryForFinancialAndNonFinancials)
            .WithOne(creditHistoryForFinancialAndNonFinancial => creditHistoryForFinancialAndNonFinancial.CreditHistoryForFinancialAndNonFinancial_Applicant)
            .HasForeignKey(creditHistoryForFinancialAndNonFinancial => creditHistoryForFinancialAndNonFinancial.CreditHistoryForFinancialAndNonFinancial_ApplicantID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<CreditHistoryForFinancialAndNonFinancial>()
            .HasMany(creditHistoryForFinancialAndNonFinancial => creditHistoryForFinancialAndNonFinancial.RelatedEntityActions)
            .WithOne(relatedEntityAction => relatedEntityAction.RelatedEntityAction_CreditHistoryForFinancialAndNonFinancial)
            .HasForeignKey(relatedEntityAction => relatedEntityAction.RelatedEntityAction_CreditHistoryForFinancialAndNonFinancialID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        //#region Applicant Households

        //builder.Entity<Applicant>()
        //    .HasMany(applicant => applicant.Households)
        //    .WithOne(household => household.Household_Applicant)
        //    .HasForeignKey(household => household.Household_ApplicantID)
        //    .OnDelete(DeleteBehavior.Cascade);

        //#endregion

        //#region Applicant Addresses

        //builder.Entity<Applicant>()
        //    .HasMany(applicant => applicant.Addresses)
        //    .WithOne(address => address.Address_Applicant)
        //    .HasForeignKey(address => address.Address_ApplicantID)
        //    .OnDelete(DeleteBehavior.Cascade);

        //#endregion

        //#region Applicant MaritalStatusDetails

        //builder.Entity<Applicant>()
        //    .HasOne(applicant => applicant.MaritalStatusDetails)
        //    .WithOne(maritalStatusDetail => maritalStatusDetail.MaritalStatusDetail_Applicant)
        //    .HasForeignKey<MaritalStatusDetail>(maritalStatusDetail => maritalStatusDetail.MaritalStatusDetail_ApplicantID)
        //    .OnDelete(DeleteBehavior.Cascade);

        //#endregion

        //#region Applicant Contacts

        //builder.Entity<Applicant>()
        //    .HasOne(applicant => applicant.Contacts)
        //    .WithOne(contact => contact.Contact_Applicant)
        //    .HasForeignKey<Contact>(contact => contact.Contact_ApplicantID)
        //    .OnDelete(DeleteBehavior.Cascade);

        //#endregion

        #endregion

        #region LoanApplication Cascade Delete

        #region LoanApplication SettlementSecurityAddresses

        builder.Entity<LoanApplication>()
            .HasMany(loanApplication => loanApplication.SettlementSecurityAddresses)
            .WithOne(settlementSecurityAddress => settlementSecurityAddress.SettlementSecurityAddress_LoanApplication)
            .HasForeignKey(settlementSecurityAddress => settlementSecurityAddress.SettlementSecurityAddress_LoanApplicationID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region LoanApplication Recommendations

        builder.Entity<LoanApplication>()
            .HasOne(loanApplication => loanApplication.Recommendation)
            .WithOne(recommendation => recommendation.Recommendation_LoanApplication)
            .HasForeignKey<Recommendation>(recommendation => recommendation.Recommendation_LoanApplicationId)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region LoanApplication Mortgages

        builder.Entity<LoanApplication>()
            .HasMany(loanApplication => loanApplication.Mortgages)
            .WithOne(mortgage => mortgage.Mortgage_LoanApplication)
            .HasForeignKey(mortgage => mortgage.Mortgage_LoanApplicationID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Mortgage>()
            .HasMany(mortgage => mortgage.MortgageAccountsInformation)
            .WithOne(mortgageAccountInformation => mortgageAccountInformation.MortgageAccountInformation_Mortgage)
            .HasForeignKey(mortgageAccountInformation => mortgageAccountInformation.MortgageAccountInformation_MortgageID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region LoanApplication OtherAssets

        builder.Entity<OtherAsset>()
            .HasMany(otherAsset => otherAsset.NonRealEstateAssetOwnershipPercentages)
            .WithOne(percentOwnerNonRealEstateAsset => percentOwnerNonRealEstateAsset.NonRealEstateAssetOwnershipPercentage_OtherAsset)
            .HasForeignKey(percentOwnerNonRealEstateAsset => percentOwnerNonRealEstateAsset.NonRealEstateAssetOwnershipPercentage_OtherAssetID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region LoanApplication OtherObservations

        builder.Entity<LoanApplication>()
            .HasMany(loanApplication => loanApplication.OtherObservations)
            .WithOne(otherObservation => otherObservation.OtherObservation_LoanApplication)
            .HasForeignKey(otherObservation => otherObservation.OtherObservation_LoanApplicationID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region LoanApplication LoanSecurities

        builder.Entity<Address>()
          .HasMany(address => address.PropertyDetails)
          .WithOne(propertyDetails => propertyDetails.PropertyDetail_Address)
          .HasForeignKey(propertyDetails => propertyDetails.PropertyDetail_AddressID)
          .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PropertyDetail>()
          .HasOne(propertyDetails => propertyDetails.SuburbDetails)
          .WithOne(suburbDetails => suburbDetails.SuburbDetail_PropertyDetail)
          .HasForeignKey<SuburbDetail>(suburbDetails => suburbDetails.SuburbDetail_PropertyDetailID)
          .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PropertyDetail>()
         .HasOne(propertyDetails => propertyDetails.SuburbValuationDetails)
         .WithOne(suburbValuationDetail => suburbValuationDetail.SuburbValuationDetail_PropertyDetail)
         .HasForeignKey<SuburbValuationDetail>(suburbValuationDetail => suburbValuationDetail.SuburbValuationDetail_PropertyDetailID)
         .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PropertyDetail>()
         .HasMany(propertyDetails => propertyDetails.SuburbMonthlyDetails)
         .WithOne(suburbMonthlyDetails => suburbMonthlyDetails.SuburbMonthlyDetail_PropertyDetail)
         .HasForeignKey(suburbMonthlyDetails => suburbMonthlyDetails.SuburbMonthlyDetail_PropertyDetailID)
         .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PropertyDetail>()
         .HasOne(propertyDetails => propertyDetails.ConsumerEstimateDetails)
         .WithOne(consumerEstimateDetail => consumerEstimateDetail.ConsumerEstimateDetail_PropertyDetail)
         .HasForeignKey<ConsumerEstimateDetail>(consumerEstimateDetail => consumerEstimateDetail.ConsumerEstimateDetail_PropertyDetailID)
         .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PropertyDetail>()
         .HasMany(propertyDetails => propertyDetails.PropertySaleHistoryDetails)
         .WithOne(propertySaleHistoryDetail => propertySaleHistoryDetail.PropertySaleDetail_PropertyDetail)
         .HasForeignKey(propertySaleHistoryDetail => propertySaleHistoryDetail.PropertySaleDetail_PropertyDetailID)
         .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PropertyDetail>()
         .HasMany(propertyDetails => propertyDetails.LocalSchoolDetails)
         .WithOne(localSchoolDetail => localSchoolDetail.LocalSchoolDetail_PropertyDetail)
         .HasForeignKey(localSchoolDetail => localSchoolDetail.LocalSchoolDetail_PropertyDetailID)
         .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region LoanApplication MortgageSplits

        builder.Entity<FeedbackAndIndication>()
           .HasMany(feedbackAndIndication => feedbackAndIndication.MortgageSplits)
           .WithOne(mortgageSplit => mortgageSplit.MortgageSplit_FeedbackAndIndication)
           .HasForeignKey(mortgageSplit => mortgageSplit.MortgageSplit_FeedbackAndIndicationID)
           .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<MortgageSplit>()
          .HasMany(mortgageSplit => mortgageSplit.MortgageUsages)
          .WithOne(mortgageUsage => mortgageUsage.MortgageUsage_MortgageSplit)
          .HasForeignKey(mortgageUsage => mortgageUsage.MortgageUsage_MortgageSplitID)
          .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<FeedbackAndIndication>()
           .HasOne(feedbackAndIndication => feedbackAndIndication.PostSettlementEvent)
           .WithOne(postSettlementEvent => postSettlementEvent.PostSettlementEvent_FeedbackAndIndication)
           .HasForeignKey<PostSettlementEvent>(postSettlementEvent => postSettlementEvent.PostSettlementEvent_FeedbackAndIndicationID)
           .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #region LoanApplication LoanSplit

        builder.Entity<LoanSplit>()
          .HasOne(loanSplit => loanSplit.LoanSecurity)
          .WithOne(ls => ls.LoanSecurity_LoanSplit)
          .HasForeignKey<LoanSecurity>(lp => lp.LoanSecurity_LoanSplitID)
          .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<LoanSplit>()
           .HasOne(loanSplit => loanSplit.LoanPurposeDetails)
           .WithOne(lp => lp.LoanPurposeDetail_LoanSplit)
           .HasForeignKey<LoanPurposeDetail>(lp => lp.LoanPurposeDetail_LoanSplitID)
           .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<LoanPurposeDetail>()
           .HasOne(lp => lp.Relocation)
           .WithOne(relocation => relocation.Relocation_LoanPurposeDetail)
           .HasForeignKey<Relocation>(relocation => relocation.Relocation_LoanPurposeDetailID)
           .OnDelete(DeleteBehavior.Cascade);

        //builder.Entity<Relocation>()
        //   .HasOne(relocation => relocation.Address)
        //   .WithOne(address => address.Address_Relocation)
        //   .HasForeignKey<Address>(address => address.Address_RelocationID)
        //   .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<LoanPurposeDetail>()
           .HasOne(lp => lp.Construction)
           .WithOne(construction => construction.Construction_LoanPurposeDetail)
           .HasForeignKey<Construction>(construction => construction.Construction_LoanPurposeDetailID)
           .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<LoanPurposeDetail>()
           .HasOne(lp => lp.Cashout)
           .WithOne(cashOut => cashOut.Cashout_LoanPurposeDetail)
           .HasForeignKey<Cashout>(cashOut => cashOut.Cashout_LoanPurposeDetailID)
           .OnDelete(DeleteBehavior.Cascade);

        //builder.Entity<CashOut>()
        //   .HasOne(cashOut => cashOut.ImminentPropertyAddress)
        //   .WithOne(address => address.Address_CashOut)
        //   .HasForeignKey<Address>(address => address.Address_CashOutID)
        //   .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<LoanPurposeDetail>()
           .HasOne(lp => lp.Purchase)
           .WithOne(purchase => purchase.Purchase_LoanPurposeDetail)
           .HasForeignKey<Purchase>(purchase => purchase.Purchase_LoanPurposeDetailID)
           .OnDelete(DeleteBehavior.Cascade);

        //builder.Entity<Purchase>()
        //   .HasOne(purchase => purchase.Address)
        //   .WithOne(address => address.Address_Purchase)
        //   .HasForeignKey<Address>(address => address.Address_PurchaseID)
        //   .OnDelete(DeleteBehavior.Cascade);

        #endregion

        #endregion

        #region LoanApplication LoanApplicationApplicantMapper Cascade Delete

        builder.Entity<LoanApplicationApplicantMapper>()
            .HasOne(loanApplicationApplicantMapper => loanApplicationApplicantMapper.LoanApplicationApplicantMapper_Applicant)
            .WithMany(a => a.LoanApplicationApplicantMappers)
            .HasForeignKey(loanApplicationApplicantMapper => loanApplicationApplicantMapper.LoanApplicationApplicantMapper_ApplicantID)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<LoanApplicationApplicantMapper>()
            .HasOne(loanApplicationApplicantMapper => loanApplicationApplicantMapper.LoanApplicationApplicantMapper_LoanApplication)
            .WithMany(a => a.LoanApplicationApplicantMappers)
            .HasForeignKey(loanApplicationApplicantMapper => loanApplicationApplicantMapper.LoanApplicationApplicantMapper_LoanApplicationID)
            .OnDelete(DeleteBehavior.Cascade);

        #endregion
    }
}
