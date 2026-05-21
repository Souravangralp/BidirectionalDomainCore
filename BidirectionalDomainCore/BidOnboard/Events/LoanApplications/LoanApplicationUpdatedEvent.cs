using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

namespace Bidirectional.DomainCore.BidOnboard.Events.LoanApplications;

/// <summary>
/// Represents a domain event that is triggered when a loan application is updated.
/// </summary>
public class LoanApplicationUpdatedEvent : BaseEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LoanApplicationUpdatedEvent"/> class.
    /// </summary>
    /// <param name="application">The updated loan application associated with this event.</param>
    public LoanApplicationUpdatedEvent(LoanApplication application)
    {
        Application = application;
    }

    /// <summary>
    /// Gets the updated loan application associated with this event.
    /// </summary>
    public LoanApplication Application { get; }
}
