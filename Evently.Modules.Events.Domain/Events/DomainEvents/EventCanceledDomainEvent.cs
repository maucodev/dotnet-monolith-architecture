using Evently.Modules.Events.Domain.Abstractions;
using System;

namespace Evently.Modules.Events.Domain.Events.DomainEvents;

public sealed class EventCanceledDomainEvent(Guid eventId) : DomainEvent
{
    public Guid EventId { get; init; } = eventId;
}
