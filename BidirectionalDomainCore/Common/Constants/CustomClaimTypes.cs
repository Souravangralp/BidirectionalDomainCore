using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.Common.Constants
{
    /// <summary>
    /// Contains constant values for custom claim types used for user and organizational identification within the application.
    /// </summary>
    public record CustomClaimTypes
    {
        /// <summary>
        /// Claim type for the branch identifier.
        /// </summary>
        public const string BranchID = "branchID";

        /// <summary>
        /// Claim type for the raw branch identifier.
        /// </summary>
        public const string RawBranchID = "rawBranchID";

        /// <summary>
        /// Claim type for the branch name.
        /// </summary>
        public const string BranchName = "branchName";

        /// <summary>
        /// Claim type for the company identifier.
        /// </summary>
        public const string CompanyID = "companyID";

        /// <summary>
        /// Claim type for the raw company identifier.
        /// </summary>
        public const string RawCompanyID = "rawCompanyID";

        /// <summary>
        /// Claim type for the company name.
        /// </summary>
        public const string CompanyName = "companyName";

        /// <summary>
        /// Claim type for the aggregator identifier.
        /// </summary>
        public const string AggregatorID = "aggregatorID";

        /// <summary>
        /// Claim type for the raw aggregator identifier.
        /// </summary>
        public const string RawAggregatorID = "rawAggregatorID";

        /// <summary>
        /// Claim type for the group identifier.
        /// </summary>
        public const string GroupID = "groupID";

        /// <summary>
        /// Claim type for the user identifier.
        /// </summary>
        public const string UserID = "userID";

        /// <summary>
        /// Claim type for the raw user identifier.
        /// </summary>
        public const string RawUserID = "rawUserID";

        //public const string AggregatorName = "aggregatorName";
    }

}
