﻿using System;
using Evently.Modules.Events.Domain.Abstractions;

namespace Evently.Modules.Events.Domain.Events.DomainEvents;

public sealed class EventCreatedDomainEvent(Guid eventId) : DomainEvent
{
    public Guid EventId { get; init; } = eventId;
}