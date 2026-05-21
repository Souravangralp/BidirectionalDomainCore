namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a WBC swap matrix category with optional type, remark, and child matrix rows.
/// </summary>
public class WBCSwapMatrixCategory : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional category type.</summary>
    public string? CategoryType { get; set; }

    /// <summary>Gets or sets the optional remark.</summary>
    public string? Remark { get; set; }

    /// <summary>Gets or sets the list of WBC swap matrix rows.</summary>
    public List<WBCSwapMatrix> WBCSwapMatrices { get; set; } = [];
}
