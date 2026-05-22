using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents a collection of legal fee DTOs and their aggregated count.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class LegalFeeResultDto
    {
        /// <summary>
        /// Gets the total number of legal fee requests across all base data entries.
        /// </summary>
        public int TotalCount
        {
            get { return BaseData.Select(x => x.RequestCount).Sum(); }
        }

        /// <summary>
        /// Gets or sets the collection of legal fee DTOs.
        /// </summary>
        public List<ProductLegalFeeDto> BaseData { get; set; } = [];
    }

    /// <summary>
    /// Represents a legal fee configuration for a product.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class ProductLegalFeeDto
    {
        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string Product { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the legal fee amount.
        /// </summary>
        public double? Fee { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the legal fee entry.
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets the number of base data requests associated with this legal fee.
        /// </summary>
        public int RequestCount
        {
            get { return BaseDataRequestDto.Count; }
        }

        /// <summary>
        /// Gets or sets the collection of base data requests associated with this legal fee.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }

}
