using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities.Organizations;

/// <summary>
/// Represents the association between a user and an organization business unit group.
/// </summary>
public class OrganizationBusinessUnitGroupUserMapper : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated organization group mapper.
    /// </summary>
    public int? OrganizationGroupMapperID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated user.
    /// </summary>
    public int? UserID { get; set; }

    public string? BookingStaffID { get; set; }

    /// <summary>
    /// Gets or sets the user assigned to the business unit group.
    /// </summary>
    public User? User { get; set; }

    /// <summary>
    /// Gets or sets the organization business unit group mapper associated with the user.
    /// </summary>
    public OrganizationBusinessUnitGroupMapper? OrganizationGroupMapper { get; set; }
}
