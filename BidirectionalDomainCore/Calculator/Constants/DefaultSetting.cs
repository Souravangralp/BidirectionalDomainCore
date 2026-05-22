namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Default values for doc type, product, loan amount, loan term, financial days, discount, and LVR limits.
/// Includes regulatory defaults for Australian comparison rate calculations (e.g. 150000 loan, 300 months term).
/// </summary>
public record DefaultSetting
{

    public const int BookingPage = 10;

    public const int AddMoreBookingPage = 15;

    /// <summary>Default document type (Full doc).</summary>
    public const string DefaultDocType = "Full doc";

    /// <summary>Default product name (Super Prime I).</summary>
    public const string DefaultProduct = "Super Prime I";

    /// <summary>Default loan amount for comparison rate (regulatory; Australia). Discussed 04-08-2025.</summary>
    public const double LoanAmount = 150000;

    /// <summary>Default loan term in months for comparison rate (regulatory; Australia). Discussed 04-08-2025.</summary>
    public const int LoanTerm = 300;

    /// <summary>Default financial days in year for interest/day calculations (365.25).</summary>
    public const float DefaultFinancialDaysInYearForCalculation = 365.25f;

    /// <summary>Default loan term (months) used for discount calculations.</summary>
    public const int DefaultLoanTermForDiscount = 120;

    /// <summary>Default maximum discount value.</summary>
    public const int DefaultMaxDiscount = 2;

    /// <summary>Gets the default maximum LVR limits by doc type (fulldoc, altdoc, lodoc, nodoc).</summary>
    public static readonly Dictionary<string, float> DefaultLVRLimits = new()
    {
        { "fulldoc", 95 },
        { "altdoc", 85 },
        { "lodoc", 85 },
        { "nodoc", 65 },
    };
}

/// <summary>
/// Constants for number of months (e.g. months in one year).
/// </summary>
public record NoOfMonth
{
    /// <summary>Months in one year (12).</summary>
    public const int MonthsInOneYear = 12;
}

/// <summary>
/// General look-up type names (Facility_Type, High_Risk_Type, etc.) used for look-up categorization.
/// </summary>
public record GeneralLookUpsType
{
    /// <summary>Facility type look-up.</summary>
    public const string FacilityType = "Facility_Type";

    /// <summary>High risk type look-up.</summary>
    public const string HighRiskType = "High_Risk_Type";

    /// <summary>Political exposed type look-up.</summary>
    public const string PoliticalExposedType = "Political_Exposed_Type";

    /// <summary>Residency type look-up.</summary>
    public const string ResidencyType = "Residency_Type";

    /// <summary>Manager discretion type look-up.</summary>
    public const string ManagerDiscretion = "Manager_Discretion_Type";

    /// <summary>Borrowing entity type look-up.</summary>
    public const string BorrowingEntityType = "Borrowing_Entity_Type";
}

/// <summary>
/// Maximum limit constants (e.g. borrower rate cap).
/// </summary>
public record MaxLimit
{
    /// <summary>Maximum borrower rate limit (37.5).</summary>
    public const double BorrowerRate = 37.5;
}
