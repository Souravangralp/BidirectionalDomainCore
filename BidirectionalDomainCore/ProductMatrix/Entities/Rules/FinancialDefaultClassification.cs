namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

public class FinancialDefaultClassification : BaseAuditableEntity
{
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    public double? FromDefault { get; set; }

    public double? ToDefault { get; set; }
}
