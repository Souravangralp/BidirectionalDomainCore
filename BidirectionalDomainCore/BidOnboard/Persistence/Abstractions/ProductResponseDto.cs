using Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;

namespace Bidirectional.Application.Common.Models;

/// <summary>
/// Represents a response object containing detailed product information for API responses.
/// </summary>
public class ProductResponseDto
{
    /// <summary>
    /// The unique identifier for the product.
    /// </summary>
    public string? UniqueID { get; set; }

    /// <summary>
    /// The general lookup ID corresponding to the product type in the core database.
    /// </summary>
    public int? ProductType_GeneralLookUpID { get; set; }

    /// <summary>
    /// The name of the product.
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// An override name for the product, if applicable.
    /// </summary>
    public string? OverRideProductName { get; set; }

    /// <summary>
    /// A collection of base data request DTOs related to the product.
    /// </summary>
    public List<BaseDataRequestDto> BaseDataRequestDto { get; set; } = [];
}
