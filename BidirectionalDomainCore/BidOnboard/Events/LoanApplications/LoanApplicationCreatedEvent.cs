using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

namespace Bidirectional.DomainCore.BidOnboard.Events.LoanApplications;

/// <summary>
/// Represents an event that is triggered when a loan application is created.
/// </summary>
public class LoanApplicationCreatedEvent : BaseEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LoanApplicationCreatedEvent"/> class with the specified loan application.
    /// </summary>
    /// <param name="application">The loan application associated with this event.</param>
    public LoanApplicationCreatedEvent(LoanApplication application)
    {
        LoanApplication = application;
    }

    /// <summary>
    /// Gets the loan application associated with this event.
    /// </summary>
    public LoanApplication LoanApplication { get; }
}
