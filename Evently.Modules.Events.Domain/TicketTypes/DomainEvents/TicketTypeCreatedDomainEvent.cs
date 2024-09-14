using Evently.Modules.Events.Domain.Abstractions;
using System;

namespace Evently.Modules.Events.Domain.TicketTypes.DomainEvents;

public sealed class TicketTypeCreatedDomainEvent(Guid ticketTypeId) : DomainEvent
{
    public Guid TicketTypeId { get; init; } = ticketTypeId;
}
