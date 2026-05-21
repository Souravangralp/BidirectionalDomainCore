namespace Bidirectional.DomainCore.BidOnboard.Enums
{
    /// <summary>
    /// Specifies the stages involved in the loan application process.
    /// Each stage represents a distinct step in processing a loan application.
    /// </summary>
    public enum LoanApplicationProcessStage
    {
        /// <summary>
        /// Initial applicant information is collected in Form003.
        /// </summary>
        Form003 = 0,
        /// <summary>
        /// Additional applicant details are gathered using Form001.
        /// </summary>
        Form001 = 1,
        /// <summary>
        /// Further documentation is collected using Form009.
        /// </summary>
        Form009 = 2,
        /// <summary>
        /// The application is submitted for final review.
        /// </summary>
        FinalSubmit = 3,
        /// <summary>
        /// The user's information is validated.
        /// </summary>
        ValidateUser = 4,
        /// <summary>
        /// Credit check is performed on the applicant.
        /// </summary>
        CreditCheck = 5,
        /// <summary>
        /// Application is approved and moved to documentation stage.
        /// </summary>
        ApprovedForDocumentation = 6,
        /// <summary>
        /// Required signatures are collected from involved parties.
        /// </summary>
        SignatureCollection = 7,
        /// <summary>
        /// The loan is funded.
        /// </summary>
        Funded = 8,
        /// <summary>
        /// Application is placed in a frozen state, pausing processing.
        /// </summary>
        Freeze = 9,
    }
}
