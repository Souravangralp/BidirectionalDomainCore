using Bidirectional.DomainCore.Calculator.Constants;

namespace Bidirectional.DomainCore.Calculator.Enums;

/// <summary>
/// Specifies the different types of loading categories used in the system.
/// </summary>
public enum LoadingType
{
    /// <summary>
    /// Represents loading based on residency type.
    /// </summary>
    ResidencyType = 1,

    /// <summary>
    /// Represents loading for politically exposed persons (PEP).
    /// </summary>
    PoliticalExposedType = 2,

    /// <summary>
    /// Represents loading for high-risk classifications.
    /// </summary>
    HighRiskCountryType = 3,

    /// <summary>
    /// Represents loading based on facility type.
    /// </summary>
    FacilityType = 4,

    /// <summary>
    /// Represents loading applied through manager discretion.
    /// </summary>
    ManagerDiscretionType = 5,

    /// <summary>
    /// Represents loading based on borrowing entity type.
    /// </summary>
    BorrowingEntityType = 6,

    /// <summary>
    /// Represents loading based on loan type.
    /// </summary>
    LoanType = 7,
}

public static class LoadingTypeMapper
{
    public static string ToCoreDbKey(this LoadingType type)
    {
        return type switch
        {
            LoadingType.ResidencyType => GeneralLookUpTypesCoreDB.ResidencyType,
            LoadingType.PoliticalExposedType => GeneralLookUpTypesCoreDB.PoliticalExposedType,
            LoadingType.HighRiskCountryType => GeneralLookUpTypesCoreDB.HighRiskType,
            LoadingType.FacilityType => GeneralLookUpTypesCoreDB.FacilityType,
            LoadingType.ManagerDiscretionType => GeneralLookUpTypesCoreDB.ManagerDiscretionType,
            LoadingType.BorrowingEntityType => GeneralLookUpTypesCoreDB.BorrowingEntityType,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }

    public static LoadingType FromCoreDbKey(string key)
    {
        return key switch
        {
            GeneralLookUpTypesCoreDB.ResidencyType => LoadingType.ResidencyType,
            GeneralLookUpTypesCoreDB.PoliticalExposedType => LoadingType.PoliticalExposedType,
            GeneralLookUpTypesCoreDB.HighRiskType => LoadingType.HighRiskCountryType,
            GeneralLookUpTypesCoreDB.FacilityType => LoadingType.FacilityType,
            GeneralLookUpTypesCoreDB.ManagerDiscretionType => LoadingType.ManagerDiscretionType,
            GeneralLookUpTypesCoreDB.BorrowingEntityType => LoadingType.BorrowingEntityType,
            GeneralLookUpTypesCoreDB.LoanType => LoadingType.LoanType,
            _ => throw new ArgumentOutOfRangeException(nameof(key), key, null)
        };
    }
}
