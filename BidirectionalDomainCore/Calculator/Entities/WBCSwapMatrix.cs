namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents a WBC swap matrix row with optional category, interest type, year fixed, and value.
/// </summary>
public class WBCSwapMatrix : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional WBC swap matrix category ID.</summary>
    public int? WBCSwapMatrix_WBCSwapMatrixCategoryID { get; set; }

    /// <summary>Gets or sets the optional interest type look-up ID from the core database.</summary>
    public int? InterestType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional year fixed.</summary>
    public int? YearFixed { get; set; }

    /// <summary>Gets or sets the value.</summary>
    public double Value { get; set; }

    /// <summary>Gets or sets the optional WBC swap matrix category.</summary>
    public WBCSwapMatrixCategory? WBCSwapMatrix_WBCSwapMatrixCategory { get; set; }
}
