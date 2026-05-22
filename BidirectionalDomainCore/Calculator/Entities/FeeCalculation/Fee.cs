namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation;

/// <summary>
/// Represents a high-level fee definition, including ranges, multiplicity, and inclusion flags.
/// </summary>
public class Fee : BaseAuditableEntity
{
    /// <summary>Gets or sets the optional fee type.</summary>
    public string? FeeType { get; set; }

    /// <summary>Gets or sets the minimum floor fee.</summary>
    public double MinimumFloorFee { get; set; }

    /// <summary>Gets or sets the maximum floor fee.</summary>
    public double MaximumFloorFee { get; set; }

    /// <summary>Gets or sets the number of mortgages.</summary>
    public int NoOfMortgages { get; set; }

    /// <summary>Gets or sets the multiple times fee.</summary>
    public double MultipleTimesFee { get; set; }

    /// <summary>Gets or sets a value indicating whether the fee is included in comparison rate.</summary>
    public bool ISIncludedInComparisonRate { get; set; }

    /// <summary>Gets or sets a value indicating whether the fee is included in borrower rate.</summary>
    public bool ISIncludedInBorrowerRate { get; set; }

    /// <summary>Gets or sets a value indicating whether the fee is independent.</summary>
    public bool ISIndependent { get; set; }

    /// <summary>Gets or sets floor fee limits per loan type.</summary>
    public ICollection<FeeFloorByLoanType> FeeFloorByLoanTypes { get; set; } = [];
}
