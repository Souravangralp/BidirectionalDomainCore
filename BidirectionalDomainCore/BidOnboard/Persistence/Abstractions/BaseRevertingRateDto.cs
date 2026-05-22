using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents a base reverting rate configuration for a product.
    /// </summary>
    public class BaseRevertingRateDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the base reverting rate entry.
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string? ProductName { get; set; }

        /// <summary>
        /// Gets or sets the base reverting rate value.
        /// </summary>
        public double? BaseValue { get; set; }

        /// <summary>
        /// Gets or sets the base data requests associated with this base reverting rate.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }
}
