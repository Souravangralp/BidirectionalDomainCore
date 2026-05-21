namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents various observations and qualifiers related to a loan application, including applicant employment, income characteristics, and financial dependencies.
/// </summary>
public class ApplicantObservation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related loan application for the observation.
    /// </summary>
    public int? ApplicantObservation_LoanApplicationID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the observation is related to a short-term circumstance.
    /// </summary>
    public bool ISShortTerm { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant relies on government payments.
    /// </summary>
    public bool ISGovernmentPaymentReliant { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant receives income from Airbnb activities.
    /// </summary>
    public bool ISAirBnb { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is reliant on bonuses as a source of income.
    /// </summary>
    public bool ISBonusReliant { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is a short-term professional.
    /// </summary>
    public bool ISShortTermProfessional { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is working for a family member or friend.
    /// </summary>
    public bool ISWorkingForFamilyOrFriend { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the observation relates to a financially independent child.
    /// </summary>
    public bool ISFinanciallyIndependentChild { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the observation relates to a financially independent spouse.
    /// </summary>
    public bool ISFinanciallyIndependentSpouse { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is a recent university graduate.
    /// </summary>
    public bool ISRecentUniversityGraduate { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is a short-term contractor.
    /// </summary>
    public bool ISShortTermContractor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether salary packaging applies for the applicant.
    /// </summary>
    public bool ISSalaryPackaging { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant's income is reliant on rental activities.
    /// </summary>
    public bool HASRentalReliant { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant receives income from ridesharing services such as Uber.
    /// </summary>
    public bool HASUberIncome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is considered a mortgage hostage.
    /// </summary>
    public bool HASMortgageHostage { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant's income includes commissions.
    /// </summary>
    public bool HASCommission { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is returning to full-time work after maternity leave.
    /// </summary>
    public bool HASMaternityLeaveReturningFullTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant has a higher duty assignment impacting their income.
    /// </summary>
    public bool HASHigherDuty { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is returning to part-time work after maternity leave.
    /// </summary>
    public bool HASMaternityLeaveReturningPartTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant experiences fluctuating income.
    /// </summary>
    public bool HASFluctuatingIncome { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is not returning to work after maternity leave.
    /// </summary>
    public bool HASMaternityLeaveNotReturning { get; set; }

    /// <summary>
    /// Gets or sets the related <see cref="LoanApplication"/> entity for this observation.
    /// </summary>
    public LoanApplication? ApplicantObservation_LoanApplication { get; set; }
}
