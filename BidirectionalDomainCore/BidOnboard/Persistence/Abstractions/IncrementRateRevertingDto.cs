using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents an increment applied to a reverting rate for a given interest type and term.
    /// </summary>
    public class IncrementRateRevertingDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the increment entry.
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the interest type identifier.
        /// </summary>
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
        /// Gets or sets the incremented reverting rate value.
        /// </summary>
        public double IncrementedValue { get; set; }

        /// <summary>
        /// Gets or sets the base data requests associated with this increment configuration.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }

}
