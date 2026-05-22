using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.Calculator.Entities.DiscountAndAdditionalMargin
{
    public class DiscountPrepayment : BaseAuditableEntity
    {
        /// <summary>Gets or sets the optional repayment type look-up ID from the core database.</summary>
        public int? RepaymentType_GeneralLookUpID { get; set; }

        /// <summary>Gets or sets the optional interest type look-up ID from the core database (fixed or variable).</summary>
        [Comment("This will hold only fixed and variable")]
        public int? InterestType_GeneralLookUpID { get; set; }

        /// <summary>Gets or sets the optional year fixed.</summary>
        public int? YearFixed { get; set; }

        /// <summary>Gets or sets the optional Loan Term In Year.</summary>
        public int? LoanTermInYear { get; set; }

        /// <summary>Gets or sets the optional Prepayment Percent.</summary>
        public double? PrepaymentPercent { get; set; }
    }

}
