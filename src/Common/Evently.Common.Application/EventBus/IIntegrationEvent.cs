using System;

namespace Evently.Common.Application.EventBus;

public interface IIntegrationEvent
{
    public Guid Id { get; }

    public DateTime OccurredOnUtc { get; }
}
