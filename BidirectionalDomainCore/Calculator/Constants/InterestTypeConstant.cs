namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Interest type IDs from the core database (fixed vs variable).
/// </summary>
public record InterestTypeConstant
{
    /// <summary>Fixed interest type ID (260).</summary>
    public const int Fixed = 260;

    /// <summary>Variable interest type ID (261).</summary>
    public const int Variable = 261;
}

/// <summary>
/// Property type IDs from the core database (owner occupied vs investment).
/// </summary>
public record PropertyTypeConstant
{
    /// <summary>Owner occupied property type ID (200).</summary>
    public const int OwnerOccupied = 200;

    /// <summary>Investment property type ID (199).</summary>
    public const int Investment = 199;
}

/// <summary>
/// Repayment type IDs from the core database (P&amp;I vs interest-only).
/// </summary>
public record RepaymentTypeConstant
{
    /// <summary>Principal and interest repayment type ID (265).</summary>
    public const int PrincipalAndInterest = 265;

    /// <summary>Interest-only repayment type ID (264).</summary>
    public const int InterestOnly = 264;
}

/// <summary>
/// Loan type IDs from the core database (residential, commercial, SMSF, personal, etc.).
/// </summary>
public record LoanTypes
{
    /// <summary>Residential loan type ID (1498).</summary>
    public const int Residential = 1498;

    /// <summary>Commercial loan type ID (1499).</summary>
    public const int Commercial = 1499;

    /// <summary>SMSF residential loan type ID (1500).</summary>
    public const int SMSFResidential = 1500;

    /// <summary>SMSF commercial loan type ID (1501).</summary>
    public const int SMSFCommercial = 1501;

    /// <summary>Secured personal loan type ID (1502).</summary>
    public const int SecuredPersonalLoan = 1502;

    /// <summary>Unsecured personal loan type ID (1503).</summary>
    public const int UnsecuredPersonal = 1503;
}
