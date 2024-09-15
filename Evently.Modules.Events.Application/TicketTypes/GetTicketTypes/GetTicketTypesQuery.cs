using System.Collections.Generic;
using System;
using Evently.Common.Application.Messaging;
using Evently.Modules.Events.Application.Events.GetEvent;

namespace Evently.Modules.Events.Application.TicketTypes.GetTicketTypes;

public sealed record GetTicketTypesQuery(Guid EventId) : IQuery<IReadOnlyCollection<TicketTypeResponse>>;
