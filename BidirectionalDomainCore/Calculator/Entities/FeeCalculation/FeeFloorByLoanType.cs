using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.Calculator.Entities.FeeCalculation
{
    /// <summary>
    /// Represents minimum and maximum floor fee amounts for a fee definition, scoped by loan type.
    /// </summary>
    public class FeeFloorByLoanType : BaseAuditableEntity
    {
        /// <summary>Gets or sets the optional fee identifier this floor limit belongs to.</summary>
        public int? FeeFloorByLoanType_FeeID { get; set; }

        /// <summary>Gets or sets the optional loan type look-up identifier.</summary>
        public int? LoanType_GeneralLookUpID { get; set; }

        /// <summary>Gets or sets the minimum floor fee.</summary>
        public double MinimumFloorFee { get; set; }

        /// <summary>Gets or sets the maximum floor fee.</summary>
        public double MaximumFloorFee { get; set; }

        /// <summary>Gets or sets the parent fee.</summary>
        public Fee? FeeFloorByLoanType_Fee { get; set; }
    }
}
