using Bidirectional.DomainCore.Calculator.Entities;
using Bidirectional.DomainCore.Calculator.Entities.DiscountAndAdditionalMargin;
using Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;
using Bidirectional.DomainCore.Calculator.Entities.Loadings;
using Bidirectional.DomainCore.Calculator.Entities.LoanCriteria;
using Bidirectional.DomainCore.Calculator.Entities.RevertingRate;
using Bidirectional.DomainCore.Calculator.Entities.TargetRate;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;
using System.Reflection;

namespace Bidirectional.DomainCore.Persistence;

public partial class PlatformDbContext
{
    /// <summary>Gets the WBC swap matrices set.</summary>
    public DbSet<WBCSwapMatrix> WBCSwapMatrices => Set<WBCSwapMatrix>();

    /// <summary>Gets the WBC swap matrix categories set.</summary>
    public DbSet<WBCSwapMatrixCategory> WBCSwapMatrixCategories => Set<WBCSwapMatrixCategory>();

    /// <summary>Gets the target base rates set.</summary>
    public DbSet<TargetBaseRate> TargetBaseRates => Set<TargetBaseRate>();

    /// <summary>Gets the target comparison metrics set.</summary>
    public DbSet<TargetComparisonMetrics> TargetComparisonMetrics => Set<TargetComparisonMetrics>();

    /// <summary>Gets the price adjustments set.</summary>
    public DbSet<PriceAdjustment> PriceAdjustments => Set<PriceAdjustment>();

    /// <summary>Gets the product loadings set.</summary>
    public DbSet<ProductLoading> ProductLoadings => Set<ProductLoading>();

    /// <summary>Gets the doc type loadings set.</summary>
    public DbSet<DocTypeLoading> DocTypeLoadings => Set<DocTypeLoading>();

    /// <summary>Gets the rate calculation criteria set.</summary>
    public DbSet<RateCalculationCriteria> RateCalculationCriteria => Set<RateCalculationCriteria>();

    /// <summary>Gets the loading percent with products set.</summary>
    public DbSet<LoadingPercentWithProduct> LoadingPercentWithProducts => Set<LoadingPercentWithProduct>();

    /// <summary>Gets the base increment reverting rates set.</summary>
    public DbSet<BaseIncrementRevertingRate> BaseIncrementRevertingRates => Set<BaseIncrementRevertingRate>();

    /// <summary>Gets the applicable fees set.</summary>
    public DbSet<ApplicableFee> ApplicableFees => Set<ApplicableFee>();

    /// <summary>Gets the base reverting rates set.</summary>
    public DbSet<BaseRevertingRate> BaseRevertingRates => Set<BaseRevertingRate>();

    /// <summary>Gets the application versions set.</summary>
    public DbSet<ApplicationVersion> ApplicationVersions => Set<ApplicationVersion>();

    /// <summary>Gets the bulk approval requests set.</summary>
    public DbSet<BulkApprovalRequest> BulkApprovalRequests => Set<BulkApprovalRequest>();

    /// <summary>Gets the rate lock fees set.</summary>
    public DbSet<RateLockFee> RateLockFees => Set<RateLockFee>();

    /// <summary>Gets the formulas set.</summary>
    public DbSet<Formula> Formulas => Set<Formula>();

    /// <summary>Gets the fees set.</summary>
    public DbSet<Fee> Fees => Set<Fee>();

    /// <summary>Gets the fee floor limits per loan type set.</summary>
    public DbSet<FeeFloorByLoanType> FeeFloorByLoanTypes => Set<FeeFloorByLoanType>();

    /// <summary>Gets the product category addition fees set.</summary>
    public DbSet<ProductCategoryAdditionFee> ProductCategoryAdditionFees => Set<ProductCategoryAdditionFee>();

    /// <summary>Gets the base values set.</summary>
    public DbSet<BaseValue> BaseValues => Set<BaseValue>();

    /// <summary>Gets the parameters set.</summary>
    public DbSet<Parameter> Parameters => Set<Parameter>();

    /// <summary>Gets the additional calculations set.</summary>
    public DbSet<AdditionalCalculation> AdditionalCalculations => Set<AdditionalCalculation>();

    /// <summary>Gets the custom slabs set.</summary>
    public DbSet<CustomSlab> CustomSlabs => Set<CustomSlab>();

    /// <summary>Gets the fee conditions set.</summary>
    public DbSet<FeeCondition> FeeConditions => Set<FeeCondition>();

    /// <summary>Gets the fee details set.</summary>
    public DbSet<FeeDetail> FeeDetails => Set<FeeDetail>();

    /// <summary>Gets the fee details custom calculations set.</summary>
    public DbSet<FeeDetailsCustomCalculation> FeeDetailsCustomCalculations => Set<FeeDetailsCustomCalculation>();

    /// <summary>Gets the product LVRs set.</summary>
    public DbSet<ProductLVR> ProductLVRs => Set<ProductLVR>();

