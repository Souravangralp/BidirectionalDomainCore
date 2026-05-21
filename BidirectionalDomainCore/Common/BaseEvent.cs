using MediatR;

namespace Bidirectional.DomainCore.Common;

/// <summary>
/// Represents the abstract base class for all domain events,
/// providing a contract for implementing notification events within the domain.
/// </summary>
public abstract class BaseEvent : INotification
{
}