using Evently.Modules.Events.Application.Abstractions.Messaging;
using System.Collections.Generic;

namespace Evently.Modules.Events.Application.Events.GetEvents;

public sealed record GetEventsQuery : IQuery<IReadOnlyCollection<EventResponse>>;