    /// <summary>Gets the matrix details set.</summary>
    public DbSet<MatrixDetail> MatrixDetails => Set<MatrixDetail>();

    /// <summary>Gets the matrix fee condition mapper set.</summary>
    public DbSet<MatrixFeeConditionMapper> MatrixFeeConditionMapper => Set<MatrixFeeConditionMapper>();

    /// <summary>Gets the legal fees set.</summary>
    public DbSet<LegalFee> LegalFees => Set<LegalFee>();

    /// <summary>Gets the product LVR limits set.</summary>
    public DbSet<ProductLVRLimit> ProductLVRLimits => Set<ProductLVRLimit>();

    /// <summary>Gets the Early Repayment Fee set.</summary>
    public DbSet<EarlyRepaymentFee> EarlyRepaymentFees => Set<EarlyRepaymentFee>();

    /// <summary>Gets the Discount Prepayment set.</summary>
    public DbSet<DiscountPrepayment> DiscountPrepayments => Set<DiscountPrepayment>();

    /// <summary>Gets the Discount Saving Limit set.</summary>
    public DbSet<DiscountSavingLimit> DiscountSavingLimits => Set<DiscountSavingLimit>();

    /// <summary>Gets the role-based discount configuration set.</summary>
    public DbSet<RoleBasedDiscount> RoleBasedDiscounts => Set<RoleBasedDiscount>();

    /// <summary>Validates approval requests by checking that table/column exist and current old values match; returns the list of invalid requests.</summary>
    /// <param name="requests">The approval requests to validate.</param>
    /// <returns>A <see cref="Task"/> that completes with the list of invalid approval requests.</returns>
    public async Task<List<ApprovalRequest>> ValidateApprovalRequestsAsync(List<ApprovalRequest> requests)
    {
        List<ApprovalRequest> invalidRequests = new List<ApprovalRequest>();

        // group requests by entity/table
        IEnumerable<IGrouping<string?, ApprovalRequest>> grouped = requests.GroupBy(r => r.TableName);

        foreach (IGrouping<string?, ApprovalRequest> group in grouped)
        {
            // find entity type by table name
            IEntityType? entityType = Model.GetEntityTypes()
                .FirstOrDefault(t => t.GetTableName() == group.Key);

            if (entityType == null)
            {
                invalidRequests.AddRange(group); // table not mapped
                continue;
            }

            Type clrType = entityType.ClrType;
            MethodInfo? setMethod = typeof(DbContext).GetMethod(nameof(DbContext.Set), Type.EmptyTypes)
                ?? throw new InvalidOperationException("DbContext.Set<T>() method not found");

            MethodInfo genericMethod = setMethod.MakeGenericMethod(clrType);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            IQueryable set = (IQueryable)genericMethod.Invoke(this, null)
                      ?? throw new InvalidOperationException("DbContext.Set returned null");
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            // parameter: entity => ...
            ParameterExpression parameter = Expression.Parameter(clrType, "e");

            Expression? combined = null;

            foreach (ApprovalRequest req in group)
            {
                IProperty? property = entityType.FindProperty(req.FieldName ?? string.Empty);
                if (property == null)
                {
                    invalidRequests.Add(req); // column not mapped
                    continue;
                }

                // EF.Property<double>(e, "FieldName")
                MethodCallExpression left = Expression.Call(
                    typeof(EF),
                    nameof(EF.Property),
                    new[] { typeof(double) },
                    parameter,
                    Expression.Constant(req.FieldName));

                ConstantExpression right = Expression.Constant(req.OldValue);

                BinaryExpression condition = Expression.Equal(left, right);

                combined = combined == null ? condition : Expression.OrElse(combined, condition);
            }

            if (combined == null)
            {
                continue;
            }

            LambdaExpression lambda = Expression.Lambda(combined, parameter);

            // Build query dynamically: set.Where(lambda)
            MethodCallExpression whereCall = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.Where),
                new[] { clrType },
                set.Expression,
                lambda);

            IQueryable query = set.Provider.CreateQuery(whereCall);

            // Select only the matching column values back (to check)
            MethodCallExpression anyCall = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.Any),
                new[] { clrType },
                query.Expression);

#pragma warning disable CS8605 // Unboxing a possibly null value.
            MethodInfo anyMethod = typeof(EntityFrameworkQueryableExtensions)
    .GetMethods()
    .First(m => m.Name == nameof(EntityFrameworkQueryableExtensions.AnyAsync)
             && m.GetParameters().Length == 2)
    .MakeGenericMethod(clrType);

            Task<bool> task = (Task<bool>)anyMethod.Invoke(null, new object[] { query, CancellationToken.None })!;
            bool exists = await task;
#pragma warning restore CS8605 // Unboxing a possibly null value.

            if (!exists)
            {
                // all requests in this group failed
                invalidRequests.AddRange(group);
            }
        }

        return invalidRequests;
    }

}
