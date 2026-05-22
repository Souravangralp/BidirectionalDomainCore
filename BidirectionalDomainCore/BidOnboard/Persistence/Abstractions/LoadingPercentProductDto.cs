using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents loading percentage configuration for a product based on a general lookup value.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class LoadingPercentProductDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the loading entry.
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the general lookup identifier.
        /// </summary>
        public int? GeneralLookUpID { get; set; }

        /// <summary>
        /// Gets or sets the general lookup value.
        /// </summary>
        public string? GeneralLookUpValue { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string? ProductName { get; set; }

        /// <summary>
        /// Gets or sets the loading percent applied.
        /// </summary>
        public double LoadingPercent { get; set; }

        /// <summary>
        /// Gets or sets the base data requests associated with this loading configuration.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }

}
