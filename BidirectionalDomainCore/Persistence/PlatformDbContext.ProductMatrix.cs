using Bidirectional.DomainCore.Calculator.Entities;
using Bidirectional.DomainCore.Postcode.Entities;
using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.Postcode.Entities.Mappers;
using Bidirectional.DomainCore.ProductMatrix.Entities;
using Bidirectional.DomainCore.ProductMatrix.Entities.Calculator;
using Bidirectional.DomainCore.ProductMatrix.Entities.Products;
using Bidirectional.DomainCore.ProductMatrix.Entities.Rules;
using Bidirectional.DomainCore.ProductMatrix.Exceptions;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Bidirectional.DomainCore.Persistence
{
    public partial class PlatformDbContext
    {
        #region DbSets

        #region Postcodes

        public DbSet<PostcodeClassification> PostcodeClassifications => Set<PostcodeClassification>();

        #endregion

        #region ProductSelectors

        public DbSet<ClassificationsProductSelector> ClassificationsProductSelectors => Set<ClassificationsProductSelector>();

        public DbSet<FilterClassification> FilterClassifications => Set<FilterClassification>();

        #endregion

        #region Product Classification

        public DbSet<CreditIndexClassification> CreditIndexClassifications => Set<CreditIndexClassification>();

        public DbSet<AgeCreditReportClassification> AgeCreditReportClassifications => Set<AgeCreditReportClassification>();

        public DbSet<AgeOfNaturalPersonClassification> AgeOfNaturalPersonClassifications => Set<AgeOfNaturalPersonClassification>();

        public DbSet<ApplicationObjectiveClassification> ApplicationObjectiveClassifications => Set<ApplicationObjectiveClassification>();

        public DbSet<BorrowingEntityClassification> BorrowingEntityClassifications => Set<BorrowingEntityClassification>();

        public DbSet<ButtonTypeClassification> ButtonTypeClassifications => Set<ButtonTypeClassification>();

        public DbSet<CashOutClassification> CashOutClassifications => Set<CashOutClassification>();

        public DbSet<ConstructionClassification> ConstructionClassifications => Set<ConstructionClassification>();

        public DbSet<DocTypeClassification> DocTypeClassifications => Set<DocTypeClassification>();

        public DbSet<DischargedBankruptClassification> DischargedBankruptClassifications => Set<DischargedBankruptClassification>();

        public DbSet<DwellingsClassification> DwellingsClassifications => Set<DwellingsClassification>();

        public DbSet<EmployerClassification> EmployerClassifications => Set<EmployerClassification>();

        public DbSet<EmploymentClassification> EmploymentClassifications => Set<EmploymentClassification>();

        public DbSet<FacilityTypeClassification> FacilityTypeClassifications => Set<FacilityTypeClassification>();

        public DbSet<GuidedByTypeClassification> GuidedByTypeClassifications => Set<GuidedByTypeClassification>();

        public DbSet<HeedFulPointTypeClassification> HeedFulPointTypeClassifications => Set<HeedFulPointTypeClassification>();

        public DbSet<LandSizeClassification> LandSizeClassifications => Set<LandSizeClassification>();

        public DbSet<LoanAmountClassification> LoanAmountClassifications => Set<LoanAmountClassification>();

        public DbSet<LvrClassification> LvrClassifications => Set<LvrClassification>();

        public DbSet<MaritalStatusClassification> MaritalStatusClassifications => Set<MaritalStatusClassification>();

        public DbSet<OtherIncomeTypeClassification> OtherIncomeTypeClassifications => Set<OtherIncomeTypeClassification>();

        public DbSet<RepaymentTypeClassification> RepaymentTypeClassifications => Set<RepaymentTypeClassification>();

        public DbSet<SecurityTypeClassification> SecurityTypeClassifications => Set<SecurityTypeClassification>();

        public DbSet<SelfEmployedClassification> SelfEmployedClassifications => Set<SelfEmployedClassification>();

        public DbSet<ServiceTypeClassification> ServiceTypeClassifications => Set<ServiceTypeClassification>();

        public DbSet<TitleTypeClassification> TitleTypeClassifications => Set<TitleTypeClassification>();

        public DbSet<UnitsApartmentClassification> UnitsApartmentClassifications => Set<UnitsApartmentClassification>();

        public DbSet<UsageTypeClassification> UsageTypeClassifications => Set<UsageTypeClassification>();

        public DbSet<ZoningTypeClassification> ZoningTypeClassifications => Set<ZoningTypeClassification>();

        public DbSet<StatementOfClaimClassification> StatementOfClaimClassifications => Set<StatementOfClaimClassification>();

        public DbSet<DefaultJudgementClassification> DefaultJudgementClassifications => Set<DefaultJudgementClassification>();

        public DbSet<DocTypeRequirementClassification> LoDocRequirementClassifications => Set<DocTypeRequirementClassification>();

        public DbSet<ArrearsClassification> ArrearsClassifications => Set<ArrearsClassification>();

        public DbSet<PaygIncomeClassification> PaygIncomeClassifications => Set<PaygIncomeClassification>();

        public DbSet<ExchangedContractClassification> ExchangedContractClassifications => Set<ExchangedContractClassification>();

        public DbSet<DefaultOverClassification> DefaultOverClassifications => Set<DefaultOverClassification>();

        public DbSet<DefaultAmount> DefaultAmounts => Set<DefaultAmount>();

        public DbSet<LateRepaymentHistoryClassification> LateRepaymentHistoryClassifications => Set<LateRepaymentHistoryClassification>();

        public DbSet<BusinessRegistrationClassification> BusinessRegistrationClassifications => Set<BusinessRegistrationClassification>();

        public DbSet<BorrowerFinancialConditionClassification> BorrowerFinancialConditionClassifications => Set<BorrowerFinancialConditionClassification>();

        public DbSet<FinancialStatementClassification> FinancialStatementClassifications => Set<FinancialStatementClassification>();

        public DbSet<ResidencyTypeClassification> ResidencyTypesClassifications => Set<ResidencyTypeClassification>();

        public DbSet<FinancialDefaultClassification> FinancialDefaultClassifications => Set<FinancialDefaultClassification>();

        #endregion

        public DbSet<CouncilZoningFilterClassificationMapper> CouncilZoningFilterClassificationMapper => Set<CouncilZoningFilterClassificationMapper>();

        public DbSet<Product> Products => Set<Product>();

        public DbSet<DocType> DocTypes => Set<DocType>();

        public DbSet<LandSize> LandSizes => Set<LandSize>();

        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();

        public DbSet<CouncilZoningCategory> CouncilZoningCategories => Set<CouncilZoningCategory>();

        public DbSet<NumeralClassification> NumeralClassifications => Set<NumeralClassification>();

        public DbSet<PostcodeSpecificationMapper> PostcodeSpecificationMappers => Set<PostcodeSpecificationMapper>();

        public DbSet<AuditLogDetail> AuditLogDetails => Set<AuditLogDetail>();

        public DbSet<FinancialAndEntityClassificationFilter> FinancialAndEntityClassificationFilters => Set<FinancialAndEntityClassificationFilter>();

        public DbSet<DefaultListingRules> DefaultListingRules => Set<DefaultListingRules>();

        #endregion

        #region Methods

        public async Task<string> ExecuteRawSqlAsync(string storedProcedureName, params SqlParameter[] parameters)
        {
            try
            {
                using DbCommand command = Database.GetDbConnection().CreateCommand();

                command.CommandText = storedProcedureName;

                command.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }

                await Database.OpenConnectionAsync();

                using (DbDataReader dataReader = await command.ExecuteReaderAsync())
                {
                    StringBuilder jsonStringBuilder = new StringBuilder();

                    while (await dataReader.ReadAsync())
                    {
                        jsonStringBuilder.Append(dataReader.GetString(0));
                    }

                    return jsonStringBuilder.ToString();
                }
            }
            catch (SqlException ex)
            {
                throw new SQLException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new SQLException(ex.ToString());
            }
        }

        #endregion

    }
}
