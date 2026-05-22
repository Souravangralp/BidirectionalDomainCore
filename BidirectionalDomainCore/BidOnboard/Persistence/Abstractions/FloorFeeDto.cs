using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents a collection of floor fee DTOs and their aggregated count.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FloorFeeResultDto
    {
        /// <summary>
        /// Gets the total number of floor fee requests across all base data entries.
        /// </summary>
        public int TotalCount
        {
            get { return BaseData.Select(x => x.RequestCount).Sum(); }
        }

        /// <summary>
        /// Gets or sets the collection of floor fee DTOs.
        /// </summary>
        public List<FloorFeeDto> BaseData { get; set; } = [];
    }

    /// <summary>
    /// Represents a floor fee configuration for a product or fee type.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FloorFeeDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the floor fee entry.
        /// </summary>
        public string? UniqueID { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the fee type name.
        /// </summary>
        public string? FeeType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a description for the floor fee.
        /// </summary>
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the minimum floor fee amount for display (unrestricted loan type when present, otherwise first row).
        /// </summary>
        public double MinimumFloorFee { get; set; }

        /// <summary>
        /// Gets or sets the maximum floor fee amount for display (same resolution as <see cref="MinimumFloorFee"/>).
        /// </summary>
        public double MaximumFloorFee { get; set; }

        /// <summary>
        /// Gets the number of base data requests associated with this floor fee.
        /// </summary>
        [JsonIgnore]
        public int RequestCount
        {
            get { return BaseDataRequestDto.Count; }
        }

        /// <summary>
        /// Gets or sets the collection of base data requests associated with this floor fee.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }

}
