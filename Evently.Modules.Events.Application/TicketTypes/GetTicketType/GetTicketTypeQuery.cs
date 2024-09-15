﻿using Evently.Modules.Events.Application.Events.GetEvent;
using System;
using Evently.Common.Application.Messaging;

namespace Evently.Modules.Events.Application.TicketTypes.GetTicketType;

public sealed record GetTicketTypeQuery(Guid TicketTypeId) : IQuery<TicketTypeResponse>;
