using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents loading configuration for a specific document type and product.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class DocTypeLoadingDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the document type loading entry.
        /// </summary>
        public string? UniqueID { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the document type name.
        /// </summary>
        public string? DocType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string? ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the loading percent applied for this document type.
        /// </summary>
        public double? LoadingPercent { get; set; }

        /// <summary>
        /// Gets or sets the base data requests associated with this loading.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }
}
