namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a fee matrix row that groups related fee conditions and fee definitions.
/// </summary>
public class MatrixDetail : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional fee ID.</summary>
    public int? MatrixDetail_FeeID { get; set; }

    /// <summary>Gets or sets the optional doc type look-up ID from the core database.</summary>
    public int? DocType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional fee.</summary>
    public Fee? MatrixDetail_Fee { get; set; }

    /// <summary>Gets or sets the matrix fee condition mappers collection.</summary>
    public ICollection<MatrixFeeConditionMapper> MatrixFeeConditionMappers { get; set; } = [];
}
