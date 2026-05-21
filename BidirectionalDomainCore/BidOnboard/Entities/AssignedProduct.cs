using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities
{
    /// <summary>
    /// Represents an assigned product within the system, including core product settings and related organizational details.
    /// </summary>
    public class AssignedProduct : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the organization associated with the core product setting.
        /// </summary>
        public int? CoreProductSetting_OrganizationID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the business unit associated with the core product setting.
        /// </summary>
        public int? CoreProductSetting_BusinessUnitID { get; set; }

        /// <summary>
        /// Gets or sets the general lookup identifier for the core database product type.
        /// </summary>
        public int? ProductType_GeneralLookUpID { get; set; }

        /// <summary>
        /// Gets or sets the organization entity associated with the core product setting.
        /// </summary>
        public Organization? CoreProductSetting_Organization { get; set; }

        /// <summary>
        /// Gets or sets the business unit entity associated with the core product setting.
        /// </summary>
        public BusinessUnit? CoreProductSetting_BusinessUnit { get; set; }
    }
}
