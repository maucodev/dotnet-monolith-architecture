﻿using System;
using Evently.Common.Domain;

namespace Evently.Modules.Events.Domain.Categories.DomainEvents;

public sealed class CategoryArchivedDomainEvent(Guid categoryId) : DomainEvent
{
    public Guid CategoryId { get; init; } = categoryId;
}
