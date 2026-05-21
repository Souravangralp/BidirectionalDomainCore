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
