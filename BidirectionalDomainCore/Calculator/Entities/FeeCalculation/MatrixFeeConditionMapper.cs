namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents the association between a matrix detail and a fee condition.
/// </summary>
public class MatrixFeeConditionMapper : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional matrix detail ID.</summary>
    public int? MatrixFeeConditionMapper_MatrixDetailID { get; set; }

    /// <summary>Gets or sets the optional fee condition ID.</summary>
    public int? MatrixFeeConditionMapper_FeeConditionID { get; set; }

    /// <summary>Gets or sets the optional matrix detail.</summary>
    public MatrixDetail? MatrixFeeConditionMapper_MatrixDetail { get; set; }

    /// <summary>Gets or sets the optional fee condition.</summary>
    public FeeCondition? MatrixFeeConditionMapper_FeeCondition { get; set; }
}
