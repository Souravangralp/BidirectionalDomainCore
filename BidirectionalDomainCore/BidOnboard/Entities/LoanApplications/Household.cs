namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a household entity within a loan application, including information about the applicant, spouse, dependents, and financial attributes.
/// </summary>
public class Household : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the household.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the first name of the spouse in the household.
    /// </summary>
    public string? SpouseFirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name or surname of the spouse in the household.
    /// </summary>
    public string? SpouseLastNameORSurname { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the household is financially independent.
    /// </summary>
    public bool IsFinanciallyIndependent { get; set; }

    /// <summary>
    /// Gets or sets the date of birth associated with the household.
    /// </summary>
    public string? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the number of dependents in the household.
    /// </summary>
    public string? DependentsCount { get; set; }

    /// <summary>
    /// Gets or sets the number of adults in the household.
    /// </summary>
    public string? AdultsCount { get; set; }

    public decimal? AnnualTotal { get; set; }

    public decimal? MonthlyTotal { get; set; }

    public int? NumberOfPersons { get; set; }

    /// <summary>
    /// Gets or sets the list of living expenses associated with the household.
    /// </summary>
    public IList<LivingExpense> LivingExpenses { get; set; } = new List<LivingExpense>();

    /// <summary>
    /// Gets or sets the collection of percent ownership entries related to the household.
    /// </summary>
    public IList<HouseholdOwnershipPercentage> HouseholdOwnershipPercentages { get; set; } = new List<HouseholdOwnershipPercentage>();
}
