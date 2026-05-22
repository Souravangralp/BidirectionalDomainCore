namespace Bidirectional.DomainCore.Calculator.Constants;

/// <summary>
/// Repayment type values as stored in the core database general look-up (P&amp;I vs interest-only).
/// </summary>
public record RepaymentTypeCoreDBGeneralLookUp
{
    /// <summary>Principal and interest repayment type ("p&i").</summary>
    public const string PAndI = "p&i";

    /// <summary>Interest-only repayment type ("io").</summary>
    public const string IO = "io";
}

public record LoanTypeConstant
{
    public const int Residential = 1498;

    public const int Commercial = 1499;

    public const int SMSFResidential = 1500;

    public const int SMSFCommercial = 1501;
}

public record FeeTypeConstant
{
    public const int EstablishmentFee = 4;
}
