namespace Bidirectional.DomainCore.Calculator.Entities.LoanCriteria;

/// <summary>
/// Represents rate calculation criteria including doc type, property type, and product LVR limits.
/// </summary>
public class RateCalculationCriteria : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional doc type look-up ID from the core database.</summary>
    public int? DocType_CoreDB_GeneralLookUpID { get; set; }

    //public int? RateCalculationCriteria_ProductCategoryID { get; set; }

    /// <summary>Gets or sets the optional property type look-up ID from the core database.</summary>
    public int? PropertyType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional manager discretion type look-up ID from the core database.</summary>
    public int? ManagerDiscretionType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets the optional series type look-up ID from the core database.</summary>
    public int? SeriesType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>Gets or sets a value indicating whether mortgage insurance applies.</summary>
    public bool HASMortgageInsurance { get; set; }

    //public string? LoanType { get; set; }

    /// <summary>Gets or sets the list of product LVR limits.</summary>
    public List<ProductLVRLimit> ProductLVRLimits { get; set; } = [];
}
