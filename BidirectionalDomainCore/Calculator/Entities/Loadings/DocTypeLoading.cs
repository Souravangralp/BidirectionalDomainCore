namespace Bidirectional.DomainCore.Calculator.Entities.Loadings;

/// <summary>
/// Represents doc type loading percent by doc type, product type, and numeral type.
/// </summary>
public class DocTypeLoading : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional doc type look-up ID from the core database.</summary>
    public int? DocType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the loading percent (incremented or decremented value).</summary>
    [Comment("It contains incremented or decremented loading value.")]
    public double LoadingPercent { get; set; }
}
