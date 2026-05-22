namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Look-up type names as stored in the core database (e.g. Residency_Type, Doc_Type).
/// Used to identify general look-up categories for dropdowns and validation.
/// </summary>
public record GeneralLookUpTypesCoreDB
{
    /// <summary>High security type.</summary>
    public const string HighSecurityType = "HighSecurity_Type";

    /// <summary>PC category type".</summary>
    public const string PCCategoryType = "PCCategory_Type";

    /// <summary>Standard and poor type.</summary>
    public const string StandardAndPoorType = "Standard_And_Poor_Type";

    /// <summary>Residency type look-up.</summary>
    public const string ResidencyType = "Residency_Type";

    /// <summary>Political exposed type look-up.</summary>
    public const string PoliticalExposedType = "Political_Exposed_Type";

    /// <summary>High risk type look-up.</summary>
    public const string HighRiskType = "High_Risk_Type";

    /// <summary>Facility type look-up.</summary>
    public const string FacilityType = "Facility_Type";

    /// <summary>Manager discretion type look-up.</summary>
    public const string ManagerDiscretionType = "Manager_Discretion_Type";

    /// <summary>Series type look-up.</summary>
    public const string SeriesType = "Series_Type";

    /// <summary>Product type look-up.</summary>
    public const string ProductType = "Product_Type";

    /// <summary>Numeral type look-up.</summary>
    public const string NumeralType = "Numeral_Type";

    /// <summary>Document type look-up.</summary>
    public const string DocType = "Doc_Type";

    /// <summary>Property type look-up.</summary>
    public const string PropertyType = "Property_Type";

    /// <summary>Occupancy type look-up.</summary>
    public const string OccupancyType = "Occupancy_Type";

    /// <summary>Repayment type look-up.</summary>
    public const string RepaymentType = "Repayment_Type";

    /// <summary>Rate type look-up.</summary>
    public const string RateType = "Rate_Type";

    /// <summary>Borrowing entity type look-up.</summary>
    public const string BorrowingEntityType = "Borrowing_Entity_Type";

    public const string LoanType = "Loan_Type";
}

/// <summary>
/// Standard series identifier for general look-ups in the core database.
/// </summary>
public record GeneralLookUpSeriesCoreDB
{
    /// <summary>Standard series ID (2288).</summary>
    public const int Standard = 2288;
}

/// <summary>
/// Payment status identifiers for general look-ups in the core database.
/// </summary>
public record GeneralLookUpPaymentStatusCoreDB
{
    /// <summary>Partial paid status ID (2549).</summary>
    public const int PartialPaid = 2549;
}
