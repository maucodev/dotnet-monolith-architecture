using Evently.Modules.Events.Domain.Abstractions;
using System;

namespace Evently.Modules.Events.Domain.Categories.DomainEvents;

public sealed class CategoryCreatedDomainEvent(Guid categoryId) : DomainEvent
{
    public Guid CategoryId { get; init; } = categoryId;
}
