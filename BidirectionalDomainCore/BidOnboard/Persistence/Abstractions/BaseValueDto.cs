using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// DTO that represents a collection result of base values returned by an operation.
    /// </summary>
    /// <remarks>
    /// The <see cref="TotalCount"/> aggregates the number of individual requests represented
    /// by the contained <see cref="BaseData"/> items.
    /// </remarks>
    [ExcludeFromCodeCoverage]
    public class BaseValueResultDto
    {
        /// <summary>
        /// Gets the total count of individual base data requests across all contained base values.
        /// </summary>
        /// <remarks>
        /// This is computed by summing <see cref="BaseValueDto.RequestCount"/> for each entry
        /// in <see cref="BaseData"/>.
        /// </remarks>
        public int TotalCount
        {
            get { return BaseData.Select(x => x.RequestCount).Sum(); }
        }

        /// <summary>
        /// Gets or sets the list of base value DTOs returned by the operation.
        /// </summary>
        public List<BaseValueDto> BaseData { get; set; } = [];
    }

    /// <summary>
    /// Represents a base value and its related metadata and requests.
    /// </summary>
    /// <remarks>
    /// Each instance can carry multiple associated request entries (<see cref="BaseDataRequestDto"/>).
    /// The <see cref="RequestCount"/> property exposes the count of those associated requests.
    /// </remarks>
    [ExcludeFromCodeCoverage]
    public class BaseValueDto
    {
        /// <summary>
        /// Gets or sets optional unique identifier for this base value (may be null if not provided).
        /// </summary>
        public string? UniqueID { get; set; }

        /// <summary>
        /// Gets or sets the numeric value for this base entry.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets optional human-friendly name for the fee associated with this value.
        /// </summary>
        public string? FeeName { get; set; }

        /// <summary>
        /// Gets or sets the unit in which <see cref="Value"/> is expressed.
        /// </summary>
        /// <remarks>
        /// See the <see cref="ValueUnit"/> enum/type for available units.
        /// </remarks>
        public ValueUnit ValueUnit { get; set; }

        /// <summary>
        /// Gets or sets optional descriptive text for this base value.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets number of individual requests associated with this base value.
        /// </summary>
        /// <remarks>
        /// This value is derived from the number of entries in <see cref="BaseDataRequestDto"/>.
        /// It is ignored when serializing to JSON because it is a computed value.
        /// </remarks>
        [JsonIgnore]
        public int RequestCount
        {
            get { return BaseDataRequestDto.Count; }
        }

        /// <summary>
        /// Gets or sets collection of request DTOs that contribute to this base value.
        /// </summary>
        public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
    }

}
