using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents a collection of fee detail records with aggregated request counts.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FeeDetailResultDto
    {
        /// <summary>
        /// Gets the total number of fee detail requests across all base data entries.
        /// </summary>
        public int TotalCount
        {
            get { return BaseData.Select(x => x.RequestCount).Sum(); }
        }

        /// <summary>
        /// Gets or sets the collection of fee detail records.
        /// </summary>
        public List<FeeDetailWithProductDto> BaseData { get; set; } = [];
    }

    /// <summary>
    /// Represents a fee detail entry associated with a product.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FeeDetailWithProductDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the fee detail entry.
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the increment or decrement value applied to the fee.
        /// </summary>
        public double? IncrementDecrementValue { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string? ProductName { get; set; }

        /// <summary>
        /// Gets the number of base data requests associated with this fee detail.
        /// </summary>
        public int RequestCount
        {
            get { return BaseDataRequestDto.Count; }
        }

        /// <summary>
        /// Gets or sets the base data requests associated with this fee detail.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }

}
