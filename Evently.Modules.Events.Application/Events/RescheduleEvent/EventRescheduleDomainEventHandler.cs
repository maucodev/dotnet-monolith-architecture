using System.Threading;
using System.Threading.Tasks;
using Evently.Common.Application.Messaging;
using Evently.Modules.Events.Domain.Events.DomainEvents;

namespace Evently.Modules.Events.Application.Events.RescheduleEvent;

internal sealed class EventRescheduleDomainEventHandler : IDomainEventHandler<EventRescheduledDomainEvent>
{
    public Task Handle(EventRescheduledDomainEvent notification, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
