namespace Bidirectional.DomainCore.Calculator.Entities;

/// <summary>
/// Represents loading percent applied by product and related look-up types (residency, political exposed, high risk, etc.).
/// </summary>
public class LoadingPercentWithProduct : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional series type look-up ID from the core database.</summary>
    public int? SeriesType_CoreDB_GeneralLookUpID { get; set; }

    public LoadingType LoadingType { get; set; }

    public int? LoadingID { get; set; }

    /// <summary>Gets or sets the optional product type look-up ID from the core database.</summary>
    public int? ProductType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional numeral type look-up ID from the core database.</summary>
    public int? NumeralType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the loading percent (incremented or decremented value).</summary>
    [Comment("It contains incremented or decremented loading value.")]
    public double LoadingPercent { get; set; }
}
