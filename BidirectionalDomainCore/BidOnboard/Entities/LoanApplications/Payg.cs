namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a PAYG (Pay As You Go) occupation entity for a loan application,
/// capturing details such as employment status, experience, employer information,
/// and relevant financial and contact information.
/// </summary>
public class Payg : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the applicant for this PAYG entry.
    /// </summary>
    public int? Payg_ApplicantID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant works in the same line of work as before.
    /// </summary>
    public bool? ISSameLineOfWork { get; set; }

    /// <summary>
    /// Gets or sets the time with the current or previous employer in years.
    /// </summary>
    [Comment("Time with current/previous employer in years")]
    public decimal? TimeWithCurrentEmployerYears { get; set; }

    /// <summary>
    /// Gets or sets the time with the current or previous employer in months.
    /// </summary>
    [Comment("Time with current/previous employer in months")]
    public decimal? TimeWithCurrentEmployerMonths { get; set; }

    /// <summary>
    /// Gets or sets the experience in the same or different line of work, in years.
    /// </summary>
    [Comment("Experience in the same/Different line in Years?")]
    public decimal? ExperienceInSameOrDifferentLineOfWorkYears { get; set; }

    /// <summary>
    /// Gets or sets the experience in the same or different line of work, in months.
    /// </summary>
    [Comment("Experience in the same/Different line in Months?")]
    public decimal? ExperienceInSameOrDifferentLineOfWorkMonths { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is currently on a probation period.
    /// </summary>
    public bool OnProbationPeriod { get; set; }

    /// <summary>
    /// Gets or sets the applicant's average weekly working hours.
    /// </summary>
    public decimal? AverageWeeklyHours { get; set; }

    /// <summary>
    /// Gets or sets the applicant's average number of weekly working days.
    /// </summary>
    public int? AverageWeeklyWorkingDays { get; set; }

    /// <summary>
    /// Gets or sets the start date of current employment in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? StartDateUtc { get; set; }

    /// <summary>
    /// Gets or sets an extra field for any additional information required for PAYG.
    /// </summary>
    public string? ExtraField1 { get; set; }

    /// <summary>
    /// Gets or sets an additional extra field for further information.
    /// </summary>
    public string? ExtraField2 { get; set; }

    /// <summary>
    /// Gets or sets an extra field for further extensibility.
    /// </summary>
    public string? ExtraField3 { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant is self-employed.
    /// </summary>
    public bool ISSelfEmployed { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant has a company car benefit.
    /// </summary>
    public int? CompanyCarBenefitType_GeneralLookUpID { get; set; }

    public decimal? MonthlyCarAllowance { get; set; }

    public decimal? GrossOvertimeOrPenalties { get; set; }

    /// <summary>
    /// Gets or sets the income details associated with this PAYG occupation.
    /// </summary>
    public Income? Income { get; set; }

    /// <summary>
    /// Gets or sets the employer details for the applicant.
    /// </summary>
    public EmployerDetail? EmployerDetails { get; set; }

    /// <summary>
    /// Gets or sets the related applicant entity.
    /// </summary>
    public Applicant? Payg_Applicant { get; set; }

    /// <summary>
    /// Gets or sets the applicant's employment status details.
    /// </summary>
    public EmploymentStatusDetail? EmploymentStatus { get; set; }

    /// <summary>
    /// Gets or sets the self-employed entity details, if applicable.
    /// </summary>
    public SelfEmploymentDetail? SelfEmploymentDetail { get; set; }

    #region Remove fields

    /// <summary>
    /// Gets or sets the EMMS calculated borrowing capacity.
    /// </summary>
    public double? EmmsBorrowingCapacity { get; set; }

    /// <summary>
    /// Gets or sets the applicant's comprehensive credit score.
    /// </summary>
    public string? ComprehensiveCreditScore { get; set; }

    /// <summary>
    /// Gets or sets the applicant's negative credit score, if any.
    /// </summary>
    public string? NegativeCreditScore { get; set; }

    /// <summary>
    /// Gets or sets the priority assigned to this employment instance.
    /// </summary>
    public string? EmploymentPriority { get; set; }

    /// <summary>
    /// Gets or sets the number of years in the applicant's current profession.
    /// </summary>
    public int? YearsInCurrentProfession { get; set; }

    /// <summary>
    /// Gets or sets the number of months in the applicant's current profession.
    /// </summary>
    public int? MonthsInCurrentProfession { get; set; }

    /// <summary>
    /// Gets or sets the applicant's tertiary qualifications, if any.
    /// </summary>
    public string? TertiaryQualifications { get; set; }

    /// <summary>
    /// Gets or sets the expiry date of the applicant's probation period in UTC.
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ProbationExpiryDateUtc { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant has a financially independent child.
    /// </summary>
    public bool ISFinanciallyIndependentChild { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the applicant's spouse is financially independent.
    /// </summary>
    public bool ISFinanciallyIndependentSpouse { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID representing the applicant's employment status type from the core database.
    /// </summary>
    public int? EmploymentStatusType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the applicant's contact phone number.
    /// </summary>
    public string? ContactPhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the contact number to verify the applicant's employment.
    /// </summary>
    public string? ContactNumberToVerifyEmployment { get; set; }

    /// <summary>
    /// Gets or sets the applicant's mobile number.
    /// </summary>
    public string? MobileNumber { get; set; }

    //public bool ISPrimaryEmploymentStatus { get; set; }

    //public bool ISPrimaryPAYGIncome { get; set; }

    //[Comment("We get primary and secondary PAYG income from general look ups")]
    //public int? PAYGIncomeType_GeneralLookUpID { get; set; }

    #endregion
}
