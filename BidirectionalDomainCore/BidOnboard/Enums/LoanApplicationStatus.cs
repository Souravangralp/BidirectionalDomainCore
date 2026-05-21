namespace Bidirectional.DomainCore.BidOnboard.Enums
{
    /// <summary>
    /// Represents the possible statuses of a loan application.
    /// </summary>
    public enum LoanApplicationStatus
    {
        /// <summary>
        /// The loan application is pending and has not been processed yet.
        /// </summary>
        Pending = 0,

        /// <summary>
        /// The loan application has been approved.
        /// </summary>
        Approved = 1,

        /// <summary>
        /// The loan application has been rejected.
        /// </summary>
        Rejected = 2,

        /// <summary>
        /// The loan application has been returned for revision or further information.
        /// </summary>
        Returned = 3
    }
}
