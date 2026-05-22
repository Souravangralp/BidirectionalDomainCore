using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents target comparison rate configuration and calculated differences for a given product profile.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class TargetComparisonRateDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the target comparison rate entry.
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the minimum LVR for which this configuration applies.
        /// </summary>
        public double MinimumLVR { get; set; }

        /// <summary>
        /// Gets or sets the maximum LVR for which this configuration applies.
        /// </summary>
        public double MaximumLVR { get; set; }

        /// <summary>
        /// Gets or sets the loan type identifier.
        /// </summary>
        public int? LoanTypeID { get; set; }

        /// <summary>
        /// Gets or sets the property type identifier.
        /// </summary>
        public int? PropertyTypeID { get; set; }

        /// <summary>
        /// Gets or sets the property type name.
        /// </summary>
        public string? PropertyType { get; set; }

        /// <summary>
        /// Gets or sets the repayment type identifier.
        /// </summary>
        public int? RepaymentTypeID { get; set; }

        /// <summary>
        /// Gets or sets the repayment type name.
        /// </summary>
        public string? RepaymentType { get; set; }

        /// <summary>
        /// Gets or sets the interest type identifier (fixed or variable only).
        /// </summary>
        [Comment("This will hold only fixed and variable")]
        public int? InterestTypeID { get; set; }

        /// <summary>
        /// Gets or sets the interest type name.
        /// </summary>
        public string? InterestType { get; set; }

        /// <summary>
        /// Gets or sets the fixed term in years.
        /// </summary>
        public int? YearFixed { get; set; }

        /// <summary>
        /// Gets or sets the target base rate value.
        /// </summary>
        public double? TargetBaseRate { get; set; }

        /// <summary>
        /// Gets or sets the direct difference between calculated base and target base rate.
        /// </summary>
        public double Difference { get; set; }

        /// <summary>
        /// Gets or sets the master basic interest rate.
        /// </summary>
        public double MstBasicInterestRate { get; set; }

        /// <summary>
        /// Gets or sets the calculated base rate.
        /// </summary>
        public double CalculatedBaseRate { get; set; }

        /// <summary>
        /// Gets or sets the associated base data requests for this comparison rate.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];

        /// <summary>
        /// Gets the margin difference between calculated base rate and master basic interest rate.
        /// </summary>
        public double MarginDifference
        {
            get
            {
                decimal baseRate = (decimal)Math.Round(CalculatedBaseRate, 3, MidpointRounding.AwayFromZero);
                decimal basicInterest = (decimal)Math.Round(MstBasicInterestRate, 3, MidpointRounding.AwayFromZero);

                return
                    -(double)Math.Round(baseRate - basicInterest, 2, MidpointRounding.AwayFromZero);
            }
        }
    }

}
