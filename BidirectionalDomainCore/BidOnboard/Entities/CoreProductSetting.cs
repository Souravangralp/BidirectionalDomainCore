using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities
{
    /// <summary>
    /// Represents the settings specific to a core product, including its organizational and business unit relationships.
    /// </summary>
    public class CoreProductSetting : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the related organization for the core product setting.
        /// </summary>
        public int? CoreProductSetting_OrganizationID { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the related business unit for the core product setting.
        /// </summary>
        public int? CoreProductSetting_BusinessUnitID { get; set; }

        /// <summary>
        /// Gets or sets the general lookup identifier for the product type in the CoreDB.
        /// </summary>
        public int? ProductType_GeneralLookUpID { get; set; }

        /// <summary>
        /// Gets or sets an optional override name for the product.
        /// </summary>
        public string? OverRideProductName { get; set; }

        /// <summary>
        /// Gets or sets the related organization entity for the core product setting.
        /// </summary>
        public Organization? CoreProductSetting_Organization { get; set; }

        /// <summary>
        /// Gets or sets the related business unit entity for the core product setting.
        /// </summary>
        public BusinessUnit? CoreProductSetting_BusinessUnit { get; set; }
    }
}
