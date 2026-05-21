using Bidirectional.DomainCore.BidOnboard.Entities.Organizations;

namespace Bidirectional.DomainCore.BidOnboard.Permission
{
    /// <summary>
    /// Represents the mapping between an entity access policy and an organization/business unit/user group association.
    /// </summary>
    public class EntityAccessPolicyGroupMapper : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the associated organization/business unit group mapper.
        /// </summary>
        public int? EntityAccessPolicyGroupMapper_OrganizationBusinessUnitGroupMapperID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated entity access policy.
        /// </summary>
        public int? EntityAccessPolicyGroupMapper_EntityAccessPolicyID { get; set; }

        /// <summary>
        /// Gets or sets the organization/business unit group mapper linked to this mapping.
        /// </summary>
        public OrganizationBusinessUnitGroupMapper? EntityAccessPolicyGroupMapper_OrganizationBusinessUnitGroupMapper { get; set; }

        /// <summary>
        /// Gets or sets the entity access policy linked to this mapping.
        /// </summary>
        public EntityAccessPolicy? EntityAccessPolicyGroupMapper_EntityAccessPolicy { get; set; }
    }
}
