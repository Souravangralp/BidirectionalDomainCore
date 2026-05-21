namespace Bidirectional.DomainCore.BidOnboard.Events.Company;

/// <summary>
/// Represents the event that is triggered when a new company is created.
/// </summary>
public class CompanyCreatedEvent : BaseEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CompanyCreatedEvent"/> class with the specified company.
    /// </summary>
    /// <param name="company">The organization entity representing the created company.</param>
    public CompanyCreatedEvent(Organization company)
    {
        Company = company;
    }

    /// <summary>
    /// Gets the organization entity associated with the created company.
    /// </summary>
    public Organization Company { get; }
}
