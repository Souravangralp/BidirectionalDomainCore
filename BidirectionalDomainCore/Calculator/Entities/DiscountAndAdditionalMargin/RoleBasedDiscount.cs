using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.Calculator.Entities.DiscountAndAdditionalMargin
{
    /// <summary>
    /// Maps a user group (core general look-up) to role-based discount configuration.
    /// </summary>
    public class RoleBasedDiscount : BaseAuditableEntity
    {
        /// <summary>Gets or sets the user group type look-up ID from the core database.</summary>
        public int? UserGroupType_GeneralLookUpID { get; set; }
    }
}
