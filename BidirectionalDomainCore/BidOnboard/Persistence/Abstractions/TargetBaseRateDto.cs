using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents target base rate configuration for a given product profile.
    /// </summary>
    public class TargetBaseRateDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the target base rate entry.
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
        /// Gets or sets the basic interest rate.
        /// </summary>
        public double BasicInterestRate { get; set; }

        /// <summary>
        /// Gets or sets the basic comparison rate.
        /// </summary>
        public double BasicComparisonRate { get; set; }

        /// <summary>
        /// Gets or sets the offset account interest rate.
        /// </summary>
        public double OffSetInterestRate { get; set; }

        /// <summary>
        /// Gets or sets the offset account comparison rate.
        /// </summary>
        public double OffSetComparisonRate { get; set; }

        /// <summary>
        /// Gets or sets the associated base data requests for this target base rate.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }

}
