using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents loading configuration for a specific product.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class ProductLoadingDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the product loading entry.
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the loading percent applied to the product.
        /// </summary>
        public double LoadingPercent { get; set; }

        /// <summary>
        /// Gets or sets the base data requests associated with this product loading.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = new();
    }
}
