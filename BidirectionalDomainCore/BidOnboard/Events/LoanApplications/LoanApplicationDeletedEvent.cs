using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

namespace Bidirectional.DomainCore.BidOnboard.Events.LoanApplications;

/// <summary>
/// Represents an event that is triggered when a loan application is deleted.
/// </summary>
public class LoanApplicationDeletedEvent : BaseEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LoanApplicationDeletedEvent"/> class.
    /// </summary>
    /// <param name="application">The loan application that was deleted.</param>
    public LoanApplicationDeletedEvent(LoanApplication application)
    {
        Application = application;
    }

    /// <summary>
    /// Gets the loan application that was deleted.
    /// </summary>
    public LoanApplication Application { get; }
}
