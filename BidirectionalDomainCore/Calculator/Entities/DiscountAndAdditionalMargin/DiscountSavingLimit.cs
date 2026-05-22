using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.Calculator.Entities.DiscountAndAdditionalMargin
{
    public class DiscountSavingLimit : BaseAuditableEntity
    {
        /// <summary>Gets or sets the optional interest type look-up ID from the core database (fixed or variable).</summary>
        [Comment("This will hold only fixed and variable")]
        public int? InterestType_GeneralLookUpID { get; set; }

        /// <summary>Gets or sets the optional year fixed.</summary>
        public int? YearFixed { get; set; }

        /// <summary>Gets or sets a value indicating whether gets or sets the visible at UI.</summary>
        public bool ISVisible { get; set; }

        /// <summary>Gets or sets the optional Saving Time In Year.</summary>
        public int? SavingTimeInYear { get; set; }
    }

}
