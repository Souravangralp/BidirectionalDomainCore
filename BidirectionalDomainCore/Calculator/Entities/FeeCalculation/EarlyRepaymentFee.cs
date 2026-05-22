namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation
{
    public class EarlyRepaymentFee : BaseAuditableEntity
    {
        public int? BorrowingEntityType_GeneralLookUpID { get; set; }

        public double? EarlyRepaymentFeePercent { get; set; }

        public double? MinimumHoldingPeriodYears { get; set; }
    }

}
